namespace Mercado_Thay_and_Lusca.View
{
    partial class Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbDescricao = new System.Windows.Forms.RadioButton();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInsira = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(346, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(452, 190);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(257, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(451, 154);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(84, 23);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "-1";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(290, 448);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(757, 149);
            this.dgvCategoria.TabIndex = 5;
            this.dgvCategoria.DoubleClick += new System.EventHandler(this.dgvCategoria_DoubleClick);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(6, 40);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(82, 28);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(110, 40);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(45, 28);
            this.rbId.TabIndex = 7;
            this.rbId.TabStop = true;
            this.rbId.Text = "ID";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // rbDescricao
            // 
            this.rbDescricao.AutoSize = true;
            this.rbDescricao.Location = new System.Drawing.Point(188, 40);
            this.rbDescricao.Name = "rbDescricao";
            this.rbDescricao.Size = new System.Drawing.Size(108, 28);
            this.rbDescricao.TabIndex = 8;
            this.rbDescricao.TabStop = true;
            this.rbDescricao.Text = "Categoria";
            this.rbDescricao.UseVisualStyleBackColor = true;
            this.rbDescricao.CheckedChanged += new System.EventHandler(this.rbDescricao_CheckedChanged);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(607, 38);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(150, 30);
            this.Pesquisar.TabIndex = 9;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(302, 39);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(299, 29);
            this.txtPesquisar.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(897, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(897, 220);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 30);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(897, 148);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(150, 30);
            this.btnDeletar.TabIndex = 22;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(897, 184);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 30);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(897, 112);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 30);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInsira);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbId);
            this.groupBox1.Controls.Add(this.rbDescricao);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.Pesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(290, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 77);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Location = new System.Drawing.Point(301, 12);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(0, 24);
            this.lblInsira.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(21, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 30);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 692);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbDescricao;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInsira;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoltar;
    }
}