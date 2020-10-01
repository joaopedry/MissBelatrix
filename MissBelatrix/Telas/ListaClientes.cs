using LiteDB;
using MissBelatrix.Camadas.BLL;
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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            CarregaListaClientes();
        }

        public void CarregaListaClientes()
        {
            ClienteBLL bll = new ClienteBLL();
            grvListaClientes.DataSource = bll.Listar();
            grvListaClientes.Update();
            grvListaClientes.Refresh();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente(this);
            cadastroCliente.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente(Convert.ToInt32(grvListaClientes.CurrentRow.Cells[1].Value), this);
            cadastroCliente.Show();
        }

        private void grvListaClientes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in grvListaClientes.Rows)
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
            ClienteBLL bll = new ClienteBLL();
            bll.Delete(Convert.ToInt32(grvListaClientes.CurrentRow.Cells[1].Value));
            CarregaListaClientes();
        }
    }
}
