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
    public partial class Categoria : Form
    {
        private string acao = "";
        public Categoria()
        {
            CAMADAS.BLL.CategoriaBLL categoriaBLL = new CAMADAS.BLL.CategoriaBLL();
            InitializeComponent();
            dgvCategoria.DataSource = "";
            dgvCategoria.DataSource = categoriaBLL.SelectAll();
            desabilitarBotoes(true);
            rbTodos.Checked = true;
            txtDescricao.Enabled = false;
            recarregarTabela();
            limparCampos();
        }

        private void recarregarTabela()
        {
            CAMADAS.BLL.CategoriaBLL catBll = new CAMADAS.BLL.CategoriaBLL();
            if(rbTodos.Checked)
            {
                dgvCategoria.DataSource = catBll.SelectAll();
            } else if(rbId.Checked)
            {
                dgvCategoria.DataSource = catBll.SelectById(Convert.ToInt32(txtPesquisar.Text));
            } else if(rbDescricao.Checked)
            {
                dgvCategoria.DataSource = catBll.SelectByCategoria(txtPesquisar.Text);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void desabilitarBotoes(bool status)
        {
            btnCadastrar.Enabled = status;
            btnDeletar.Enabled = status;
            btnEditar.Enabled = status;

            btnCancelar.Enabled = !status;
            btnSalvar.Enabled = !status;
        }

        private void limparCampos()
        {
            txtDescricao.Text = "";
            lblId.Text = "-1";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.acao = "cadastrar";
            txtDescricao.Enabled = true;
            desabilitarBotoes(false);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            this.acao = "deletar";
            txtDescricao.Enabled = false;
            desabilitarBotoes(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.acao = "editar";
            txtDescricao.Enabled = true;
            desabilitarBotoes(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Categoria categoria = new CAMADAS.MODEL.Categoria();
            categoria.id = Convert.ToInt32(lblId.Text);
            categoria.categoria = txtDescricao.Text;
            CAMADAS.BLL.CategoriaBLL catBll = new CAMADAS.BLL.CategoriaBLL();
            if (this.acao.Equals("cadastrar"))
            {
                catBll.Insert(categoria);
            }
            else if (this.acao.Equals("editar"))
            {
                catBll.Update(categoria);
            } else if (this.acao.Equals("deletar"))
            {
                catBll.Delete(categoria);
            }
            recarregarTabela();
            limparCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Enabled = false;
            lblId.Text = "-1";
            desabilitarBotoes(true);
        }

        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvCategoria.SelectedRows[0].Cells["id"].Value.ToString();
            txtDescricao.Text = dgvCategoria.SelectedRows[0].Cells["categoria"].Value.ToString();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if(txtPesquisar.Equals(""))
            {
                MessageBox.Show("Informe a pesquisa!");
            } else
            {
                recarregarTabela();
            }
        }
    }
}
