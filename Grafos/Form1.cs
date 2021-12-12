using ParcialGrafo;
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
    public partial class Simulador : Form
    {
        private CGrafo grafo;
        private CVertice nuevoNodo;
        private CVertice NodoOrigen;
        private CVertice NodoDestino;
        private int var_contro = 0;

        private CVertice ventanaVertice;

        public Simulador()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_contro = 0;
            ventanaVertice = new CVertice();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void Simulador_Load(object sender, EventArgs e)
        {

        }

        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pizarra_MouseLeave(object sender, EventArgs e)
        {
            Pizarra.Refresh();
        }

        private void nuevoVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoNodo = new CVertice();
            var_contro = 2;
        }

        private void Pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            switch(var_contro)
            {
                case 1:
                    if((NodoDestino=grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                    {
                        if (grafo.AgregarArco(NodoOrigen, NodoDestino)) ;
                    }
            }
        }
    }
}
