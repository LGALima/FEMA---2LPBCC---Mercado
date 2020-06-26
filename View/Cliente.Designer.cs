namespace Mercado_Thay_and_Lusca
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.pbFotoCliente = new System.Windows.Forms.PictureBox();
            this.carregarImagemCliente = new System.Windows.Forms.OpenFileDialog();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblInserir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imagem:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(560, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Gerenciar Cliente";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(425, 115);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(425, 151);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(212, 20);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(425, 187);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(425, 223);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(425, 259);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(113, 20);
            this.txtSaldo.TabIndex = 11;
            // 
            // pbFotoCliente
            // 
            this.pbFotoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFotoCliente.BackgroundImage")));
            this.pbFotoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFotoCliente.Location = new System.Drawing.Point(674, 110);
            this.pbFotoCliente.Name = "pbFotoCliente";
            this.pbFotoCliente.Size = new System.Drawing.Size(200, 210);
            this.pbFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoCliente.TabIndex = 12;
            this.pbFotoCliente.TabStop = false;
            // 
            // carregarImagemCliente
            // 
            this.carregarImagemCliente.FileName = "openFileDialog1";
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(425, 293);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(113, 23);
            this.btnCarregarImagem.TabIndex = 13;
            this.btnCarregarImagem.Text = "Selecione";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.carregarImagemBtn_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(897, 131);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 30);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(897, 203);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 30);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(897, 167);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(150, 30);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(897, 239);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 30);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(897, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(290, 448);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(757, 149);
            this.dgvClientes.TabIndex = 20;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgvClientes_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(585, 278);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 24);
            this.lblId.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 23;
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(108, 42);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(45, 28);
            this.rbId.TabIndex = 24;
            this.rbId.TabStop = true;
            this.rbId.Text = "ID";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(188, 41);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(80, 28);
            this.rbNome.TabIndex = 25;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(275, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(309, 29);
            this.txtPesquisar.TabIndex = 26;
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Location = new System.Drawing.Point(607, 41);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(150, 30);
            this.pesquisarBtn.TabIndex = 27;
            this.pesquisarBtn.Text = "&Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            this.pesquisarBtn.Click += new System.EventHandler(this.pesquisarBtn_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 41);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(82, 28);
            this.rbTodos.TabIndex = 28;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.lblInserir);
            this.gpbPesquisa.Controls.Add(this.rbTodos);
            this.gpbPesquisa.Controls.Add(this.pesquisarBtn);
            this.gpbPesquisa.Controls.Add(this.rbId);
            this.gpbPesquisa.Controls.Add(this.txtPesquisar);
            this.gpbPesquisa.Controls.Add(this.rbNome);
            this.gpbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisa.Location = new System.Drawing.Point(290, 365);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(757, 77);
            this.gpbPesquisa.TabIndex = 26;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa";
            // 
            // lblInserir
            // 
            this.lblInserir.AutoSize = true;
            this.lblInserir.Location = new System.Drawing.Point(275, 14);
            this.lblInserir.Name = "lblInserir";
            this.lblInserir.Size = new System.Drawing.Size(0, 24);
            this.lblInserir.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(21, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 692);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.pbFotoCliente);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.PictureBox pbFotoCliente;
        private System.Windows.Forms.OpenFileDialog carregarImagemCliente;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblInserir;
    }
}