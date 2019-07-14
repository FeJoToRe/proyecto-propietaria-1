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
                MessageBox.Show("Solo se permite ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool validaCedula(string pCedula)


        {

            int vnTotal = 0;

            string vcCedula = pCedula.Replace("-", "");

            int pLongCed = vcCedula.Trim().Length;

            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };



            if (pLongCed < 11 || pLongCed > 11)

                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)

            {

                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                if (vCalculo < 10)

                    vnTotal += vCalculo;

                else

                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));

            }

            if (vnTotal % 10 == 0)

                return true;
            else
                return false;

        }
    }
}