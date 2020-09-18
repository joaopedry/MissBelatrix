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

        private void CadastraNovoProduto()
        {
            ProdutoBLL bll = new ProdutoBLL();
            ProdutoInfo info = new ProdutoInfo();

            info.DsProduto = txtDsProduto.Text;
            info.CdTipoProduto = cbCdTipoProduto.SelectedIndex;
            info.CdTamanho = cbCdTamanho.SelectedIndex;
            info.CdCor = cbCdCor.SelectedIndex;
            info.VlPreco = txtVlPreco.Text;

            bll.Inserir(info);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoProduto();
        }
    }
}
