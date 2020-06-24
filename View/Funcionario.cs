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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            CAMADAS.BLL.FuncionarioBLL bllFunc = new CAMADAS.BLL.FuncionarioBLL();
            dtgFuncionario.DataSource = "";
            dtgFuncionario.DataSource =  bllFunc.Select();
            txtPesquisar.Enabled = false;
            limpaCampos();
            habilitaControles(false);
            habilitaButtons(true);
            lblID.Visible = false;
            lblID.Text = "";
        }

        private void imagemFuncionarioBtn_Click(object sender, EventArgs e)
        {
            imagemFuncionario.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(imagemFuncionario.ShowDialog()!=DialogResult.Cancel)
            {
                imagemFuncionarioPb.Image = new Bitmap(imagemFuncionario.FileName);
                imagemFuncionarioBtn.Text = imagemFuncionario.SafeFileName;
            }
        }
        private void habilitaControles(bool status)
        {
            txtUser.Enabled = status;
            txtSenha.Enabled = status;
            txtNome.Enabled = status;
            imagemFuncionarioBtn.Enabled = status;
            rdbAdmS.Enabled = status;
            rdbAdmN.Enabled = status;
        }
        private void habilitaButtons(bool status)
        {
            btnCadastrar.Enabled = status;
            btnEditar.Enabled = status;
            btnDelete.Enabled = status;
            btnCancelar.Enabled = !status;
            btnSalvar.Enabled = !status;
        }
        private void limpaCampos()
        {
            txtUser.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            lblID.Text = "";
            rdbAdmN.Checked = true;
            imagemFuncionarioPb.Image = null;
            imagemFuncionarioBtn.Text = "Selecione";
            imagemFuncionario = new OpenFileDialog();
        }
        
        private void dtgFuncionario_DoubleClick(object sender, EventArgs e)
        {
            lblID.Visible = true;
            lblID.Text = dtgFuncionario.SelectedRows[0].Cells["id"].Value.ToString();
            txtUser.Text = dtgFuncionario.SelectedRows[0].Cells["usuario"].Value.ToString();
            txtSenha.Text = dtgFuncionario.SelectedRows[0].Cells["senha"].Value.ToString();
            txtNome.Text = dtgFuncionario.SelectedRows[0].Cells["nome"].Value.ToString();
            if (dtgFuncionario.SelectedRows[0].Cells["isAdm"].Value.Equals("N"))
                rdbAdmN.Checked = true;
            if (dtgFuncionario.SelectedRows[0].Cells["isAdm"].Value.Equals("S"))
                rdbAdmS.Checked = true;
            imagemFuncionarioBtn.Text = dtgFuncionario.SelectedRows[0].Cells["imagem"].Value.ToString();
            imagemFuncionarioPb.Image = new Bitmap(Conexao.getPathImagens() + @"Funcionarios\" + dtgFuncionario.SelectedRows[0].Cells["imagem"].Value.ToString());
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblID.Visible = false;
            limpaCampos();
            habilitaControles(true);
            habilitaButtons(false);
            txtUser.Focus();
            lblControl.Text = "1";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            habilitaButtons(false);
            txtUser.Enabled = false;
            imagemFuncionarioBtn.Enabled = false;
            txtSenha.Focus();
            lblControl.Text = "2";
            CAMADAS.BLL.FuncionarioBLL bllFunc = new CAMADAS.BLL.FuncionarioBLL();
            dtgFuncionario.DataSource = "";
            dtgFuncionario.DataSource = bllFunc.Select();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            habilitaButtons(false);
            lblControl.Text = "3";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaControles(false);
            habilitaButtons(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.FuncionarioBLL bllFunc = new CAMADAS.BLL.FuncionarioBLL();
            if (lblControl.Text.Equals("3")) // deletar
            {
                string title = "Remover";
                string msg = "Deseja remover o funcionário: " + txtNome.Text;
                DialogResult resposta = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    bllFunc.Delete(id);
                }
            }
            else
            {
                string msg = "";
                string title = "";
                if (lblControl.Text.Equals("1"))
                {
                    msg = "Deseja cadastrar novo funcionário?";
                    title = "Cadastrar";
                }
                else if(lblControl.Text.Equals("2"))
                {
                    msg = "Deseja editar o funcionário atual?";
                    title = "Editar";
                }
                DialogResult resposta = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (resposta == DialogResult.Yes)
                {
                    CAMADAS.MODEL.Funcionario funcionario = new CAMADAS.MODEL.Funcionario();
                    funcionario.id = Convert.ToInt32(lblID.Text);
                    funcionario.usuario = txtUser.Text;
                    funcionario.senha = txtSenha.Text;
                    funcionario.nome = txtNome.Text;
                    if (rdbAdmN.Checked)
                        funcionario.isAdm = "N";
                    else
                        funcionario.isAdm = "S";
                    if (lblControl.Text.Equals("1"))
                    {
                        if (imagemFuncionarioPb.Image != null)
                        {
                            string[] partes = imagemFuncionario.SafeFileName.Split('.');
                            funcionario.imagem = funcionario.usuario + "." + partes[partes.Length - 1];
                            bllFunc.Insert(funcionario, imagemFuncionarioPb.Image);
                        }
                        else
                           MessageBox.Show("Escolha uma imagem!");
                    }
                    else if (lblControl.Text.Equals("2"))
                        bllFunc.Update(funcionario);
                }
            }
            limpaCampos();
            habilitaButtons(true);
            habilitaControles(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.FuncionarioBLL bllFunc = new CAMADAS.BLL.FuncionarioBLL();
            if(rdbTodos.Checked)
                dtgFuncionario.DataSource = bllFunc.Select();
            else if(rdbID.Checked)
            {
                int id = Convert.ToInt32(txtPesquisar.Text);
                dtgFuncionario.DataSource = bllFunc.SelectByID(id);
            }
            else if(rdbNome.Checked)
            {
                string nome = txtPesquisar.Text;
                dtgFuncionario.DataSource = bllFunc.SelectByNome(nome);
            }
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            dtgFuncionario.DataSource = "";
            txtPesquisar.Enabled = true;
            txtPesquisar.Focus();
            lblInsira.Text = "Insira o ID:";
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            dtgFuncionario.DataSource = "";
            txtPesquisar.Enabled = true;
            txtPesquisar.Focus();
            lblInsira.Text = "Insira o Nome:";
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            dtgFuncionario.DataSource = "";
            txtPesquisar.Enabled = false;
            lblInsira.Text = "";
        }
    }


}
