namespace Slides
{
    partial class frmImagem
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProxima = new System.Windows.Forms.Label();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNome
            // 
            this.lblNome.AutoEllipsis = true;
            this.lblNome.BackColor = System.Drawing.Color.Black;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(0, 250);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(300, 50);
            this.lblNome.TabIndex = 2;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProxima
            // 
            this.lblProxima.BackColor = System.Drawing.Color.LightGray;
            this.lblProxima.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblProxima.ForeColor = System.Drawing.Color.Black;
            this.lblProxima.Location = new System.Drawing.Point(200, 0);
            this.lblProxima.Name = "lblProxima";
            this.lblProxima.Size = new System.Drawing.Size(100, 250);
            this.lblProxima.TabIndex = 1;
            this.lblProxima.Text = ">";
            this.lblProxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProxima.Click += new System.EventHandler(this.lblProxima_Click);
            // 
            // lblAnterior
            // 
            this.lblAnterior.BackColor = System.Drawing.Color.LightGray;
            this.lblAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAnterior.ForeColor = System.Drawing.Color.Black;
            this.lblAnterior.Location = new System.Drawing.Point(0, 0);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(100, 250);
            this.lblAnterior.TabIndex = 0;
            this.lblAnterior.Text = "<";
            this.lblAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnterior.Click += new System.EventHandler(this.lblAnterior_Click);
            // 
            // frmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.lblProxima);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImagem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmImagem_MouseClick);
            this.DoubleClick += new System.EventHandler(this.frmImagem_DoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmImagem_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImagem_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblProxima;
        private System.Windows.Forms.Label lblAnterior;
    }
}