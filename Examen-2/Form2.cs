using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class Form2 : Form
    {
        string a;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 97 && e.KeyChar <= 120 || e.KeyChar >= 65 && e.KeyChar <= 90)
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btngua_Click(object sender, EventArgs e)
        {
            a = txtn.Text;
            getPass();
            this.Hide();
        }
        public string getPass()
        {
            return a;
        }
    }
}
