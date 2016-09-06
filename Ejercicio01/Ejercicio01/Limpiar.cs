using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    class Limpiar
    {
        public void BorrarCampos(Control control) 
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }

            //listBox
            //foreach (var lista in lb.Controls)
            //{
            //    if (lista is ListBox)
            //    {
            //        ((ListBox)lista).Items.Clear();
            //    }
            //}
        }
    }
}
