using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApostilaDeCSharp.OrientacaoObjetos;

namespace ApostilaDeCSharp.InterfaceGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;
            p.QtdePontos = int.Parse(txtPonto.Text);

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Voar(p));
        }

        private void btnNadar_Click(object sender, EventArgs e)
        {
            Personagem p = new Personagem();
            p.Nome = txtNome.Text;

            Movimentacao m = new Movimentacao();
            MessageBox.Show(m.Nadar(p));
        }

        private void btnPular_Click(object sender, EventArgs e)
        {

        }

        private void btnVirarAEsquerda_Click(object sender, EventArgs e)
        {

        }

        private void btnVirarADireita_Click(object sender, EventArgs e)
        {

        }

        private void btnAndar_Click(object sender, EventArgs e)
        {

        }

        private void btnParar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
