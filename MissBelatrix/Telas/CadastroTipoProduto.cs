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
        public CadastroTipoProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTipoProduto();
        }

        private void CadastraNovoTipoProduto()
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            TipoProdutoInfo info = new TipoProdutoInfo();

            info.DsTipoProduto = txtDsTipoProduto.Text;
            bll.Inserir(info);
        }
    }
}
