using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_1_solucion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double valor, iva, valorFinal;

            valor = double.Parse(txtValor.Text);

            iva = valor * 0.19;

            valorFinal = valor + iva;

            lblIva.Text = Convert.ToString(iva); 
            label3.Visible = true;
            lblIva.Visible = true;


            lblValorFinal.Text = Convert.ToString(valorFinal);
            label6.Visible = true;
            lblValorFinal.Visible = true; 
           

           


        }

      
    }
}
