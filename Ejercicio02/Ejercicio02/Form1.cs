using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
                double total = double.Parse(txtIngreso.Text);
                double descuento = 0;
                double dsc = 0;
                if (total >= 30 && total <= 50)
                {
                    descuento = 0.10;
                    dsc = total * 0.10;
                    txtDescuento.Text = dsc.ToString();

                }
                else if (total > 50)
                {
                    descuento = 0.20;
                    dsc = total * 0.20;
                    txtDescuento.Text = dsc.ToString();
                }
                else
                {
                    descuento = 0;
                    dsc = total * 0;
                    txtDescuento.Text = dsc.ToString();
                }
                txtTotal.Text = (total * (1 - descuento)).ToString();
                     
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            //foreach (Control control in txtIngreso.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        ((TextBox)control).Clear();
            //    }
            //}

            this.txtIngreso.Clear();

        }


    }
}
