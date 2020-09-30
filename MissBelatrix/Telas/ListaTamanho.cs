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

        private void CarregaListaTamanhos()
        {
            TamanhoBLL bll = new TamanhoBLL();
            grvListaTamanhos.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroTamanho cadastroTamanho = new CadastroTamanho();
            cadastroTamanho.Show();
        }

        private void grvListaTamanhos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grvListaTamanhos.Rows[e.RowIndex].Cells[0].Value = true;
            

            grvListaTamanhos.RefreshEdit();
        }
    }
}
