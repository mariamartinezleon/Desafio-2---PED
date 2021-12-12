using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Vertice : Form
    {
        public bool control;
        public string dato;

        public Vertice()
        {
            InitializeComponent();
            control = false;
            dato = "";
        }

        private void Vertice_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = textBox1.Text.Trim();

            if((valor=="") || (valor == " "))
            {
                MessageBox.Show("Debe ingresar un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                control = true;
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control = false;
            Hide();
        }

        private void Vertice_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Vertice_Shown(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }

    }
}
