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
        private readonly ListaTipoAcesso _ListaTipoAcesso;
        int _CdTipoAcesso;

        public CadastroTipoAcesso(ListaTipoAcesso pListaTipoAcesso)
        {
            InitializeComponent();
            _ListaTipoAcesso = pListaTipoAcesso;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        public CadastroTipoAcesso(int pCdTipoAcesso, ListaTipoAcesso pListaTipoAcesso)
        {
            InitializeComponent();
            _ListaTipoAcesso = pListaTipoAcesso;
            _CdTipoAcesso = pCdTipoAcesso;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            CarregaTipoAcesso(pCdTipoAcesso);
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
            AtualizaGridTipoAcesso();
        }

        private void CarregaTipoAcesso(int pCdTipoAcesso)
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            TipoAcessoInfo info = bll.Get(pCdTipoAcesso);

            txtDsTipoAcesso.Text = info.DsTipoAcesso;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTipoAcesso();
            AtualizaGridTipoAcesso();
        }
        private void AtualizarTipoAcesso()
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            TipoAcessoInfo info = new TipoAcessoInfo();

            info.CdTipoAcesso = _CdTipoAcesso;
            info.DsTipoAcesso = txtDsTipoAcesso.Text;

            bll.Update(info);
            this.Close();
        }

        private void AtualizaGridTipoAcesso()
        {
            _ListaTipoAcesso.CarregaListaTipoAcesso();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
