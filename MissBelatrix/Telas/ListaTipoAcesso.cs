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

        private void CarregaListaTipoAcesso()
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            grvTipoAcesso.DataSource = bll.Listar();
        }

        private void CadastraNovoTipoAcesso()
        {
            CadastroTipoAcesso tipoAcesso = new CadastroTipoAcesso();
            tipoAcesso.Show();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTipoAcesso();
        }
    }
}
