using Mercado_Thay_and_Lusca.CAMADAS.DAL;
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
            rbTodos.Checked = true;
            CAMADAS.BLL.ProdutoBLL bllProd = new CAMADAS.BLL.ProdutoBLL();
            CAMADAS.BLL.CategoriaBLL catBll = new CAMADAS.BLL.CategoriaBLL();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.SelectAll();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "id";
            cbCategoria.DataSource = catBll.SelectAll();
            txtPesquisar.Enabled = false;
            pesquisarBtn.Enabled = false;
            limparCampos();
            desabilitarBotoes(true);
            desabilitarCampos();
            cbCategoria.SelectedItem = null;
        }

        private string acao = "";
       
        private void recarregarTabela()
        {
            CAMADAS.BLL.ProdutoBLL bllProd = new CAMADAS.BLL.ProdutoBLL();
            if (rbTodos.Checked)
                dgvProdutos.DataSource = bllProd.SelectAll();
            else if (rbId.Checked)
                dgvProdutos.DataSource = bllProd.SelectById(Convert.ToInt32(txtPesquisar.Text));
            else if (rbProduto.Checked)
                    dgvProdutos.DataSource = bllProd.SelectByProduto(txtPesquisar.Text);
            else if (rbIdCategoria.Checked)
                    dgvProdutos.DataSource = bllProd.SelectByIdCategoria(Convert.ToInt32(txtPesquisar.Text));
        }
        private void limparCampos()
        {
            txtEstoque.Text = "0";
            txtPreco.Text = "0,00";
            txtProduto.Text = "";
            cbCategoria.SelectedItem = null;
            pbFotoProduto.Image = null;
            carregarImagemProduto = new OpenFileDialog();
            btnCarregarImagem.Text = "Selecione";
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

        private void desabilitarCampos()
        {
            txtEstoque.Enabled = false;
            txtPreco.Enabled = false;
            txtProduto.Enabled = false;
            btnCarregarImagem.Enabled = false;
            cbCategoria.Enabled = false;
            btnMinus.Enabled = false;
            btnPlus.Enabled = false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnMinus.Enabled = true;
            btnPlus.Enabled = true;
            lblTitulo.Text = "Cadastro de Produto";
            this.acao = "cadastrar";
            txtProduto.Focus();
            txtEstoque.Enabled = true;
            txtPreco.Enabled = true;
            txtProduto.Enabled = true;
            cbCategoria.Enabled = true;
            btnCarregarImagem.Enabled = true;
            desabilitarBotoes(false);
            limparCampos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            this.acao = "deletar";
            lblTitulo.Text = "Exclusão de Produto";
            desabilitarCampos();
            desabilitarBotoes(false);
            limparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.acao = "editar";
            lblTitulo.Text = "Edição de Produto";
            txtProduto.Enabled = true;
            txtPreco.Enabled = true;
            cbCategoria.Enabled = true;
            btnMinus.Enabled = true;
            btnPlus.Enabled = true;
            desabilitarBotoes(false);
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
            CAMADAS.BLL.ProdutoBLL bllProd = new CAMADAS.BLL.ProdutoBLL();

            produto.id = Convert.ToInt32(lblId.Text);
            produto.produto = txtProduto.Text;
            produto.preco = Convert.ToSingle(txtPreco.Text);
            produto.quantidadeEstoque = Convert.ToInt32(txtEstoque.Text);
            produto.idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            if (this.acao.Equals("cadastrar"))
            {
                if (pbFotoProduto.Image != null)
                {
                    string[] partes = carregarImagemProduto.SafeFileName.Split('.');
                    produto.imagem = produto.produto + "." + partes[partes.Length - 1];
                    bllProd.Insert(produto, pbFotoProduto.Image);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Escolha uma imagem!");
                }
            } else if(this.acao.Equals("editar"))
            {
                bllProd.Update(produto);
                limparCampos();
            } else if(this.acao.Equals("deletar")) {
                bllProd.Delete(produto.id);
                limparCampos();
            }

            recarregarTabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarBotoes(true);
            desabilitarCampos();
        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text.Equals(""))
                MessageBox.Show("Informe a pesquisa!");
            else
                recarregarTabela();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            carregarImagemProduto.Filter = "Image Files(*.jpg; *.jpeg; " +
               "*.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (carregarImagemProduto.ShowDialog() != DialogResult.Cancel)
            {
                pbFotoProduto.Image = new Bitmap(carregarImagemProduto.FileName);
                btnCarregarImagem.Text = carregarImagemProduto.SafeFileName;
            }
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
            txtProduto.Text = dgvProdutos.SelectedRows[0].Cells["produto"].Value.ToString();
            txtPreco.Text = dgvProdutos.SelectedRows[0].Cells["preco"].Value.ToString();
            txtEstoque.Text = dgvProdutos.SelectedRows[0].Cells["quantidadeEstoque"].Value.ToString();
            cbCategoria.SelectedValue = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["idCategoria"].Value.ToString());
            btnCarregarImagem.Text = dgvProdutos.SelectedRows[0].Cells["imagem"].Value.ToString();
            Bitmap imagem = new Bitmap(Conexao.getPathImagens() + @"Produtos/" + dgvProdutos.SelectedRows[0].Cells["imagem"].Value.ToString());
            pbFotoProduto.Image = imagem;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            pesquisarBtn.Enabled = true;
            dgvProdutos.DataSource = "";
            txtPesquisar.Enabled = true;
            txtPesquisar.Focus();
            lblInsira.Text = "Insira o ID:";
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEstoque.Text) > 0)
            {
                txtEstoque.Text = (Convert.ToInt32(txtEstoque.Text) - 1).ToString();
            }
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEstoque.Text) < 9999)
            {
                txtEstoque.Text = (Convert.ToInt32(txtEstoque.Text) + 1).ToString();
            }
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            pesquisarBtn.Enabled = true;
            dgvProdutos.DataSource = "";
            txtPesquisar.Enabled = true;
            txtPesquisar.Focus();
            lblInsira.Text = "Insira o Produto:";
        }

        private void rbIdCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            pesquisarBtn.Enabled = true;
            dgvProdutos.DataSource = "";
            txtPesquisar.Enabled = true;
            txtPesquisar.Focus();
            lblInsira.Text = "Insira o ID-Categoria:";
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            CAMADAS.BLL.ProdutoBLL bllProd = new CAMADAS.BLL.ProdutoBLL();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.SelectAll();
            txtPesquisar.Text = "";
            pesquisarBtn.Enabled = false;
            txtPesquisar.Enabled = false;
            txtPesquisar.Focus();
            lblInsira.Text = "";
        }
    }
}
