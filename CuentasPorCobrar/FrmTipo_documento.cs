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
	public partial class FrmTipo_documento : Form
	{
		public TIPO_DOCUMENTO Documento { get; set; }
		private Cuentas_por_cobrarEntities entities = new Cuentas_por_cobrarEntities();

		public FrmTipo_documento()
		{
			InitializeComponent();
		}
		//Validacion de documentos
		private void FrmTipo_documento_Load(object sender, EventArgs e)
		{
			if (Documento != null)
			{
				txtID_doc.Text = Documento.ID_documento.ToString();
				txtDescrip.Text = Documento.Descripcion.ToString();
				chbxActivo.Checked = Documento.Activo;
			}
		}
		//boton guardar documento
		private void SaveDoc_Click(object sender, EventArgs e)
		{

			if (Documento == null)
			{
				entities.TIPO_DOCUMENTO.Add(new TIPO_DOCUMENTO
				{
					Descripcion = txtDescrip.Text,
					Activo = chbxActivo.Checked,
				});
			}
			else
			{
				Documento.Descripcion = txtDescrip.Text;
				Documento.Activo = chbxActivo.Checked;
			}

			entities.SaveChanges();
			MessageBox.Show("Datos guardados con exito");
			this.Close();
		}
        //boton salir
		private void SalirDoc_Click(object sender, EventArgs e) => Close();

        Validaciones obj = new Validaciones();

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarLetras(e);
        }
    }
}
