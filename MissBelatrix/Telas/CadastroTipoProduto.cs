using MissBelatrix.Camadas.BLL;
using MissBelatrix.Camadas.Info;
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
    public partial class CadastroTipoProduto : Form
    {
        private readonly ListaTipoProduto _ListaTipoProduto;
        int _CdTipoProduto;

        public CadastroTipoProduto(ListaTipoProduto pListaTipoProduto)
        {
            InitializeComponent();
            _ListaTipoProduto = pListaTipoProduto;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        public CadastroTipoProduto(int pCdTipoProduto, ListaTipoProduto pListaTipoProduto)
        {
            InitializeComponent();
            _ListaTipoProduto = pListaTipoProduto;
            _CdTipoProduto = pCdTipoProduto;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            CarregaTipoProduto(pCdTipoProduto);
        }

        private void CarregaTipoProduto(int pCdTipoProduto)
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            TipoProdutoInfo info = bll.Get(pCdTipoProduto);

            txtDsTipoProduto.Text = info.DsTipoProduto;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTipoProduto();
            AtualizaGridTipoProduto();
        }

        private void CadastraNovoTipoProduto()
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            TipoProdutoInfo info = new TipoProdutoInfo();

            info.DsTipoProduto = txtDsTipoProduto.Text;
            bll.Inserir(info);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTipoProduto();
            AtualizaGridTipoProduto();
        }

        private void AtualizarTipoProduto()
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            TipoProdutoInfo info = new TipoProdutoInfo();

            info.CdTipoProduto = _CdTipoProduto;
            info.DsTipoProduto = txtDsTipoProduto.Text;

            bll.Update(info);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizaGridTipoProduto()
        {
            _ListaTipoProduto.CarregaListaTipoProdutos();
        }
    }
}
