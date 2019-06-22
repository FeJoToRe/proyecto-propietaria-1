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
	public partial class Vista_Transacciones : Form
	{
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();
		public Vista_Transacciones()
		{
			InitializeComponent();
		}
		//editar transacciones 
		private void btnEditar_Click(object sender, EventArgs e)
		{
			FrmTransaccion tran = new FrmTransaccion();
			TRANSACCION transaccion = null;

			if (dgvTransacciones.SelectedRows.Count > 0)
			{
				int id = int.Parse(dgvTransacciones.SelectedRows[0].Cells["ID_transaccion"].Value.ToString());
				transaccion = entities.TRANSACCION.First(x => x.ID_transaccion == id);
			}
			tran.transaccion = transaccion;
			tran.Show();
			this.Close();
		}
		//agregar transacciones
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			FrmTransaccion tran = new FrmTransaccion();
			tran.Show();
			this.Close();
		}

		private void Vista_Transacciones_Load(object sender, EventArgs e)
		{
			dgvTransacciones.DataSource = entities.TRANSACCION.Select(x => x).ToList();
		}
		//eliminar transacciones
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvTransacciones.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(dgvTransacciones.SelectedRows[0].Cells["ID_transaccion"].Value.ToString());
				TRANSACCION transaccion = entities.TRANSACCION.First(x => x.ID_transaccion == id);
				entities.TRANSACCION.Remove(transaccion);
				entities.SaveChanges();
				Vista_Transacciones_Load(sender, e);
			}
		}
	}
}
