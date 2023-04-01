using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void txtdeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 97 && e.KeyChar <= 120 || e.KeyChar >= 65 && e.KeyChar <= 90)
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdeposito != null)
            {
                string a = "0";
                string linea;
                StreamReader petra = File.OpenText("cash.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        a = linea;

                    }
                } while (linea != null);
                petra.Close();
                int va = Convert.ToInt32(a), val =Convert.ToInt32(txtdeposito.Text);
                va += val;
                string s, d;
                s = Convert.ToString(va);
                d = Convert.ToString(val);
                StreamWriter fichero;

                fichero = File.AppendText("cash.txt");//se crea txt
                fichero.WriteLine(" + "+d);
                fichero.Write(s);
                fichero.Close();
            }
            else
            {
                MessageBox.Show("El texto esta vacio");
            }
            Form3 reg = new Form3();
            Hide();
            reg.ShowDialog();
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }
    }
}
