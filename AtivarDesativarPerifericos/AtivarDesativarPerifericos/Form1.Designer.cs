namespace AtivarDesativarPerifericos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sequencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnConfigurarConexao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequencial,
            this.Código,
            this.Descrição,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(389, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // Sequencial
            // 
            this.Sequencial.HeaderText = "Sequencial";
            this.Sequencial.Name = "Sequencial";
            this.Sequencial.Visible = false;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 116;
            // 
            // Descrição
            // 
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 115;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 116;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(407, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(70, 50);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnConfigurarConexao
            // 
            this.btnConfigurarConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurarConexao.Location = new System.Drawing.Point(407, 68);
            this.btnConfigurarConexao.Name = "btnConfigurarConexao";
            this.btnConfigurarConexao.Size = new System.Drawing.Size(70, 50);
            this.btnConfigurarConexao.TabIndex = 3;
            this.btnConfigurarConexao.Text = "Configurar Conexão";
            this.btnConfigurarConexao.UseVisualStyleBackColor = true;
            this.btnConfigurarConexao.Click += new System.EventHandler(this.btnConfigurarConexao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 225);
            this.Controls.Add(this.btnConfigurarConexao);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ativar/Desativar Periféricos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnConfigurarConexao;
    }
}

