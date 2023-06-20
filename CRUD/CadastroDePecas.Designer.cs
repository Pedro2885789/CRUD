namespace CRUD
{
    partial class CadastroDePecas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            AoClicarCancelar = new Button();
            AoClicarSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 129);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 12);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 3;
            label4.Text = "Data de Fabricação";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 71);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Estoque";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 36);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 95);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 153);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 97);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(209, 36);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(209, 95);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(165, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // AoClicarCancelar
            // 
            AoClicarCancelar.Location = new Point(136, 317);
            AoClicarCancelar.Margin = new Padding(3, 4, 3, 4);
            AoClicarCancelar.Name = "AoClicarCancelar";
            AoClicarCancelar.Size = new Size(117, 52);
            AoClicarCancelar.TabIndex = 10;
            AoClicarCancelar.Text = "Cancelar";
            AoClicarCancelar.UseVisualStyleBackColor = true;
            AoClicarCancelar.Click += AoClicarCancelar_Click;
            // 
            // AoClicarSalvar
            // 
            AoClicarSalvar.Location = new Point(261, 317);
            AoClicarSalvar.Margin = new Padding(3, 4, 3, 4);
            AoClicarSalvar.Name = "AoClicarSalvar";
            AoClicarSalvar.Size = new Size(117, 52);
            AoClicarSalvar.TabIndex = 11;
            AoClicarSalvar.Text = "Salvar";
            AoClicarSalvar.UseVisualStyleBackColor = true;
            AoClicarSalvar.Click += AoClicarSalvar_Click;
            // 
            // CadastroDePecas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 385);
            Controls.Add(AoClicarSalvar);
            Controls.Add(AoClicarCancelar);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroDePecas";
            Text = "CadastroDePecas";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Button AoClicarCancelar;
        private Button AoClicarSalvar;
    }
}