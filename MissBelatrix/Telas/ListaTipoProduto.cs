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

        private void CarregaListaTipoProdutos()
        {
            //ClienteBLL bll = new ClienteBLL();
            //grvListaTipoProdutos.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //CadastroCliente cadastroCliente = new CadastroCliente();
            //cadastroCliente.Show();
        }
    }
}
