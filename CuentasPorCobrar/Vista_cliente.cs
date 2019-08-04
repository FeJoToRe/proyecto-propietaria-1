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

            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

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
            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                    return;
            }

			if (DgvClientes.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(DgvClientes.SelectedRows[0].Cells["ID_cliente"].Value.ToString());
				CLIENTE cliente = entities.CLIENTE.First(x => x.ID_cliente == id);
				entities.CLIENTE.Remove(cliente);
				entities.SaveChanges();
				Vista_cliente_Load(sender,e);
			}
		}
        //busqueda por criterios clientes 

            // para los demas criterios, cambiarle el campo del where y el case segun lo que se necesite
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           IQueryable < CuentasPorCobrar.CLIENTE> clientes;
            switch (cbxBuscar.SelectedItem.ToString()){
                case "ID cliente":
                clientes = from cliente in entities.CLIENTE
                               where cliente.ID_cliente.ToString().Contains(textBoxBuscar.Text)
                               select cliente;
                    break;
                case "Nombre":
                    clientes = from cliente in entities.CLIENTE
                               where cliente.Nombre.ToString().Contains(textBoxBuscar.Text)
                               select cliente;
                    break;
                case "Cedula":
                    clientes = from cliente in entities.CLIENTE
                               where cliente.Cedula.ToString().Contains(textBoxBuscar.Text)
                               select cliente;
                    break;
                default:
                    clientes = from cliente in entities.CLIENTE
                               select cliente;
                    break;
            }
            this.DgvClientes.DataSource = clientes.ToList();

        }
        

        private void textBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 1; i < DgvClientes.Columns.Count + 1; i++)
            {
                worsheet.Cells[1, i] = DgvClientes.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < DgvClientes.Rows.Count; i++)
            {
                for (int j = 0; j < DgvClientes.Columns.Count; j++)
                {
                    worsheet.Cells[i + 2, j + 1] = DgvClientes.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Reporte clientes " + today.ToString("dd-MM-yyyy");
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
