using LiteDB;
using MissBelatrix.Camadas.BLL;
using MissBelatrix.Camadas.Info;
using MissBelatrix.Connection;
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
    public partial class ListaTipoAcesso : Form
    {
        

        public ListaTipoAcesso()
        {
            InitializeComponent();
        }

        private void ListaTipoAcesso_Load(object sender, EventArgs e)
        {
            CarregaListaTipoAcesso();
        }

        public void CarregaListaTipoAcesso()
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            grvListaTipoAcesso.DataSource = bll.Listar();
        }

        private void CadastraNovoTipoAcesso()
        {
            CadastroTipoAcesso tipoAcesso = new CadastroTipoAcesso(this);
            tipoAcesso.Show();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTipoAcesso();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            CadastroTipoAcesso cadastroTipoAcesso = new CadastroTipoAcesso(Convert.ToInt32(grvListaTipoAcesso.CurrentRow.Cells[1].Value), this);
            cadastroTipoAcesso.Show();
        }

        private void grvListaTipoAcesso_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in grvListaTipoAcesso.Rows)
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
            ExcluirTipoAcesso();
        }

        private void ExcluirTipoAcesso()
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            bll.Delete(Convert.ToInt32(grvListaTipoAcesso.CurrentRow.Cells[1].Value));
            CarregaListaTipoAcesso();
        }
    }
}
