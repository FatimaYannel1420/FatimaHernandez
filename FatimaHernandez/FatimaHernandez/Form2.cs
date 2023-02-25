using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatimaHernandez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ENERO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("FEBRERO");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MARZO");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ABRIL");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MAYO");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("JUNIO");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("JULIO");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("AGOSTO");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("SEPTIEMBRE");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("OCTUBRE");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("NOVIEMBRE");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("DICIEMBRE");
        }

        private void txt_i_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void calcular ()
        {
            double Capital = 2000;
            double Interes = 0.015;
            double total=1;
            double res=0;
            
            if (listBox1.Text == btnEnero.Text) { 
                total = (Capital*Interes) / 1;
            }
            if (listBox1.Text == btnFebrero.Text)
            {
                total = (Capital * Interes) / 2;
            }
            if (listBox1.Text == btnMarzo.Text)
            {
                total = (Capital * Interes) / 3;
            }
            if (listBox1.Text == btnAbril.Text)
            {
                total = (Capital * Interes) / 4;
            }
            if (listBox1.Text == btnMayo.Text)
            {
                total = (Capital * Interes) / 5;
            }
            if (listBox1.Text == btnJunio.Text)
            {
                total = (Capital * Interes) / 6;
            }
            
            MessageBox.Show("Resultado " + total);
            
        }

        private void txt_suma_TextChanged(object sender, EventArgs e)
        {
            
           
            
            
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            
            calcular();
        }
    }
}
