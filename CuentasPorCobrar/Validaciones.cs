using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    public class Validaciones
    {
        public void ValidarLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //permitir que el usuario digite una letra
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))//permitir que ingrese espacios
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))//permitir borrado de letras
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void ValidarNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //permitir que el usuario digite un numero
            {
                e.Handled = false;
            }
           
            else if (char.IsControl(e.KeyChar))//permitir borrado de letras
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
