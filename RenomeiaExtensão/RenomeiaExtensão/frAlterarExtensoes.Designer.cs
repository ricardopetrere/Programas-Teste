namespace RenomeiaExtensão
{
    partial class frAlterarExtensoes
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
            this.btnSelecionarPasta = new System.Windows.Forms.Button();
            this.txtCaminhoPasta = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtensaoOrigem = new System.Windows.Forms.TextBox();
            this.txtExtensaoDestino = new System.Windows.Forms.TextBox();
            this.lbArquivosPasta = new System.Windows.Forms.ListBox();
            this.btnAlterarExtensoes = new System.Windows.Forms.Button();
            this.btnAtualizarListagem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionarPasta
            // 
            this.btnSelecionarPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarPasta.Location = new System.Drawing.Point(297, 62);
            this.btnSelecionarPasta.Name = "btnSelecionarPasta";
            this.btnSelecionarPasta.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarPasta.TabIndex = 0;
            this.btnSelecionarPasta.Text = "Selecionar Pasta";
            this.btnSelecionarPasta.UseVisualStyleBackColor = true;
            this.btnSelecionarPasta.Click += new System.EventHandler(this.btnSelecionarPasta_Click);
            // 
            // txtCaminhoPasta
            // 
            this.txtCaminhoPasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoPasta.Location = new System.Drawing.Point(12, 64);
            this.txtCaminhoPasta.Name = "txtCaminhoPasta";
            this.txtCaminhoPasta.ReadOnly = true;
            this.txtCaminhoPasta.Size = new System.Drawing.Size(279, 20);
            this.txtCaminhoPasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extensão de Origem";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensão de Destino";
            // 
            // txtExtensaoOrigem
            // 
            this.txtExtensaoOrigem.Location = new System.Drawing.Point(12, 109);
            this.txtExtensaoOrigem.Name = "txtExtensaoOrigem";
            this.txtExtensaoOrigem.Size = new System.Drawing.Size(126, 20);
            this.txtExtensaoOrigem.TabIndex = 4;
            // 
            // txtExtensaoDestino
            // 
            this.txtExtensaoDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtensaoDestino.Location = new System.Drawing.Point(246, 109);
            this.txtExtensaoDestino.Name = "txtExtensaoDestino";
            this.txtExtensaoDestino.Size = new System.Drawing.Size(126, 20);
            this.txtExtensaoDestino.TabIndex = 5;
            // 
            // lbArquivosPasta
            // 
            this.lbArquivosPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArquivosPasta.FormattingEnabled = true;
            this.lbArquivosPasta.HorizontalScrollbar = true;
            this.lbArquivosPasta.Location = new System.Drawing.Point(12, 135);
            this.lbArquivosPasta.Name = "lbArquivosPasta";
            this.lbArquivosPasta.Size = new System.Drawing.Size(360, 277);
            this.lbArquivosPasta.TabIndex = 6;
            // 
            // btnAlterarExtensoes
            // 
            this.btnAlterarExtensoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarExtensoes.Location = new System.Drawing.Point(297, 426);
            this.btnAlterarExtensoes.Name = "btnAlterarExtensoes";
            this.btnAlterarExtensoes.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarExtensoes.TabIndex = 7;
            this.btnAlterarExtensoes.Text = "Alterar";
            this.btnAlterarExtensoes.UseVisualStyleBackColor = true;
            this.btnAlterarExtensoes.Click += new System.EventHandler(this.btnAlterarExtensoes_Click);
            // 
            // btnAtualizarListagem
            // 
            this.btnAtualizarListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizarListagem.Location = new System.Drawing.Point(12, 426);
            this.btnAtualizarListagem.Name = "btnAtualizarListagem";
            this.btnAtualizarListagem.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarListagem.TabIndex = 8;
            this.btnAtualizarListagem.Text = "Atualizar Pasta";
            this.btnAtualizarListagem.UseVisualStyleBackColor = true;
            this.btnAtualizarListagem.Click += new System.EventHandler(this.btnAtualizarListagem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pasta:";
            // 
            // frAlterarExtensoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnAtualizarListagem);
            this.Controls.Add(this.btnAlterarExtensoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbArquivosPasta);
            this.Controls.Add(this.txtExtensaoDestino);
            this.Controls.Add(this.txtExtensaoOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminhoPasta);
            this.Controls.Add(this.btnSelecionarPasta);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frAlterarExtensoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Extensão de Arquivos em Lote";
            this.Load += new System.EventHandler(this.frAlterarExtensoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarPasta;
        private System.Windows.Forms.TextBox txtCaminhoPasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtensaoOrigem;
        private System.Windows.Forms.TextBox txtExtensaoDestino;
        private System.Windows.Forms.ListBox lbArquivosPasta;
        private System.Windows.Forms.Button btnAlterarExtensoes;
        private System.Windows.Forms.Button btnAtualizarListagem;
        private System.Windows.Forms.Label label3;
    }
}

