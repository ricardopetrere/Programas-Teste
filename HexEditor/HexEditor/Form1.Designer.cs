namespace HexEditor
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.btnBuscarArquivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colVariavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(688, 114);
            this.textBox1.TabIndex = 0;
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(64, 23);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.ReadOnly = true;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(555, 20);
            this.txtCaminhoArquivo.TabIndex = 1;
            // 
            // btnBuscarArquivo
            // 
            this.btnBuscarArquivo.Location = new System.Drawing.Point(625, 12);
            this.btnBuscarArquivo.Name = "btnBuscarArquivo";
            this.btnBuscarArquivo.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarArquivo.TabIndex = 2;
            this.btnBuscarArquivo.Text = "Buscar Arquivo";
            this.btnBuscarArquivo.UseVisualStyleBackColor = true;
            this.btnBuscarArquivo.Click += new System.EventHandler(this.btnBuscarArquivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVariavel,
            this.colTipo,
            this.colValor});
            this.dataGridView1.Location = new System.Drawing.Point(13, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 163);
            this.dataGridView1.TabIndex = 3;
            // 
            // colVariavel
            // 
            this.colVariavel.HeaderText = "Variável";
            this.colVariavel.Name = "colVariavel";
            this.colVariavel.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arquivo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarArquivo);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.Button btnBuscarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Label label1;
    }
}

