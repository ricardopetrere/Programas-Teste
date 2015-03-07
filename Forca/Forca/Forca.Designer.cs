namespace Forca
{
    partial class Forca
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
            this.picForca = new System.Windows.Forms.PictureBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.txtErros = new System.Windows.Forms.TextBox();
            this.btnComecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picForca)).BeginInit();
            this.SuspendLayout();
            // 
            // picForca
            // 
            this.picForca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picForca.ImageLocation = "";
            this.picForca.Location = new System.Drawing.Point(12, 12);
            this.picForca.Name = "picForca";
            this.picForca.Size = new System.Drawing.Size(250, 250);
            this.picForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picForca.TabIndex = 0;
            this.picForca.TabStop = false;
            // 
            // txtPalavra
            // 
            this.txtPalavra.BackColor = System.Drawing.Color.White;
            this.txtPalavra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(12, 268);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.ReadOnly = true;
            this.txtPalavra.Size = new System.Drawing.Size(250, 38);
            this.txtPalavra.TabIndex = 3;
            this.txtPalavra.TabStop = false;
            this.txtPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPalavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // txtErros
            // 
            this.txtErros.BackColor = System.Drawing.Color.White;
            this.txtErros.Location = new System.Drawing.Point(288, 51);
            this.txtErros.Name = "txtErros";
            this.txtErros.ReadOnly = true;
            this.txtErros.Size = new System.Drawing.Size(100, 20);
            this.txtErros.TabIndex = 4;
            this.txtErros.TabStop = false;
            this.txtErros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(301, 145);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 5;
            this.btnComecar.TabStop = false;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            this.btnComecar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // Forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 317);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.txtErros);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.picForca);
            this.MaximizeBox = false;
            this.Name = "Forca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.Load += new System.EventHandler(this.Forca_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picForca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picForca;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.TextBox txtErros;
        private System.Windows.Forms.Button btnComecar;
    }
}

