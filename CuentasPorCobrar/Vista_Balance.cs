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
	public partial class Vista_Balance : Form
	{
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();
		public Vista_Balance()
		{
			InitializeComponent();
		}

		private void Vista_Balance_Load(object sender, EventArgs e)
		{
			dgvBalance.DataSource = entities.BALANCE.Select(x => x).ToList();
		}
		//editar balance
		private void btnEditar_Click(object sender, EventArgs e)
		{
			FrmBalance bal = new FrmBalance();
			BALANCE balance = null;

            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

            if (dgvBalance.SelectedRows.Count > 0)
			{												//refiere a la tabla cliente
				int id = int.Parse(dgvBalance.SelectedRows[0].Cells["ID_cliente"].Value.ToString());
				balance = entities.BALANCE.First(x => x.ID_cliente == id);
			}
			bal.balance = balance;
			bal.Show();
			this.Close();
		}
		//agregar balance
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmBalance bal = new FrmBalance();
			bal.Show();
			this.Close();
		}
		//eliminar balance
		private void btnEliminar_Click(object sender, EventArgs e)
		{
            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

            if (dgvBalance.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(dgvBalance.SelectedRows[0].Cells["ID_balance"].Value.ToString());
				BALANCE balance = entities.BALANCE.First(x => x.ID_balance == id);
				entities.BALANCE.Remove(balance);
				entities.SaveChanges();
				Vista_Balance_Load(sender, e);
			}
		}

        private void buttonBuscarBalance_Click(object sender, EventArgs e)
        {
            IQueryable<CuentasPorCobrar.BALANCE> balances;
            switch (cbxVistaBalance.SelectedItem.ToString())
            {
                case "ID cliente":
                    balances = from balance in entities.BALANCE
                               where balance.ID_cliente.ToString().Contains(txtBoxVistaBalance.Text)
                               select balance;
                    break;
                case "ID balance":
                    balances = from balance in entities.BALANCE
                               where balance.ID_balance.ToString().Contains(txtBoxVistaBalance.Text)
                               select balance;
                    break;
                default:
                    balances = from balance in entities.BALANCE
                               select balance;
                    break;
            }
            this.dgvBalance.DataSource = balances.ToList();

        }
        

        private void txtBoxVistaBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}