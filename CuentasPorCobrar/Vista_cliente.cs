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
	public partial class Vista_cliente : Form
	{
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public Vista_cliente()
		{
			InitializeComponent();
		}

		private void Vista_cliente_Load(object sender, EventArgs e)
		{
			this.DgvClientes.DataSource = entities.CLIENTE.Select(x => x).ToArray();
		}
		//crear clientes 
		private void buttonCrear_Click(object sender, EventArgs e)
		{
			FrmGestion_clientes cl = new FrmGestion_clientes();
			cl.ShowDialog();
			Vista_cliente_Load(sender, e);

		}
		//editar clientes 
		private void buttonEditar_Click(object sender, EventArgs e)
		{
			FrmGestion_clientes cl = new FrmGestion_clientes();
			CLIENTE cliente = null;
			if (DgvClientes.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(DgvClientes.SelectedRows[0].Cells["ID_cliente"].Value.ToString());
				cliente = entities.CLIENTE.First(x => x.ID_cliente == id);
			}
			cl.cliente = cliente;
			cl.ShowDialog();
			Vista_cliente_Load(sender, e);

		}
		//borrar clientes
		private void buttonBorrar_Click(object sender, EventArgs e)
		{
			if (DgvClientes.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(DgvClientes.SelectedRows[0].Cells["ID_cliente"].Value.ToString());
				CLIENTE cliente = entities.CLIENTE.First(x => x.ID_cliente == id);
				entities.CLIENTE.Remove(cliente);
				entities.SaveChanges();
				Vista_cliente_Load(sender,e);
			}
		}
	}
}
