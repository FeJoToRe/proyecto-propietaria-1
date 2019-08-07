using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
	public partial class FrmTransaccion : Form
	{
		public TRANSACCION transaccion { get; set; }
		public Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public FrmTransaccion()
		{
			InitializeComponent();

			cbxIDCliente.DataSource = entities.CLIENTE.Select(x => x).ToList();
			cbxIDCliente.SelectedIndex = 0;
			cbxIDCliente.DisplayMember = "Nombre";
			

			cbxIDTipo.DataSource = entities.TIPO_DOCUMENTO.Select(x => x).ToList();
			cbxIDTipo.SelectedIndex = 0;
			cbxIDTipo.DisplayMember = "Descripcion";
			

            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
		}
        //
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
		//validacion transaccion
		private void FrmTransaccion_Load(object sender, EventArgs e)
		{
            cbxTipoMov.SelectedIndex = 0;

			if (transaccion != null)
			{
				cbxTipoMov.Text = transaccion.Tipo_movimiento.ToString();
                cbxIDTipo.SelectedIndex = cbxIDTipo.FindStringExact(transaccion.TIPO_DOCUMENTO.Descripcion);
                
				txtNro_doc.Text = transaccion.Num_documento.ToString();
				
                cbxIDCliente.SelectedIndex = cbxIDCliente.FindStringExact(transaccion.CLIENTE.Nombre);
                txtMonto.Text = transaccion.Monto.ToString();
                txtFecha.Text = transaccion.Fecha.ToString("dd/MM/yyyy");
			}

		}
        Validaciones obj = new Validaciones();
        //guardar transaccion
        private void SaveTransc_Click(object sender, EventArgs e)
		{

            Vista_Transacciones vt = new Vista_Transacciones();
            if (transaccion == null)
            {
                transaccion = new TRANSACCION();
                entities.TRANSACCION.Add(transaccion);
            }
            
            transaccion.Tipo_movimiento = cbxTipoMov.Text;
            transaccion.TIPO_DOCUMENTO = (TIPO_DOCUMENTO) cbxIDTipo.SelectedItem;
            transaccion.Num_documento = int.Parse(txtNro_doc.Text);
            transaccion.CLIENTE = (CLIENTE) cbxIDCliente.SelectedItem;
            transaccion.Monto = decimal.Parse(txtMonto.Text);
            transaccion.Fecha = DateTime.ParseExact (txtFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            BALANCE balance = entities.BALANCE.First(b => b.ID_cliente == transaccion.CLIENTE.ID_cliente);
            //seleccion de la operacion 
            if (cbxTipoMov.SelectedItem.ToString() == "Credito")
            {
                if (balance.Monto < transaccion.Monto)      
                {
                    MessageBox.Show("balance insuficiente");
                }
                else
                {

                    balance.Monto -= transaccion.Monto;
                    entities.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                    vt.Show();
                    this.Close();
                }
            }
            else if (cbxTipoMov.SelectedItem.ToString() == "Debito")       
            {
                
                    balance.Monto += transaccion.Monto;
                    entities.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                    vt.Show();
                    this.Close();
                
            }

           
		}

		private void SalirTransc_Click(object sender, EventArgs e)
		{
			Vista_Transacciones vt = new Vista_Transacciones();
			vt.Show();
			Close();

		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNumeros(e);

        }

        private void txtNro_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNumeros(e);

        }
    }
}

