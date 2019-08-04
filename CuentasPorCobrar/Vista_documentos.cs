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
	public partial class Vista_documentos : Form
	{
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public Vista_documentos()
		{
			InitializeComponent();
		}
        //boton crear
		private void buttonCrear_Click(object sender, EventArgs e)
		{
			FrmTipo_documento doc = new FrmTipo_documento();
			doc.ShowDialog();
		}
        //boton editar
		private void buttonEditar_Click(object sender, EventArgs e)
		{
			FrmTipo_documento doc = new FrmTipo_documento();
			TIPO_DOCUMENTO documento = null;

            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

            if (DgvDocumentos.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(DgvDocumentos.SelectedRows[0].Cells["ID_documento"].Value.ToString());
				documento = entities.TIPO_DOCUMENTO.First(x => x.ID_documento == id);
			}
			doc.Documento = documento;
			doc.ShowDialog();
		}
        //boton eliminar
		private void buttonEliminar_Click(object sender, EventArgs e)
		{
            if (!Validaciones.ValidarAdmin())
            {
                MessageBox.Show("Acceso restringido para este rol");
                return;
            }

            if (DgvDocumentos.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(DgvDocumentos.SelectedRows[0].Cells["ID_documento"].Value.ToString());
				TIPO_DOCUMENTO documento = entities.TIPO_DOCUMENTO.First(x => x.ID_documento == id);
				entities.TIPO_DOCUMENTO.Remove(documento);
				entities.SaveChanges();
				Vista_documentos_Load(sender, e);
			}
		}

		private void Vista_documentos_Load(object sender, EventArgs e)
		{
			DgvDocumentos.DataSource = entities.TIPO_DOCUMENTO.Select(x => x).ToArray(); 
		}

         

        private void cbxVistaDocs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarDocs_Click(object sender, EventArgs e)
        {
            IQueryable<CuentasPorCobrar.TIPO_DOCUMENTO> documentos;
            switch (cbxVistaDocs.SelectedItem.ToString())
            {
                case "ID documento":
                    documentos = from documento in entities.TIPO_DOCUMENTO
                               where documento.ID_documento.ToString().Contains(textBoxVistaDocs.Text)
                               select documento;
                    break;
                case "Descripcion":
                    documentos = from documento in entities.TIPO_DOCUMENTO
                               where documento.Descripcion.ToString().Contains(textBoxVistaDocs.Text)
                               select documento;
                    break;
                default:
                    documentos = from documento in entities.TIPO_DOCUMENTO
                               select documento;
                    break;
            }
            this.DgvDocumentos.DataSource = documentos.ToList();
        }
        

        private void textBoxVistaDocs_KeyPress(object sender, KeyPressEventArgs e)
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

            for (int i = 1; i < DgvDocumentos.Columns.Count + 1; i++)
            {
                worsheet.Cells[1, i] = DgvDocumentos.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < DgvDocumentos.Rows.Count; i++)
            {
                for (int j = 0; j < DgvDocumentos.Columns.Count; j++)
                {
                    worsheet.Cells[i + 2, j + 1] = DgvDocumentos.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Reporte documentos " + today.ToString("dd-MM-yyyy");
            saveFileDialoge.DefaultExt = ".xlsx";

            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
