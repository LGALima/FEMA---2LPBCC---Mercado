using MaterialSkin;
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
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
            Home frmHome = new Home();
            frmHome.MdiParent = this;
            frmHome.Show();
        }

        private void sairMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            Home frmHome = new Home();
            frmHome.MdiParent = this;
            frmHome.Show();
        }

        private void funcionáriosMenu_Click(object sender, EventArgs e)
        {
            Funcionario frmFuncionario = new Funcionario();
            frmFuncionario.MdiParent = this;
            frmFuncionario.Show();
        }

        private void clientesMenu_Click(object sender, EventArgs e)
        {
            Cliente frmCliente = new Cliente();
            frmCliente.MdiParent = this; 
            frmCliente.Show(); 
        }

        private void categoriasMenu_Click(object sender, EventArgs e)
        {
            Categoria frmCategoria = new Categoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void produtoMenu_Click(object sender, EventArgs e)
        {
            Produto frmProduto = new Produto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void sobreMenu_Click(object sender, EventArgs e)
        {
            Sobre frmSobre = new Sobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }
    }
}
