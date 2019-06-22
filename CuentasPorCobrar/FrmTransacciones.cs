using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
	public partial class FrmTransaccion : Form
	{
		public TRANSACCION transaccion { get; set; }
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public FrmTransaccion()
		{
			InitializeComponent();

			cbxIDCliente.DataSource = entities.CLIENTE.Select(x => x).ToList();
			cbxIDCliente.SelectedIndex = 0;
			cbxIDCliente.DisplayMember = "Nombre";
			cbxIDCliente.ValueMember = "ID_cliente";

			cbxIDTipo.DataSource = entities.TIPO_DOCUMENTO.Select(x => x).ToList();
			cbxIDTipo.SelectedIndex = 0;
			cbxIDTipo.DisplayMember = "Descripcion";
			cbxIDTipo.ValueMember = "ID_documento";
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
		//validacion transaccion
		private void FrmTransaccion_Load(object sender, EventArgs e)
		{
			if (transaccion != null)
			{
				txtID_transc.Text = transaccion.ID_transaccion.ToString();
				cbxTipoMov.Text = transaccion.Tipo_movimiento.ToString();
				cbxIDTipo.Text = transaccion.ID_documento.ToString();
				txtNro_doc.Text = transaccion.Num_documento.ToString();
				cbxIDCliente.Text = transaccion.ID_cliente.ToString();
				txtMonto.Text = transaccion.Monto.ToString();
				DTP_fecha_transc.Value = transaccion.Fecha;//esto hay que cambiarlo

			}

		}
		//guardar transaccion
		private void SaveTransc_Click(object sender, EventArgs e)
		{
			Vista_Transacciones vt = new Vista_Transacciones();

			entities.TRANSACCION.Add(new TRANSACCION
			{
				//ID_transaccion = int.Parse(txtID_transc.Text),
				Tipo_movimiento = cbxTipoMov.Text,
				ID_documento = int.Parse(cbxIDTipo.SelectedValue.ToString()),
				Num_documento = int.Parse(txtNro_doc.Text),
				ID_cliente = int.Parse(cbxIDCliente.SelectedValue.ToString()),
				Monto = decimal.Parse(txtMonto.Text),
				Fecha = DTP_fecha_transc.Value
			});
			entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito");
			vt.Show();
			this.Close();
		}

		private void SalirTransc_Click(object sender, EventArgs e)
		{
			Vista_Transacciones vt = new Vista_Transacciones();
			vt.Show();
			Close();

		}
	}
}

