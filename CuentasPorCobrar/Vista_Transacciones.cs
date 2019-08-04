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

            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

            if (dgvTransacciones.SelectedRows.Count > 0)
			{
				int id = int.Parse(dgvTransacciones.SelectedRows[0].Cells["ID_transaccion"].Value.ToString());
				transaccion = tran.entities.TRANSACCION.First(x => x.ID_transaccion == id);
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
            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

            if (dgvTransacciones.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(dgvTransacciones.SelectedRows[0].Cells["ID_transaccion"].Value.ToString());
				TRANSACCION transaccion = entities.TRANSACCION.First(x => x.ID_transaccion == id);
				entities.TRANSACCION.Remove(transaccion);
				entities.SaveChanges();
				Vista_Transacciones_Load(sender, e);
			}
		}

        private void buttonBuscarVista_Click(object sender, EventArgs e)
        {
            IQueryable<CuentasPorCobrar.TRANSACCION> transacciones;
            switch (cbxVistaTransc.SelectedItem.ToString())
            {
                case "ID transaccion":
                    transacciones = from transaccion in entities.TRANSACCION
                               where transaccion.ID_transaccion.ToString().Contains(txtBoxVistaTransc.Text)
                               select transaccion;
                    break;
                case "Tipo movimiento":
                    transacciones = from transaccion in entities.TRANSACCION
                               where transaccion.Tipo_movimiento.ToString().Contains(txtBoxVistaTransc.Text)
                               select transaccion;
                    break;
                case "Nro documento":
                    transacciones = from transaccion in entities.TRANSACCION
                               where transaccion.ID_documento.ToString().Contains(txtBoxVistaTransc.Text)
                               select transaccion;
                    break;
                default:
                    transacciones = from transaccion in entities.TRANSACCION
                               select transaccion;
                    break;
            }
            this.dgvTransacciones.DataSource = transacciones.ToList();

        }
        

        private void txtBoxVistaTransc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worsheet = null;
            worsheet = workbook.Sheets["Hoja1"];
            worsheet = workbook.ActiveSheet;
            worsheet.Name = "Reporte Cuentas por Cobrar";

            for (int i = 1; i < dgvTransacciones.Columns.Count + 1; i++)
            {
                worsheet.Cells[1, i] = dgvTransacciones.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvTransacciones.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTransacciones.Columns.Count; j++)
                {
                    worsheet.Cells[i + 2, j + 1] = dgvTransacciones.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Reporte Transacciones " + today.ToString("dd-MM-yyyy");
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
