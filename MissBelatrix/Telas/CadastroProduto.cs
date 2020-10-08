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
    public partial class CadastroProduto : Form
    {
        private readonly ListaProdutos _ListaProdutos;
        int _CdProduto;

        public CadastroProduto(ListaProdutos pListaProdutos)
        {
            InitializeComponent();
            _ListaProdutos = pListaProdutos;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
            CarregaComboBoxes();
        }

        public CadastroProduto(int pCdProduto, ListaProdutos pListaProdutos)
        {
            InitializeComponent();
            _ListaProdutos = pListaProdutos;
            _CdProduto = pCdProduto;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            CarregaProduto(pCdProduto);
        }

        private void CarregaComboBoxes(int pCdTipoProduto = 0, int pCdTamanho = 0, int pCdCor = 0)
        {
            CarregaTipoProdutos(pCdTipoProduto);
            CarregaTamanhos(pCdTamanho);
            CarregaCores(pCdCor);
        }

        private void CarregaTipoProdutos(int pCdTipoProduto = 0)
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            cbCdTipoProduto.DataSource = bll.Listar();
            cbCdTipoProduto.DisplayMember = "DsTipoProduto";
            cbCdTipoProduto.ValueMember = "CdTipoProduto";
            cbCdTipoProduto.SelectedValue = pCdTipoProduto as object;
        }

        private void CarregaTamanhos(int pCdTamanho = 0)
        {
            TamanhoBLL bll = new TamanhoBLL();
            cbCdTamanho.DataSource = bll.Listar();
            cbCdTamanho.DisplayMember = "DsTamanho";
            cbCdTamanho.ValueMember = "CdTamanho";
            cbCdTamanho.SelectedValue = pCdTamanho as object;
        }

        private void CarregaCores(int pCdCor = 0)
        {
            CorBLL bll = new CorBLL();
            cbCdCor.DataSource = bll.Listar();
            cbCdCor.DisplayMember = "DsCor";
            cbCdCor.ValueMember = "CdCor";
            cbCdCor.SelectedValue = pCdCor as object;
        }

        private void CarregaProduto(int pCdProduto)
        {
            ProdutoBLL bll = new ProdutoBLL();
            ProdutoInfo info = bll.Get(pCdProduto);

            txtDsProduto.Text = info.DsProduto;
            txtVlPreco.Text = info.VlPreco.ToString();
            CarregaComboBoxes(info.CdTipoProduto, info.CdTamanho, info.CdCor);
        }

        private void CadastraNovoProduto()
        {
            ProdutoBLL bll = new ProdutoBLL();
            ProdutoInfo info = new ProdutoInfo();

            info.DsProduto = txtDsProduto.Text;
            info.CdTipoProduto = ((TipoProdutoInfo)cbCdTipoProduto.SelectedItem).CdTipoProduto;
            info.CdTamanho = ((TamanhoInfo)cbCdTamanho.SelectedItem).CdTamanho;
            info.CdCor = ((CorInfo)cbCdCor.SelectedItem).CdCor;
            info.VlPreco = float.Parse(txtVlPreco.Text);

            bll.Inserir(info);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoProduto();
            AtualizaGridProdutos();
            LimparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarProduto();
            AtualizaGridProdutos();
        }

        private void AtualizarProduto()
        {
            ProdutoBLL bll = new ProdutoBLL();
            ProdutoInfo info = new ProdutoInfo();

            info.CdProduto = _CdProduto;
            info.DsProduto = txtDsProduto.Text;
            info.VlPreco  = float.Parse(txtVlPreco.Text);
            info.CdTipoProduto = ((TipoProdutoInfo)cbCdTipoProduto.SelectedItem).CdTipoProduto;
            info.CdTamanho = ((TamanhoInfo)cbCdTamanho.SelectedItem).CdTamanho;
            info.CdCor = ((CorInfo)cbCdCor.SelectedItem).CdCor;

            bll.Update(info);
            this.Close();
        }

        private void AtualizaGridProdutos()
        {
            _ListaProdutos.CarregaListaProdutos();
        }

        private void LimparCampos()
        {
            txtDsProduto.Text = string.Empty;
            txtVlPreco.Text = string.Empty;
            CarregaComboBoxes();
        }
    }
}
