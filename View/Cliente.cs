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
            limparCampos();
        }

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
                fotoClientePb.Image = new Bitmap(carregarImagemCliente.FileName);
                carregarImagemBtn.Text = carregarImagemCliente.SafeFileName;
            }
        }
        public void limparCampos()
        {
            usuarioTxt.Text = "";
            senhaTxt.Text = "";
            nomeTxt.Text = "";
            enderecoTxt.Text = "";
            saldoTxt.Text = "0";
            carregarImagemBtn.Text = "Selecione";
            fotoClientePb.Image = null;
            carregarImagemCliente = new OpenFileDialog();
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.usuario = usuarioTxt.Text;
            cliente.senha = senhaTxt.Text;
            cliente.nome = nomeTxt.Text;
            cliente.endereco = enderecoTxt.Text;
            cliente.saldo =  Math.Round(Convert.ToDouble(saldoTxt.Text),2);
            if(fotoClientePb.Image != null)
            {
                string[] partes = carregarImagemCliente.SafeFileName.Split('.');
                cliente.imagem = cliente.usuario + "." +partes[partes.Length - 1];
                CAMADAS.BLL.ClienteBLL cliBLL = new CAMADAS.BLL.ClienteBLL();
                cliBLL.Insert(cliente, fotoClientePb.Image);
            } else
            {
                MessageBox.Show("Escolha uma imagem!");
            }

            limparCampos();
        }

        private void fotoClientePb_Click(object sender, EventArgs e)
        {

        }
    }
}
