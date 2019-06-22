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
	public partial class FrmGestion_clientes : Form
	{
		public CLIENTE cliente { get; set; }
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public FrmGestion_clientes()
		{
			InitializeComponent();
			//int dato = entities.CLIENTE.LastOrDefault(x => x.ID_cliente);
			//txt_ID_cliente.Text = dato.ToString();
		}
		//Validacion del cliente
		private void FrmGestion_clientes_Load(object sender, EventArgs e)
		{

			if (cliente != null)
			{
				txt_ID_cliente.Text = cliente.ID_cliente.ToString();
				txtNombre.Text = cliente.Nombre;
				txtCedula.Text = cliente.Cedula.ToString();
				txtCredito.Text = cliente.Limite_credito.ToString();
				chbxCliente.Checked = cliente.Estado;
			}

		}

		private void consultarClientes()
		{

		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{

		}
		//boton guardar cliente 
		private void SaveCliente_Click(object sender, EventArgs e)
		{
			if (cliente == null)
			{
				cliente = new CLIENTE();
				entities.CLIENTE.Add(cliente);
			}

			cliente.Nombre = txtNombre.Text;
			cliente.Cedula = txtCedula.Text;
			cliente.Limite_credito = decimal.Parse(txtCredito.Text);
			cliente.Estado = chbxCliente.Checked;

			entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito");
			this.Close();
		}

		//salir de la ventana
		private void SalirCliente_Click(object sender, EventArgs e) => this.Close();

	}
}
