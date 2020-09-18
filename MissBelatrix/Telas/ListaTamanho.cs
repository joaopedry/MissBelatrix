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
            //ClienteBLL bll = new ClienteBLL();
            //grvListaTamanhos.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //CadastroCliente cadastroCliente = new CadastroCliente();
            //cadastroCliente.Show();
        }
    }
}
