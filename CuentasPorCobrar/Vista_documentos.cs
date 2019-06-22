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

		private void buttonCrear_Click(object sender, EventArgs e)
		{
			FrmTipo_documento doc = new FrmTipo_documento();
			doc.ShowDialog();
		}

		private void buttonEditar_Click(object sender, EventArgs e)
		{
			FrmTipo_documento doc = new FrmTipo_documento();
			TIPO_DOCUMENTO documento = null;

			if (DgvDocumentos.SelectedRows.Count > 0)
			{
				int id = Int32.Parse(DgvDocumentos.SelectedRows[0].Cells["ID_documento"].Value.ToString());
				documento = entities.TIPO_DOCUMENTO.First(x => x.ID_documento == id);
			}
			doc.Documento = documento;
			doc.ShowDialog();
		}

		private void buttonEliminar_Click(object sender, EventArgs e)
		{
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
	}
}
