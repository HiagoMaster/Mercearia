namespace UIWinFormsApp
{
    partial class FormBuscarProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.button1Buscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.bindingSourceProduto = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Por";
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Preco",
            "Estoque",
            "CodigoDeBarra",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(12, 147);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxBuscarPor.TabIndex = 2;
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(187, 148);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(377, 27);
            this.textBoxBuscarPor.TabIndex = 3;
            // 
            // button1Buscar
            // 
            this.button1Buscar.Location = new System.Drawing.Point(570, 146);
            this.button1Buscar.Name = "button1Buscar";
            this.button1Buscar.Size = new System.Drawing.Size(94, 29);
            this.button1Buscar.TabIndex = 4;
            this.button1Buscar.Text = "&Buscar";
            this.button1Buscar.UseVisualStyleBackColor = true;
            this.button1Buscar.Click += new System.EventHandler(this.button1Buscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(670, 147);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 5;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(770, 148);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(94, 29);
            this.Inserir.TabIndex = 6;
            this.Inserir.Text = "&Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(870, 148);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.Text = "E&xcluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(770, 409);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(870, 409);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // bindingSourceProduto
            // 
            this.bindingSourceProduto.DataSource = typeof(Models.Produto);
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.AutoGenerateColumns = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.codigoDeBarraDataGridViewTextBoxColumn});
            this.dataGridViewProduto.DataSource = this.bindingSourceProduto;
            this.dataGridViewProduto.Location = new System.Drawing.Point(12, 183);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(952, 220);
            this.dataGridViewProduto.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoDeBarraDataGridViewTextBoxColumn
            // 
            this.codigoDeBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarra";
            this.codigoDeBarraDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarra";
            this.codigoDeBarraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDeBarraDataGridViewTextBoxColumn.Name = "codigoDeBarraDataGridViewTextBoxColumn";
            this.codigoDeBarraDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDeBarraDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormBuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.button1Buscar);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBuscarProduto";
            this.Text = "FormBuscarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscarPor;
        private Button button1Buscar;
        private Button buttonAlterar;
        private Button Inserir;
        private Button buttonExcluir;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private BindingSource bindingSourceProduto;
        private DataGridView dataGridViewProduto;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDeBarraDataGridViewTextBoxColumn;
    }
}