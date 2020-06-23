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
        private void limpaCampos()
        {
            txtUser.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            rdbAdmS.Checked = false;
            rdbAdmN.Checked = true;
            imagemFuncionarioPb.Image = null;
            imagemFuncionarioBtn.Text = "Selecione";
            imagemFuncionario = new OpenFileDialog();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Funcionario funcionario = new CAMADAS.MODEL.Funcionario();
            funcionario.usuario = txtUser.Text;
            funcionario.senha = txtSenha.Text;
            funcionario.nome = txtNome.Text;
            if (rdbAdmN.Checked)
                funcionario.isAdm = "N";
            else
                funcionario.isAdm = "S";
            funcionario.imagem = imagemFuncionario.SafeFileName;
            limpaCampos();
        }
    }
}
