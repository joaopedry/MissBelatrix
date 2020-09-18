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

        private void CarregaListaCores()
        {
            //ClienteBLL bll = new ClienteBLL();
            //grvListaCores.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //CadastroCliente cadastroCliente = new CadastroCliente();
            //cadastroCliente.Show();
        }
    }
}
