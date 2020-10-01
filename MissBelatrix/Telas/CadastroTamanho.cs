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
    public partial class CadastroTamanho : Form
    {
        private readonly ListaTamanho _ListaTamanhos;
        int _CdTamanho;

        public CadastroTamanho(ListaTamanho pListaTamanhos)
        {
            InitializeComponent();
            _ListaTamanhos = pListaTamanhos;
            btnCadastrar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnCadastrar.Visible = true;
            btnAtualizar.Visible = false;
        }

        public CadastroTamanho(int pCdTamanho, ListaTamanho pListaTamanhos)
        {
            InitializeComponent();
            _ListaTamanhos = pListaTamanhos;
            _CdTamanho = pCdTamanho;
            btnCadastrar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnCadastrar.Visible = false;
            btnAtualizar.Visible = true;
            CarregaTamanho(pCdTamanho);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTamanho();
            AtualizaGridTamanho();
        }

        private void CadastraNovoTamanho()
        {
            TamanhoBLL bll = new TamanhoBLL();
            TamanhoInfo info = new TamanhoInfo();

            info.DsTamanho = txtDsTamanho.Text;
            bll.Inserir(info);
        }

        private void CarregaTamanho(int pCdTamanho)
        {
            TamanhoBLL bll = new TamanhoBLL();
            TamanhoInfo info = bll.Get(pCdTamanho);

            txtDsTamanho.Text = info.DsTamanho;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTamanho();
            AtualizaGridTamanho();
        }

        private void AtualizarTamanho()
        {
            TamanhoBLL bll = new TamanhoBLL();
            TamanhoInfo info = new TamanhoInfo();

            info.CdTamanho = _CdTamanho;
            info.DsTamanho = txtDsTamanho.Text;

            bll.Update(info);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizaGridTamanho()
        {
            _ListaTamanhos.CarregaListaTamanhos();
        }
    }
}
