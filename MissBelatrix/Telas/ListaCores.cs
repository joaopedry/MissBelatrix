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
    public partial class ListaCores : Form
    {
        public ListaCores()
        {
            InitializeComponent();
        }

        private void ListaCores_Load(object sender, EventArgs e)
        {
            CarregaListaCores();
        }

        public void CarregaListaCores()
        {
            CorBLL bll = new CorBLL();
            grvListaCores.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCor cadastroCor = new CadastroCor(this);
            cadastroCor.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditarCor();
        }

        private void EditarCor()
        {
            CadastroCor cadastroCor = new CadastroCor(Convert.ToInt32(grvListaCores.CurrentRow.Cells[1].Value), this);
            cadastroCor.Show();
        }

        private void grvListaCores_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in grvListaCores.Rows)
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
            ExcluirCor();
        }

        private void ExcluirCor()
        {
            CorBLL bll = new CorBLL();
            bll.Delete(Convert.ToInt32(grvListaCores.CurrentRow.Cells[1].Value));
            CarregaListaCores();
        }
    }
}
