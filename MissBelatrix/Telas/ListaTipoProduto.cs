using MissBelatrix.Camadas.BLL;
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
    public partial class ListaTipoProduto : Form
    {
        public ListaTipoProduto()
        {
            InitializeComponent();
        }

        private void ListaTipoProduto_Load(object sender, EventArgs e)
        {
            CarregaListaTipoProdutos();
        }

        public void CarregaListaTipoProdutos()
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            grvListaTipoProdutos.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroTipoProduto cadastroTipoProduto = new CadastroTipoProduto(this);
            cadastroTipoProduto.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            CadastroTipoProduto cadastroTipoProduto = new CadastroTipoProduto(Convert.ToInt32(grvListaTipoProdutos.CurrentRow.Cells[1].Value), this);
            cadastroTipoProduto.Show();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ExcluirTipoProduto();
        }

        private void ExcluirTipoProduto()
        {
            TipoProdutoBLL bll = new TipoProdutoBLL();
            bll.Delete(Convert.ToInt32(grvListaTipoProdutos.CurrentRow.Cells[1].Value));
            CarregaListaTipoProdutos();
        }

        private void grvListaTipoProdutos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in grvListaTipoProdutos.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells[0].Value = true;
                    }
                    else
                    {
                        row.Cells[0].Value = false;
                    }
                }
            }
        }
    }
}
