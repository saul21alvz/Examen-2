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
    public partial class Form1 : Form
    {
        Form3 ventana;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblagre_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblagre_Click(object sender, EventArgs e)
        {
            Form2 pedir;
            pedir = new Form2();
            pedir.ShowDialog();

            string nip = pedir.getPass();
            MessageBox.Show(nip);

            if (validarnip(nip))
            {
                MessageBox.Show("El usuario ya existe");
            }
            else
            {
                StreamWriter fichero;

                fichero = File.AppendText("exanip.txt");//se crea txt
                fichero.WriteLine(nip);
                fichero.Close();
                MessageBox.Show("El nip se a guardado");
            }
        }

        private bool validarnip(string u)
        {
            string linea;
            bool ban = false;
            if (File.Exists("exanip.txt"))
            {
                StreamReader petra = File.OpenText("exanip.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        if (linea.Equals(u))
                        {
                            ban = true;
                            break;
                        }
                    }
                } while (linea != null);
                petra.Close();
            }
            else
            {
                MessageBox.Show("El archivo de registro no existe");
            }
            return ban;
        }

        private void btnacep_Click(object sender, EventArgs e)
        {
            string linea;
            bool ban = false;
            if (File.Exists("exanip.txt"))
            {
                StreamReader petra = File.OpenText("exanip.txt");
                do
                {
                    linea = petra.ReadLine();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        if (linea.Equals(txtnip.Text))
                        {
                            ban = true;
                        }
                    }
                } while (linea != null);
                if (ban)
                {
                    //this.Hide();
                    petra.Close();
                    ventana = new Form3();
                    ventana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("El usuario no esta registrado");
                }

            }
            else
            {
                MessageBox.Show("No se han registrado ningun usuario");
            }
        }

        private void txtnip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 97 && e.KeyChar <= 120 || e.KeyChar >= 65 && e.KeyChar <= 90)
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }
    }
}
