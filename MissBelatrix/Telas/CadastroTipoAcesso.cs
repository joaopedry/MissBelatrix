using MissBelatrix.Camadas.BLL;
using MissBelatrix.Camadas.Info;
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
    public partial class CadastroTipoAcesso : Form
    {
        public CadastroTipoAcesso()
        {
            InitializeComponent();
        }

        private void CadastraNovoTipoAcesso()
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            TipoAcessoInfo info = new TipoAcessoInfo();

            info.DsTipoAcesso = txtDsTipoAcesso.Text;
            bll.Inserir(info);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTipoAcesso();
        }
    }
}
