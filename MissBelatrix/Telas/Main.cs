using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissBelatrix.Telas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {
            ListaProdutos listaProdutos = new ListaProdutos();
            listaProdutos.Show();
        }

        private void menuTipoAcessos_Click(object sender, EventArgs e)
        {
            ListaTipoAcesso listaTipoAcesso = new ListaTipoAcesso();
            listaTipoAcesso.Show();
        }

        private void menuTipoProdutos_Click(object sender, EventArgs e)
        {
            ListaTipoProduto listaTipoProduto = new ListaTipoProduto();
            listaTipoProduto.Show();
        }

        private void menuTamanhos_Click(object sender, EventArgs e)
        {
            ListaTamanho listaTamanho = new ListaTamanho();
            listaTamanho.Show();
        }

        private void menuCores_Click(object sender, EventArgs e)
        {
            ListaCores listaCores = new ListaCores();
            listaCores.Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaEntradaSaida caixaEntradaSaida = new CaixaEntradaSaida();
            caixaEntradaSaida.Show();
        }
    }
}
