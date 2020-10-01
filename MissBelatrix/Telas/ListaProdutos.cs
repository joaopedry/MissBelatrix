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
    public partial class ListaProdutos : Form
    {
        public ListaProdutos()
        {
            InitializeComponent();
        }

        private void ListaProdutos_Load(object sender, EventArgs e)
        {
            CarregaListaProdutos();
        }

        public void CarregaListaProdutos()
        {
            ProdutoBLL bll = new ProdutoBLL();
            grvListaProdutos.DataSource = bll.Listar();
            grvListaProdutos.Update();
            grvListaProdutos.Refresh();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto(this);
            cadastroProduto.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto(Convert.ToInt32(grvListaProdutos.CurrentRow.Cells[1].Value), this);
            cadastroProduto.Show();
        }

        private void grvListaProdutos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in grvListaProdutos.Rows)
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ProdutoBLL bll = new ProdutoBLL();
            bll.Delete(Convert.ToInt32(grvListaProdutos.CurrentRow.Cells[1].Value));
        }
    }
}
