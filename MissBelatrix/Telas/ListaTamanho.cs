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
    public partial class ListaTamanho : Form
    {
        public ListaTamanho()
        {
            InitializeComponent();
        }

        private void ListaTamanho_Load(object sender, EventArgs e)
        {
            CarregaListaTamanhos();
        }

        public void CarregaListaTamanhos()
        {
            TamanhoBLL bll = new TamanhoBLL();
            grvListaTamanhos.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroTamanho cadastroTamanho = new CadastroTamanho(this);
            cadastroTamanho.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            CadastroTamanho cadastroTamanho = new CadastroTamanho(Convert.ToInt32(grvListaTamanhos.CurrentRow.Cells[1].Value), this);
            cadastroTamanho.Show();
        }

        private void grvListaTamanhos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in grvListaTamanhos.Rows)
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
            ExcluirTamanho();
        }

        private void ExcluirTamanho()
        {
            TamanhoBLL bll = new TamanhoBLL();
            bll.Delete(Convert.ToInt32(grvListaTamanhos.CurrentRow.Cells[1].Value));
            CarregaListaTamanhos();
        }
    }
}
