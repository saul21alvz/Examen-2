using Microsoft.Win32;
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
    public partial class Form3 : Form
    {
        string a = "0";
        public Form3()
        {
            InitializeComponent();
            string linea;
            if (File.Exists("cash.txt"))
            {
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
            }
            else
            {
                StreamWriter fichero;
                
                fichero = File.AppendText("cash.txt");//se crea txt
                fichero.Write(a);
                fichero.Close();
            }
            lblsaldo.Text = a;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito reg = new Deposito();
            Hide();
            reg.ShowDialog();
        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retiro reg = new Retiro();
            Hide();
            reg.ShowDialog();
        }
    }
}
