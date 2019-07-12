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
	public partial class FrmBalance : Form
	{
		public BALANCE balance { get; set; }
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public FrmBalance()
		{
			InitializeComponent();
		}
		//validacion balance
		private void FrmBalance_Load(object sender, EventArgs e)
		{
			cbxIDcliente.DataSource = entities.CLIENTE.Select(c => c).ToArray();
			cbxIDcliente.DisplayMember = "Nombre";

			if (balance != null)
			{
				cbxIDcliente.SelectedIndex = cbxIDcliente.FindStringExact(balance.CLIENTE.Nombre);
				DTP_balance.Text = balance.Fecha_corte.ToString();
				txtMontoBal.Text = balance.Monto.ToString();
			}
		}
		//guardar balance
		private void SaveBalance_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMontoBal.Text))
			{
				MessageBox.Show("Error: debe llenar los campos en blanco");
				return;
			}

			if (balance == null)
			{
				balance = new BALANCE();//esto lo copie directo 
				entities.BALANCE.Add(balance);
			}

			balance.CLIENTE = (CLIENTE)cbxIDcliente.SelectedValue;
			balance.Fecha_corte = DateTime.Today;
			balance.Monto = decimal.Parse(txtMontoBal.Text);
			
			entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito");
			this.Close();
		}

		//salir de la ventana
		private void DeleteBalance_Click(object sender, EventArgs e) => Close();
	}
}
