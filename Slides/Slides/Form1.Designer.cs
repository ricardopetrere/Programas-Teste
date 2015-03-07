namespace Slides
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
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnComeçar = new System.Windows.Forms.Button();
            this.lbImagens = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(12, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(120, 23);
            this.btnConfigurar.TabIndex = 0;
            this.btnConfigurar.TabStop = false;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnComeçar
            // 
            this.btnComeçar.Location = new System.Drawing.Point(12, 41);
            this.btnComeçar.Name = "btnComeçar";
            this.btnComeçar.Size = new System.Drawing.Size(120, 23);
            this.btnComeçar.TabIndex = 2;
            this.btnComeçar.TabStop = false;
            this.btnComeçar.Text = "Começar";
            this.btnComeçar.UseVisualStyleBackColor = true;
            this.btnComeçar.Click += new System.EventHandler(this.btnComeçar_Click);
            // 
            // lbImagens
            // 
            this.lbImagens.AllowDrop = true;
            this.lbImagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImagens.FormattingEnabled = true;
            this.lbImagens.HorizontalScrollbar = true;
            this.lbImagens.Location = new System.Drawing.Point(12, 70);
            this.lbImagens.Name = "lbImagens";
            this.lbImagens.Size = new System.Drawing.Size(120, 186);
            this.lbImagens.TabIndex = 3;
            this.lbImagens.TabStop = false;
            this.lbImagens.SelectedIndexChanged += new System.EventHandler(this.lbImagens_SelectedIndexChanged);
            this.lbImagens.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbImagens_DragDrop);
            this.lbImagens.DoubleClick += new System.EventHandler(this.lbImagens_DoubleClick);
            this.lbImagens.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbImagens_DragEnter);
            this.lbImagens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbImagens_KeyDown);
            this.lbImagens.Click += new System.EventHandler(this.lbImagens_Click);
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
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.lbImagens);
            this.Controls.Add(this.btnComeçar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfigurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apresentador de Imagens";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnComeçar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbImagens;
    }
}

