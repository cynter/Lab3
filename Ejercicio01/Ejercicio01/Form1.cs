using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (MessageBox.Show("Esta seguro de cerrar la aplicación?", "Confirmación Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);

            //limpiar.BorrarCampos(this, lstTabla);

            this.lstTabla.Items.Clear();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                 lstTabla.Items.Add(this.txtNumero.Text + " * " + i + " = " + int.Parse(this.txtNumero.Text) * i);
             }
        }

    }
}
