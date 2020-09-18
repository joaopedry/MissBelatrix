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
        DataBaseConnect dataBase = new DataBaseConnect();
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            CarregaListaClientes();
        }

        private void CarregaListaClientes()
        {
            ClienteBLL bll = new ClienteBLL();
            grvListaClientes.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }
    }
}
