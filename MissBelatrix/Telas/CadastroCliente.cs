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
    public partial class CadastroCliente : Form
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoCliente();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            CarregaTiposAcesso();
        }

        private void CadastraNovoCliente()
        {
            ClienteBLL bll = new ClienteBLL();
            ClienteInfo info = new ClienteInfo();

            info.DsCliente = txtDsCliente.Text;
            info.DsEmail = txtDsEmail.Text;
            info.DsFone = txtDsFone.Text;
            info.IdGenero = (rbIdGeneroFeninimo.Checked == true) ? 0 : 1;
            info.CdTipoAcesso = ((TipoAcessoInfo)cbCdTipoAcesso.SelectedItem).CdTipoAcesso;

            bll.Inserir(info);
        }

        private void CarregaTiposAcesso()
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            cbCdTipoAcesso.DataSource = bll.Listar();
            cbCdTipoAcesso.DisplayMember = "DsTipoAcesso";
            cbCdTipoAcesso.ValueMember = "CdTipoAcesso";
        }

        private void btnAdicionaTipoAcesso_Click(object sender, EventArgs e)
        {
            CadastroTipoAcesso tipoAcesso = new CadastroTipoAcesso();
            tipoAcesso.Show();
        }
    }
}
