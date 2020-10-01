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
        private readonly ListaClientes _ListaClientes;
        int _CdCliente;

        public CadastroCliente(ListaClientes pListaClientes)
        {
            InitializeComponent();
            _ListaClientes = pListaClientes;
            CarregaTiposAcesso();
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        public CadastroCliente(int pCdCliente, ListaClientes pListaClientes)
        {
            InitializeComponent();
            _ListaClientes = pListaClientes;
            _CdCliente = pCdCliente;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            CarregaCliente(pCdCliente);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoCliente();
            AtualizaGridClientes();
        }

        private void CarregaCliente(int pCdCliente)
        {
            ClienteBLL bll = new ClienteBLL();
            ClienteInfo info = bll.Get(pCdCliente);

            txtDsCliente.Text = info.DsCliente;
            txtDsEmail.Text = info.DsEmail;
            txtDsFone.Text = info.DsFone;
            CarregaTiposAcesso(info.CdTipoAcesso);
            rbIdGeneroFeminimo.Checked = (info.IdGenero == 0) ? true : false;
            rbIdGeneroMasculino.Checked = (info.IdGenero == 1) ? true : false;
        }

        private void CadastraNovoCliente()
        {
            ClienteBLL bll = new ClienteBLL();
            ClienteInfo info = new ClienteInfo();

            info.DsCliente = txtDsCliente.Text;
            info.DsEmail = txtDsEmail.Text;
            info.DsFone = txtDsFone.Text;
            info.IdGenero = (rbIdGeneroFeminimo.Checked == true) ? 0 : 1;
            info.CdTipoAcesso = ((TipoAcessoInfo)cbCdTipoAcesso.SelectedItem).CdTipoAcesso;

            bll.Inserir(info);
            LimparCampos();
        }

        private void CarregaTiposAcesso(int pCdTipoAcesso = 0)
        {
            TipoAcessoBLL bll = new TipoAcessoBLL();
            TipoAcessoInfo info = new TipoAcessoInfo();
            cbCdTipoAcesso.DataSource = bll.Listar();
            cbCdTipoAcesso.DisplayMember = "DsTipoAcesso";
            cbCdTipoAcesso.ValueMember = "CdTipoAcesso";
            cbCdTipoAcesso.SelectedValue = pCdTipoAcesso as object;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarCliente();
            AtualizaGridClientes();
        }

        private void AtualizarCliente()
        {
            ClienteBLL bll = new ClienteBLL();
            ClienteInfo info = new ClienteInfo();

            info.CdCliente = _CdCliente;
            info.DsCliente = txtDsCliente.Text;
            info.DsEmail = txtDsEmail.Text;
            info.DsFone = txtDsFone.Text;
            info.IdGenero = (rbIdGeneroFeminimo.Checked == true) ? 0 : 1;
            info.CdTipoAcesso = ((TipoAcessoInfo)cbCdTipoAcesso.SelectedItem).CdTipoAcesso;

            bll.Update(info);
            this.Close();
        }

        private void LimparCampos()
        {
            txtDsCliente.Text = string.Empty;
            txtDsEmail.Text = string.Empty;
            txtDsFone.Text = string.Empty;
            rbIdGeneroFeminimo.Checked = true;
            rbIdGeneroMasculino.Checked = false;
            CarregaTiposAcesso();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizaGridClientes()
        {
            _ListaClientes.CarregaListaClientes();
        }
    }
}
