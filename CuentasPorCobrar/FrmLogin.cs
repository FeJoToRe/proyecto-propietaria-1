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
    public partial class FrmLogin : Form
    {
        Cuentas_por_cobrarEntities db = new Cuentas_por_cobrarEntities();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            USUARIOS usuario = (from u in db.USUARIOS
                                where u.Usuario.Equals(txtUser.Text) &&
                                      u.Clave.Equals(txtPassw.Text)
                                select u).FirstOrDefault();

            if (usuario == null)
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            else if (!usuario.Estado.Equals("A"))
            {
                MessageBox.Show("Credenciales incorrectas");
            }
            else
            {
                MessageBox.Show("Bienvenido " + txtUser.Text);
                Program.usuario = usuario;
                Menu frm = new Menu();
                txtUser.Text = "";
                txtPassw.Text = "";
                frm.Show();
                Hide();
            }
        }
    }
}
