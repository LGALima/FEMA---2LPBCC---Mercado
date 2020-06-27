using Mercado_Thay_and_Lusca.CAMADAS.DAL;
using Mercado_Thay_and_Lusca.CAMADAS.MODEL;
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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
            
        }

        private CAMADAS.MODEL.Cliente clienteSalvo = null;
        private void Compra_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.CategoriaBLL bllCat = new CAMADAS.BLL.CategoriaBLL();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "id";
            cbCategoria.DataSource = bllCat.SelectAll();
            dgvCarrinho.DataSource = new List<CAMADAS.MODEL.Carrinho>();
            rbTodos.Checked = true;
            zerarProduto();
            habilitarCliente(false);
            txtSenha.UseSystemPasswordChar = true;
            recarregarTabelaProduto();
        }

        private void recarregarTabelaProduto()
        {
            CAMADAS.BLL.ProdutoBLL bllProd = new CAMADAS.BLL.ProdutoBLL();
            if(rbTodos.Checked)
            {
                dgvProdutos.DataSource = bllProd.SelectAll();
            } else if(rbCategoria.Checked)
            {
                dgvProdutos.DataSource = bllProd.SelectByIdCategoria(Convert.ToInt32(cbCategoria.SelectedValue.ToString()));
            } else if(rbProduto.Checked)
            {
                dgvProdutos.DataSource = bllProd.SelectByProduto(txtPesquisarProduto.Text);
            }
        }
        private void recarregarTabelaCarrinho()
        {
            if(clienteSalvo != null)
            {
                CAMADAS.BLL.CompraBLL bllCompra = new CAMADAS.BLL.CompraBLL();
                dgvCarrinho.DataSource = bllCompra.SelectCarrinhoByCliente(this.clienteSalvo.id);
            } else
            {
                MessageBox.Show("Erro, logue novamente");
            }
        }

        private void recarregarTabelaComprasRealizadas()
        {
            if (clienteSalvo != null)
            {
                CAMADAS.BLL.CompraBLL bllCompra = new CAMADAS.BLL.CompraBLL();
                dgvComprasRealizadas.DataSource = bllCompra.SelectRegistroCompraByIdCliente(this.clienteSalvo.id);
            }
            else
            {
                MessageBox.Show("Erro, logue novamente");
            }
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisarProduto.Text = "";
            txtPesquisarProduto.Enabled = true;
            txtPesquisarProduto.Visible = true;
            cbCategoria.Visible = false;
            cbCategoria.Enabled = false;
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.SelectedItem = null;
            txtPesquisarProduto.Enabled = false;
            txtPesquisarProduto.Visible = false;
            cbCategoria.Visible = true;
            cbCategoria.Enabled = true;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.SelectedItem = null;
            txtPesquisarProduto.Text = "";
            cbCategoria.Enabled = false;
            txtPesquisarProduto.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            recarregarTabelaProduto();
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            CAMADAS.BLL.CategoriaBLL bllCat = new CAMADAS.BLL.CategoriaBLL();

            lblIdProduto.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
            txtProdutoProduto.Text = dgvProdutos.SelectedRows[0].Cells["produto"].Value.ToString();
            txtPrecoProduto.Text = dgvProdutos.SelectedRows[0].Cells["preco"].Value.ToString();
            txtEstoqueProduto.Text = dgvProdutos.SelectedRows[0].Cells["quantidadeEstoque"].Value.ToString();
            txtCategoriaProduto.Text = bllCat.SelectById(Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["idCategoria"].Value.ToString()))[0].categoria;
            Bitmap imagem = new Bitmap(Conexao.getPathImagens() + @"Produtos/" + dgvProdutos.SelectedRows[0].Cells["imagem"].Value.ToString());
            pbFotoProduto.Image = imagem;
        }

        public void habilitarCliente(bool status)
        {
            gbLoginPerfil.Text = status ? "Perfil" : "Login";
            lblUsuario.Visible = !status;
            lblSenhaCliente.Visible = !status;
            txtSenha.Visible = !status;
            txtUsuario.Visible = !status;
            btnLogar.Visible = !status;
            btnVerSenha.Visible = !status;

            lblEnderecoUsuario.Visible = status;
            lblNomeCliente.Visible = status;
            lblSaldoUsuario.Visible = status;
            txtNomeCliente.Visible = status;
            txtSaldoCliente.Visible = status;
            txtEnderecoCliente.Visible = status;
            btnSairCliente.Visible = status;
            pbFotoCliente.Visible = status;
            
            lblIdCompraRealizada.Visible = status;
            lblDiaCompraRealizada.Visible = status;
            lblValorPagoCompraRealizada.Visible = status;
            lblIdTextCompraRealizada.Visible = status;
            txtPagoCompraRealizada.Visible = status;
            txtDiaCompraRealizada.Visible = status;
            lblComprasRealizadas.Visible = status;
            dgvComprasRealizadas.Visible = status;
            btnGerarRelatorioCompraRealizada.Visible = status; ;

            btnPesquisar.Enabled = status;
            txtQuantidadeProduto.Enabled = status;
            rbCategoria.Enabled = status;
            rbProduto.Enabled = status;
            rbTodos.Enabled = status;
            txtPesquisarProduto.Enabled = status;
            dgvProdutos.Enabled = status;
            dgvCarrinho.Enabled = status;
            btnAdicionarCarrinho.Enabled = status;
            btnCancelarCarrinho.Enabled = status;
            btnCancelarCompra.Enabled = status;
            btnFinalizarCompra.Enabled = status;
        }

        private void zerarProduto()
        {
            lblIdProduto.Text = "-1";
            txtCategoriaProduto.Text = "";
            txtProdutoProduto.Text = "";
            txtQuantidadeProduto.Text = "0";
            txtTotal.Text = "0,00";
            txtPrecoProduto.Text = "0,00";
            txtEstoqueProduto.Text = "0";
            pbFotoProduto.Image = null;
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.ClienteBLL bllCli = new CAMADAS.BLL.ClienteBLL();
            List<CAMADAS.MODEL.Cliente> clienteRecuperado = bllCli.SelectByUsuarioAndSenha(txtUsuario.Text, txtSenha.Text);
            if(clienteRecuperado == null)
            {
            } else if(clienteRecuperado.Count > 0)
            {
                this.clienteSalvo = clienteRecuperado[0];
                this.setarClienteNovoVisual();
                recarregarTabelaCarrinho();
                recarregarTabelaComprasRealizadas();
                habilitarCliente(true);
            } else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void setarClienteNovoVisual()
        {
            txtNomeCliente.Text = this.clienteSalvo.nome;
            txtSaldoCliente.Text = Math.Round(this.clienteSalvo.saldo, 2).ToString();
            txtEnderecoCliente.Text = this.clienteSalvo.endereco;
            pbFotoCliente.Image = new Bitmap(Conexao.getPathImagens() + @"Clientes/" + this.clienteSalvo.imagem);

            txtDiaCompraRealizada.Text = "";
            txtPagoCompraRealizada.Text = "";
            lblIdCompraRealizada.Text = "";
        }

        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            this.clienteSalvo = null;
            pbFotoCliente.Image = null;
            pbFotoProduto.Image = null;
            txtUsuario.Text = "";
            txtSenha.Text = "";
            dgvCarrinho.DataSource = new List<CAMADAS.MODEL.Carrinho>();
            zerarProduto();
            habilitarCliente(false);
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            if(btnVerSenha.Text.Equals("--"))
            {
                btnVerSenha.Text = "O";
                txtSenha.UseSystemPasswordChar = false;
            } else
            {
                btnVerSenha.Text = "--";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Carrinho carrinho = new CAMADAS.MODEL.Carrinho();
            
            carrinho.idCliente = clienteSalvo.id;
            carrinho.idProduto = Convert.ToInt32(lblIdProduto.Text);
            if (txtQuantidadeProduto.Text.Equals("") || txtQuantidadeProduto.Text.Equals("0"))
            {
                MessageBox.Show("Quantidade inválida");
                return;
            }
            carrinho.quantidade = Convert.ToInt32(txtQuantidadeProduto.Text);
            carrinho.total = Convert.ToSingle(txtPrecoProduto.Text) * carrinho.quantidade;
            if(!lblIdProduto.Text.Equals("-1"))
            {
                CAMADAS.BLL.CompraBLL bllCompra = new CAMADAS.BLL.CompraBLL();
                CAMADAS.BLL.ClienteBLL bllCli = new CAMADAS.BLL.ClienteBLL();
                bllCompra.adicionarAoCarrinho(carrinho);
                clienteSalvo = bllCli.SelectById(clienteSalvo.id)[0];
                zerarProduto();
                setarClienteNovoVisual();
                recarregarTabelaCarrinho();
                recarregarTabelaProduto();
            } else
            {
                MessageBox.Show("Selecione um produto");
            }

        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.CompraBLL bllComp = new CAMADAS.BLL.CompraBLL();
            bllComp.finalizarCompra(this.clienteSalvo.id);
            recarregarTabelaCarrinho();
            recarregarTabelaProduto();
            recarregarTabelaComprasRealizadas();
            zerarProduto();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.CompraBLL bllComp = new CAMADAS.BLL.CompraBLL();
            CAMADAS.BLL.ClienteBLL bllCli = new CAMADAS.BLL.ClienteBLL();
            bllComp.deletarCarrinhoCliente(this.clienteSalvo.id);
            recarregarTabelaCarrinho();
            recarregarTabelaProduto();
            zerarProduto();
            this.clienteSalvo = bllCli.SelectById(this.clienteSalvo.id)[0];
            setarClienteNovoVisual();
        }

        private void dgvComprasRealizadas_DoubleClick(object sender, EventArgs e)
        {
            lblIdCompraRealizada.Text = dgvComprasRealizadas.SelectedRows[0].Cells["id"].Value.ToString();
            txtDiaCompraRealizada.Text = dgvComprasRealizadas.SelectedRows[0].Cells["data"].Value.ToString();
            txtPagoCompraRealizada.Text = dgvComprasRealizadas.SelectedRows[0].Cells["totalPago"].Value.ToString();
        }

        private void txtQuantidadeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(!txtQuantidadeProduto.Text.Equals(""))
                {
                    txtTotal.Text = "" + (float)(Convert.ToInt32(txtQuantidadeProduto.Text) * Convert.ToSingle(txtPrecoProduto.Text));
                } else
                {
                    txtTotal.Text = "0.00";
                }
            }
            catch
            {
                MessageBox.Show("Insira um valor válido para quantidade");
            }
        }

        private void btnGerarRelatorioCompraRealizada_Click(object sender, EventArgs e)
        {
            if(!lblIdCompraRealizada.Text.Equals(""))
            {

            } else
            {
                MessageBox.Show("Selecione uma compra realizada!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
