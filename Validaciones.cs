using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafica
{
    class Validaciones
    {
        public static void Numeros(KeyPressEventArgs ev, TextBox num, bool neg, bool dec)
        {
            if (Char.IsDigit(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (Char.IsControl(ev.KeyChar))
            {
                ev.Handled = false;
            }
            else if (ev.KeyChar.ToString().Equals(".") &&
                !num.Text.Contains(".") && dec)
            {
                ev.Handled = false;
            }
            else if (ev.KeyChar.ToString().Equals("-") &&
                !num.Text.Contains("-") &&
                num.Text == "" && neg)
            {
                ev.Handled = false;
            }
            else
            {
                ev.Handled = true;
                MessageBox.Show("No se puede ingresar", "Numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
