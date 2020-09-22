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
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
        }

        private void CarregaComboBoxes()
        {
            CarregaTipoProdutos();
            CarregaTamanhos();
            CarregaCores();
        }

        private void CarregaTipoProdutos()
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            cbCdTipoProduto.DataSource = bll.Listar();
            cbCdTipoProduto.DisplayMember = "DsTipoProduto";
            cbCdTipoProduto.ValueMember = "CdTipoProduto";
        }

        private void CarregaTamanhos()
        {
            TamanhoBLL bll = new TamanhoBLL();
            cbCdTamanho.DataSource = bll.Listar();
            cbCdTamanho.DisplayMember = "DsTamanho";
            cbCdTamanho.ValueMember = "CdTamanho";
        }

        private void CarregaCores()
        {
            CorBLL bll = new CorBLL();
            cbCdCor.DataSource = bll.Listar();
            cbCdCor.DisplayMember = "DsCor";
            cbCdCor.ValueMember = "CdCor";
        }

        private void CadastraNovoProduto()
        {
            ProdutoBLL bll = new ProdutoBLL();
            ProdutoInfo info = new ProdutoInfo();
            CorBLL corBLL = new CorBLL();

            info.DsProduto = txtDsProduto.Text;
            info.CdTipoProduto = ((TipoProdutoInfo)cbCdTipoProduto.SelectedItem).CdTipoProduto;
            info.CdTamanho = ((TamanhoInfo)cbCdTamanho.SelectedItem).CdTamanho;
            info.CdCor = ((CorInfo)cbCdCor.SelectedItem).CdCor;
            info.VlPreco = txtVlPreco.Text;

            bll.Inserir(info);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoProduto();
        }
    }
}
