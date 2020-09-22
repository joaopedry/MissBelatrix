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

        private void CarregaListaCores()
        {
            CorBLL bll = new CorBLL();
            grvListaCores.DataSource = bll.Listar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCor cadastroCor = new CadastroCor();
            cadastroCor.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditarCor();
        }

        private void EditarCor()
        {
            //CadastroCor cadastroCor = new CadastroCor();
            //cadastroCor.Show();
        }
    }
}
