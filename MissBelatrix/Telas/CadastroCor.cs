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
    public partial class CadastroCor : Form
    {
        private readonly ListaCores _ListaCores;
        int _CdCor;

        public CadastroCor(ListaCores pListaCores)
        {
            InitializeComponent();
            _ListaCores = pListaCores;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        public CadastroCor(int pCdCor, ListaCores pListaCores)
        {
            InitializeComponent();
            _CdCor = pCdCor;
            _ListaCores = pListaCores;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            CarregaCor(pCdCor);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovaCor();
            AtualizaGridCor();
        }

        private void CadastraNovaCor()
        {
            CorBLL bll = new CorBLL();
            CorInfo info = new CorInfo();

            info.DsCor = txtDsCor.Text;
            bll.Inserir(info);
            LimparCampos();
        }

        private void CarregaCor(int CdCor)
        {
            CorBLL bll = new CorBLL();
            CorInfo info = bll.Get(CdCor);
            txtDsCor.Text = info.DsCor;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void AtualizarCor()
        {
            CorBLL bll = new CorBLL();
            CorInfo info = new CorInfo();

            info.CdCor = _CdCor;
            info.DsCor = txtDsCor.Text;

            bll.Update(info);
            AtualizaGridCor();
            this.Close();
        }

        private void LimparCampos()
        {
            txtDsCor.Text = string.Empty;
        }

        private void AtualizaGridCor()
        {
            _ListaCores.CarregaListaCores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
