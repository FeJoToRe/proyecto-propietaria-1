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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void button8_Click(object sender, EventArgs e) => Close();
		//Invocacion cliente, button2 = cliente
		private void button2_Click(object sender, EventArgs e)
		{
			Vista_cliente cl = new Vista_cliente();
			cl.Show();
		}
		//Invocacion documentos, button1 = documentos
		private void button1_Click(object sender, EventArgs e)
		{
			Vista_documentos doc = new Vista_documentos();
			doc.Show();
		}
		//Invocacion transacciones
		private void button3_Click(object sender, EventArgs e)
		{
			Vista_Transacciones tran = new Vista_Transacciones();
			tran.Show();
		}
		//Invocacion balances
		private void button4_Click(object sender, EventArgs e)
		{
			Vista_Balance bal = new Vista_Balance();
			bal.Show();
		}

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
