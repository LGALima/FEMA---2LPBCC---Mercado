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
    }
}
