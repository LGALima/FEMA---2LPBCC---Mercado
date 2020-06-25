using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado_Thay_and_Lusca.View
{
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            desabilitarBotoes(true);
        }
        private string acao = "";
        private void limparCampos()
        {
            txtEstoque.Text = "0";
            txtPreco.Text = "0.00";
            txtProduto.Text = "";
            cbCategoria.SelectedItem = null;
            lblId.Text = "-1";
        }
        private void desabilitarBotoes(bool status)
        {
            btnCadastrar.Enabled = status;
            btnDeletar.Enabled = status;
            btnEditar.Enabled = status;

            btnCancelar.Enabled = !status;
            btnSalvar.Enabled = !status;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {

        }

        private void Produto_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.CategoriaBLL catBll = new CAMADAS.BLL.CategoriaBLL();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "id";
            cbCategoria.DataSource = catBll.SelectAll();
        }
    }
}
