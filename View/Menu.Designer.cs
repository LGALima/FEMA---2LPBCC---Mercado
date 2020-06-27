namespace Mercado_Thay_and_Lusca.View
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.logo = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.compraMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.relFuncionáriosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 703);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1346, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logo,
            this.homeMenu,
            this.cadastroMenu,
            this.compraMenu,
            this.relatóriosMenu,
            this.sobreMenu,
            this.sairMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1346, 50);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // logo
            // 
            this.logo.AutoSize = false;
            this.logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 40);
            this.logo.Text = " ";
            this.logo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // homeMenu
            // 
            this.homeMenu.Checked = true;
            this.homeMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.homeMenu.ForeColor = System.Drawing.Color.Maroon;
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(70, 46);
            this.homeMenu.Text = "Home";
            this.homeMenu.Click += new System.EventHandler(this.homeMenu_Click);
            // 
            // cadastroMenu
            // 
            this.cadastroMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosMenu,
            this.clientesMenu,
            this.categoriasMenu,
            this.produtosMenu});
            this.cadastroMenu.ForeColor = System.Drawing.Color.Maroon;
            this.cadastroMenu.Name = "cadastroMenu";
            this.cadastroMenu.Size = new System.Drawing.Size(93, 46);
            this.cadastroMenu.Text = "Cadastro";
            // 
            // funcionáriosMenu
            // 
            this.funcionáriosMenu.Name = "funcionáriosMenu";
            this.funcionáriosMenu.Size = new System.Drawing.Size(188, 26);
            this.funcionáriosMenu.Text = "Funcionários";
            this.funcionáriosMenu.Click += new System.EventHandler(this.funcionáriosMenu_Click);
            // 
            // clientesMenu
            // 
            this.clientesMenu.Name = "clientesMenu";
            this.clientesMenu.Size = new System.Drawing.Size(188, 26);
            this.clientesMenu.Text = "Clientes";
            this.clientesMenu.Click += new System.EventHandler(this.clientesMenu_Click);
            // 
            // categoriasMenu
            // 
            this.categoriasMenu.Name = "categoriasMenu";
            this.categoriasMenu.Size = new System.Drawing.Size(188, 26);
            this.categoriasMenu.Text = "Categorias";
            this.categoriasMenu.Click += new System.EventHandler(this.categoriasMenu_Click);
            // 
            // produtosMenu
            // 
            this.produtosMenu.Name = "produtosMenu";
            this.produtosMenu.Size = new System.Drawing.Size(188, 26);
            this.produtosMenu.Text = "Produtos";
            this.produtosMenu.Click += new System.EventHandler(this.produtoMenu_Click);
            // 
            // compraMenu
            // 
            this.compraMenu.ForeColor = System.Drawing.Color.Maroon;
            this.compraMenu.Name = "compraMenu";
            this.compraMenu.Size = new System.Drawing.Size(87, 46);
            this.compraMenu.Text = "Compra";
            // 
            // relatóriosMenu
            // 
            this.relatóriosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relFuncionáriosMenu,
            this.clientesToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.relatóriosMenu.ForeColor = System.Drawing.Color.Maroon;
            this.relatóriosMenu.Name = "relatóriosMenu";
            this.relatóriosMenu.Size = new System.Drawing.Size(102, 46);
            this.relatóriosMenu.Text = "Relatórios";
            // 
            // sobreMenu
            // 
            this.sobreMenu.ForeColor = System.Drawing.Color.Maroon;
            this.sobreMenu.Name = "sobreMenu";
            this.sobreMenu.Size = new System.Drawing.Size(67, 46);
            this.sobreMenu.Text = "Sobre";
            this.sobreMenu.Click += new System.EventHandler(this.sobreMenu_Click);
            // 
            // sairMenu
            // 
            this.sairMenu.ForeColor = System.Drawing.Color.Maroon;
            this.sairMenu.Name = "sairMenu";
            this.sairMenu.Size = new System.Drawing.Size(56, 46);
            this.sairMenu.Text = "Sair";
            this.sairMenu.Click += new System.EventHandler(this.sairMenu_Click);
            // 
            // relFuncionáriosMenu
            // 
            this.relFuncionáriosMenu.Name = "relFuncionáriosMenu";
            this.relFuncionáriosMenu.Size = new System.Drawing.Size(188, 26);
            this.relFuncionáriosMenu.Text = "Funcionários";
            this.relFuncionáriosMenu.Click += new System.EventHandler(this.relFuncionáriosMenu_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = false;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LT Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem logo;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenu;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosMenu;
        private System.Windows.Forms.ToolStripMenuItem clientesMenu;
        private System.Windows.Forms.ToolStripMenuItem categoriasMenu;
        private System.Windows.Forms.ToolStripMenuItem compraMenu;
        private System.Windows.Forms.ToolStripMenuItem homeMenu;
        private System.Windows.Forms.ToolStripMenuItem relatóriosMenu;
        private System.Windows.Forms.ToolStripMenuItem sobreMenu;
        private System.Windows.Forms.ToolStripMenuItem sairMenu;
        private System.Windows.Forms.ToolStripMenuItem produtosMenu;
        private System.Windows.Forms.ToolStripMenuItem relFuncionáriosMenu;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}