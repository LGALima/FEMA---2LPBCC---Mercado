﻿namespace Mercado_Thay_and_Lusca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.saldoTxt = new System.Windows.Forms.TextBox();
            this.fotoClientePb = new System.Windows.Forms.PictureBox();
            this.carregarImagemCliente = new System.Windows.Forms.OpenFileDialog();
            this.carregarImagemBtn = new System.Windows.Forms.Button();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoClientePb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Imagem:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "CADASTRO DE CLIENTE";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(155, 106);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(180, 20);
            this.usuarioTxt.TabIndex = 7;
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(155, 146);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.Size = new System.Drawing.Size(180, 20);
            this.senhaTxt.TabIndex = 8;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(155, 186);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(180, 20);
            this.nomeTxt.TabIndex = 9;
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.Location = new System.Drawing.Point(155, 226);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(180, 20);
            this.enderecoTxt.TabIndex = 10;
            // 
            // saldoTxt
            // 
            this.saldoTxt.Location = new System.Drawing.Point(155, 266);
            this.saldoTxt.Name = "saldoTxt";
            this.saldoTxt.Size = new System.Drawing.Size(67, 20);
            this.saldoTxt.TabIndex = 11;
            // 
            // fotoClientePb
            // 
            this.fotoClientePb.Location = new System.Drawing.Point(418, 82);
            this.fotoClientePb.Name = "fotoClientePb";
            this.fotoClientePb.Size = new System.Drawing.Size(250, 250);
            this.fotoClientePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoClientePb.TabIndex = 12;
            this.fotoClientePb.TabStop = false;
            this.fotoClientePb.Click += new System.EventHandler(this.fotoClientePb_Click);
            // 
            // carregarImagemCliente
            // 
            this.carregarImagemCliente.FileName = "openFileDialog1";
            // 
            // carregarImagemBtn
            // 
            this.carregarImagemBtn.Location = new System.Drawing.Point(154, 303);
            this.carregarImagemBtn.Name = "carregarImagemBtn";
            this.carregarImagemBtn.Size = new System.Drawing.Size(75, 23);
            this.carregarImagemBtn.TabIndex = 13;
            this.carregarImagemBtn.Text = "Selecione";
            this.carregarImagemBtn.UseVisualStyleBackColor = true;
            this.carregarImagemBtn.Click += new System.EventHandler(this.carregarImagemBtn_Click);
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(517, 358);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarBtn.TabIndex = 14;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.carregarImagemBtn);
            this.Controls.Add(this.fotoClientePb);
            this.Controls.Add(this.saldoTxt);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.fotoClientePb)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.TextBox saldoTxt;
        private System.Windows.Forms.PictureBox fotoClientePb;
        private System.Windows.Forms.OpenFileDialog carregarImagemCliente;
        private System.Windows.Forms.Button carregarImagemBtn;
        private System.Windows.Forms.Button cadastrarBtn;
    }
}