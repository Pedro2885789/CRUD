namespace CRUD
{
    partial class controleDePecas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AoClicarAdicionar = new Button();
            AoClicarEditar = new Button();
            AoClicarRemover = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estoqueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeFabricacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pecaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pecaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AoClicarAdicionar
            // 
            AoClicarAdicionar.Location = new Point(246, 297);
            AoClicarAdicionar.Name = "AoClicarAdicionar";
            AoClicarAdicionar.Size = new Size(132, 39);
            AoClicarAdicionar.TabIndex = 0;
            AoClicarAdicionar.Text = "Adicionar";
            AoClicarAdicionar.UseVisualStyleBackColor = true;
            AoClicarAdicionar.Click += AoClicarAdicionar_Click;
            // 
            // AoClicarEditar
            // 
            AoClicarEditar.Location = new Point(384, 297);
            AoClicarEditar.Name = "AoClicarEditar";
            AoClicarEditar.Size = new Size(132, 39);
            AoClicarEditar.TabIndex = 1;
            AoClicarEditar.Text = "Editar";
            AoClicarEditar.UseVisualStyleBackColor = true;
            // 
            // AoClicarRemover
            // 
            AoClicarRemover.Location = new Point(522, 297);
            AoClicarRemover.Name = "AoClicarRemover";
            AoClicarRemover.Size = new Size(132, 39);
            AoClicarRemover.TabIndex = 2;
            AoClicarRemover.Text = "Remover";
            AoClicarRemover.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, estoqueDataGridViewTextBoxColumn, dataDeFabricacaoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pecaBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(642, 279);
            dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            // 
            // dataDeFabricacaoDataGridViewTextBoxColumn
            // 
            dataDeFabricacaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeFabricacao";
            dataDeFabricacaoDataGridViewTextBoxColumn.HeaderText = "DataDeFabricacao";
            dataDeFabricacaoDataGridViewTextBoxColumn.Name = "dataDeFabricacaoDataGridViewTextBoxColumn";
            // 
            // pecaBindingSource
            // 
            pecaBindingSource.DataSource = typeof(Peca);
            // 
            // controleDePecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 344);
            Controls.Add(dataGridView1);
            Controls.Add(AoClicarRemover);
            Controls.Add(AoClicarEditar);
            Controls.Add(AoClicarAdicionar);
            Name = "controleDePecas";
            Text = "Controle de Peças";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pecaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AoClicarAdicionar;
        private Button AoClicarEditar;
        private Button AoClicarRemover;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeFabricacaoDataGridViewTextBoxColumn;
        private BindingSource pecaBindingSource;
    }
}