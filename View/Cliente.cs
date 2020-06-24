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

namespace Mercado_Thay_and_Lusca
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            recarregarTabela();
            limparCampos();
            desabilitarBotoes(true);
            rbTodos.Checked = true;
        }

        private string acao = "nada";

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void carregarImagemBtn_Click(object sender, EventArgs e)
        {
            carregarImagemCliente.Filter = "Image Files(*.jpg; *.jpeg; "+
                "*.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (carregarImagemCliente.ShowDialog() != DialogResult.Cancel)
            {
                pbFotoCliente.Image = new Bitmap(carregarImagemCliente.FileName);
                btnCarregarImagem.Text = carregarImagemCliente.SafeFileName;
            }
        }
        public void limparCampos()
        {
            lblId.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtSaldo.Text = "0";
            btnCarregarImagem.Text = "Selecione";
            pbFotoCliente.Image = null;
            carregarImagemCliente = new OpenFileDialog();
        }
        public void desabilitarCamposInfo()
        {
            
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtSaldo.Enabled = false;
            txtSenha.Enabled = false;
            txtUsuario.Enabled = false;
            btnCarregarImagem.Enabled = false;
        }

        private void recarregarTabela()
        {
            CAMADAS.BLL.ClienteBLL cliBLL = new CAMADAS.BLL.ClienteBLL();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = cliBLL.SelectAll();
        }

        private void fotoClientePb_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void clientesDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
            txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtSaldo.Text = dgvClientes.SelectedRows[0].Cells["saldo"].Value.ToString();
            txtSenha.Text = dgvClientes.SelectedRows[0].Cells["senha"].Value.ToString();
            txtUsuario.Text = dgvClientes.SelectedRows[0].Cells["usuario"].Value.ToString();
            btnCarregarImagem.Text = dgvClientes.SelectedRows[0].Cells["imagem"].Value.ToString();
            Bitmap imagem = new Bitmap(Conexao.getPathImagens() + @"Clientes/" + dgvClientes.SelectedRows[0].Cells["imagem"].Value.ToString());
            pbFotoCliente.Image = imagem;
        }


        private void desabilitarBotoes(bool status)
        {
            btnCadastrar.Enabled = status;
            btnDeletar.Enabled = status;
            btnEditar.Enabled = status;

            btnCancelar.Enabled = !status;
            btnSalvar.Enabled = !status;
            dgvClientes.Enabled = !status;
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Exclusão de Cliente";
            this.acao = "deletar";
            desabilitarBotoes(false);
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            this.acao = "cadastro";
            lblTitulo.Text = "Cadastro de Cliente";
            desabilitarBotoes(false);
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtSaldo.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Enabled = true;
            btnCarregarImagem.Enabled = true;
            dgvClientes.Enabled = false;
            lblId.Text = "-1";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Editar de Cliente";
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtSaldo.Enabled = true;
            txtSenha.Enabled = true;
            desabilitarBotoes(false);
            this.acao = "editar";
            lblId.Text = "-1";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.id = lblId.Text != "" ? Convert.ToInt32(lblId.Text) : -1;
            cliente.usuario = txtUsuario.Text;
            cliente.senha = txtSenha.Text;
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.saldo = Math.Round(Convert.ToDouble(txtSaldo.Text), 2);
            cliente.imagem = btnCarregarImagem.Text;
            CAMADAS.BLL.ClienteBLL cliBLL = new CAMADAS.BLL.ClienteBLL();

            if(this.acao == "cadastro")
            {
                if (pbFotoCliente.Image != null)
                {
                    string[] partes = carregarImagemCliente.SafeFileName.Split('.');
                    cliente.imagem = cliente.usuario + "." + partes[partes.Length - 1];
                    cliBLL.Insert(cliente, pbFotoCliente.Image);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Escolha uma imagem!");
                }
            } else if (this.acao == "editar")
            {
                if(lblId.Text != "")
                {
                    cliBLL.Update(cliente, pbFotoCliente.Image);
                    limparCampos();
                } else
                {
                    MessageBox.Show("Selecione um Cliente!");
                }
            }
            else if (this.acao == "deletar")
            {
                if(lblId.Text != "")
                {
                    cliente.id = Convert.ToInt32(lblId.Text);
                    cliBLL.DeleteByCliente(cliente);
                    limparCampos();
                } else
                {
                    MessageBox.Show("Selecione um Cliente!");
                }
            }
            recarregarTabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gerenciar Cliente";
            limparCampos();
            desabilitarCamposInfo();
            desabilitarBotoes(true);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.ClienteBLL cliBLL = new CAMADAS.BLL.ClienteBLL();
            if(txtPesquisar.Text.Equals(""))
            {
                MessageBox.Show("Informe a pesquisa!");
            } else
            {
                if(rbId.Checked)
                {
                    dgvClientes.DataSource = cliBLL.SelectById(Convert.ToInt32(txtPesquisar.Text));
                } else if(rbNome.Checked)
                {
                    dgvClientes.DataSource = cliBLL.SelectByUsuario(txtPesquisar.Text);
                } else
                {
                    dgvClientes.DataSource = cliBLL.SelectAll();
                }
            }
        }
    }
}
