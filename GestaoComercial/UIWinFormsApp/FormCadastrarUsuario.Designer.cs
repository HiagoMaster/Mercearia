﻿namespace UIWinFormsApp
{
    partial class FormCadastrarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxConfirmaçãoSenha = new System.Windows.Forms.TextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSourceCadastro = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(12, 65);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(431, 27);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome de Usuario";
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "NomeUsuario", true));
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(449, 65);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(455, 27);
            this.textBoxNomeUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirmação de senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastro, "Senha", true));
            this.textBoxSenha.Location = new System.Drawing.Point(12, 126);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(186, 27);
            this.textBoxSenha.TabIndex = 6;
            // 
            // textBoxConfirmaçãoSenha
            // 
            this.textBoxConfirmaçãoSenha.Location = new System.Drawing.Point(223, 126);
            this.textBoxConfirmaçãoSenha.Name = "textBoxConfirmaçãoSenha";
            this.textBoxConfirmaçãoSenha.Size = new System.Drawing.Size(189, 27);
            this.textBoxConfirmaçãoSenha.TabIndex = 7;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCadastro, "Ativo", true));
            this.checkBoxAtivo.Location = new System.Drawing.Point(418, 126);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(66, 24);
            this.checkBoxAtivo.TabIndex = 8;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(672, 409);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 9;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(772, 409);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cadastrar usuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastro
            // 
            this.bindingSourceCadastro.DataSource = typeof(Models.Usuario);
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.textBoxConfirmaçãoSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCadastrarUsuario";
            this.Text = "FormCadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private BindingSource bindingSourceCadastro;
        private Label label1;
        private Label label2;
        private TextBox textBoxNomeUsuario;
        private Label label3;
        private Label label4;
        private TextBox textBoxSenha;
        private TextBox textBoxConfirmaçãoSenha;
        private CheckBox checkBoxAtivo;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label label5;
    }
}