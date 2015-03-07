namespace Slidesv2
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
            this.components = new System.ComponentModel.Container();
            this.lbImagens = new System.Windows.Forms.ListBox();
            this.btnComeçar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.lblPasta = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panConfigurar = new System.Windows.Forms.Panel();
            this.panImagens = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panConfigurar.SuspendLayout();
            this.panImagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbImagens
            // 
            this.lbImagens.AllowDrop = true;
            this.lbImagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbImagens.FormattingEnabled = true;
            this.lbImagens.Location = new System.Drawing.Point(0, 29);
            this.lbImagens.Name = "lbImagens";
            this.lbImagens.Size = new System.Drawing.Size(130, 184);
            this.lbImagens.TabIndex = 7;
            this.lbImagens.TabStop = false;
            this.lbImagens.SelectedIndexChanged += new System.EventHandler(this.lbImagens_SelectedIndexChanged);
            this.lbImagens.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbImagens_DragDrop);
            this.lbImagens.DoubleClick += new System.EventHandler(this.lbImagens_DoubleClick);
            this.lbImagens.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbImagens_DragEnter);
            this.lbImagens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbImagens_KeyDown);
            this.lbImagens.Click += new System.EventHandler(this.lbImagens_Click);
            // 
            // btnComeçar
            // 
            this.btnComeçar.Location = new System.Drawing.Point(0, 0);
            this.btnComeçar.Name = "btnComeçar";
            this.btnComeçar.Size = new System.Drawing.Size(130, 23);
            this.btnComeçar.TabIndex = 6;
            this.btnComeçar.TabStop = false;
            this.btnComeçar.Text = "Começar";
            this.btnComeçar.UseVisualStyleBackColor = true;
            this.btnComeçar.Click += new System.EventHandler(this.btnComeçar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(12, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(130, 23);
            this.btnConfigurar.TabIndex = 4;
            this.btnConfigurar.TabStop = false;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(5, 49);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(51, 29);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.ReadOnly = true;
            this.txtPasta.Size = new System.Drawing.Size(44, 20);
            this.txtPasta.TabIndex = 14;
            // 
            // lblPasta
            // 
            this.lblPasta.AutoSize = true;
            this.lblPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasta.Location = new System.Drawing.Point(2, 32);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(43, 13);
            this.lblPasta.TabIndex = 13;
            this.lblPasta.Text = "Pasta:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(101, 27);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(25, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "...";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(89, 6);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(24, 13);
            this.lblSegundos.TabIndex = 11;
            this.lblSegundos.Text = "seg";
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(51, 3);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(32, 20);
            this.txtTimer.TabIndex = 10;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(2, 6);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(42, 13);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "Timer:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivos de imagem comuns|*.bmp;*.gif;*.jpeg;*.jpg;*.png";
            this.openFileDialog1.Multiselect = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panConfigurar
            // 
            this.panConfigurar.Controls.Add(this.lblTimer);
            this.panConfigurar.Controls.Add(this.txtTimer);
            this.panConfigurar.Controls.Add(this.lblSegundos);
            this.panConfigurar.Controls.Add(this.btnAlterar);
            this.panConfigurar.Controls.Add(this.lblPasta);
            this.panConfigurar.Controls.Add(this.txtPasta);
            this.panConfigurar.Controls.Add(this.btnSalvar);
            this.panConfigurar.Location = new System.Drawing.Point(12, 41);
            this.panConfigurar.Name = "panConfigurar";
            this.panConfigurar.Size = new System.Drawing.Size(130, 73);
            this.panConfigurar.TabIndex = 21;
            // 
            // panImagens
            // 
            this.panImagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panImagens.Controls.Add(this.btnComeçar);
            this.panImagens.Controls.Add(this.lbImagens);
            this.panImagens.Location = new System.Drawing.Point(12, 120);
            this.panImagens.Name = "panImagens";
            this.panImagens.Size = new System.Drawing.Size(130, 215);
            this.panImagens.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 259);
            this.Controls.Add(this.panImagens);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panConfigurar);
            this.Controls.Add(this.btnConfigurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panConfigurar.ResumeLayout(false);
            this.panConfigurar.PerformLayout();
            this.panImagens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComeçar;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Label lblPasta;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panConfigurar;
        private System.Windows.Forms.Panel panImagens;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbImagens;
    }
}

