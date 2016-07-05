namespace Alarme
{
    partial class ucGerenciadorTempo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenosHora = new System.Windows.Forms.Button();
            this.btnMaisHora = new System.Windows.Forms.Button();
            this.btnMenosMinuto = new System.Windows.Forms.Button();
            this.btnMaisMinuto = new System.Windows.Forms.Button();
            this.btnMenosSegundo = new System.Windows.Forms.Button();
            this.btnMaisSegundo = new System.Windows.Forms.Button();
            this.ucTempo1 = new Alarme.ucTempo();
            this.SuspendLayout();
            // 
            // btnMenosHora
            // 
            this.btnMenosHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosHora.Location = new System.Drawing.Point(0, 90);
            this.btnMenosHora.Name = "btnMenosHora";
            this.btnMenosHora.Size = new System.Drawing.Size(40, 40);
            this.btnMenosHora.TabIndex = 4;
            this.btnMenosHora.Text = "-";
            this.btnMenosHora.UseVisualStyleBackColor = true;
            this.btnMenosHora.Click += new System.EventHandler(this.btnMenosHora_Click);
            // 
            // btnMaisHora
            // 
            this.btnMaisHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisHora.Location = new System.Drawing.Point(0, 0);
            this.btnMaisHora.Name = "btnMaisHora";
            this.btnMaisHora.Size = new System.Drawing.Size(40, 40);
            this.btnMaisHora.TabIndex = 3;
            this.btnMaisHora.Text = "+";
            this.btnMaisHora.UseVisualStyleBackColor = true;
            this.btnMaisHora.Click += new System.EventHandler(this.btnMaisHora_Click);
            // 
            // btnMenosMinuto
            // 
            this.btnMenosMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosMinuto.Location = new System.Drawing.Point(80, 90);
            this.btnMenosMinuto.Name = "btnMenosMinuto";
            this.btnMenosMinuto.Size = new System.Drawing.Size(40, 40);
            this.btnMenosMinuto.TabIndex = 6;
            this.btnMenosMinuto.Text = "-";
            this.btnMenosMinuto.UseVisualStyleBackColor = true;
            this.btnMenosMinuto.Click += new System.EventHandler(this.btnMenosMinuto_Click);
            // 
            // btnMaisMinuto
            // 
            this.btnMaisMinuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMinuto.Location = new System.Drawing.Point(80, 0);
            this.btnMaisMinuto.Name = "btnMaisMinuto";
            this.btnMaisMinuto.Size = new System.Drawing.Size(40, 40);
            this.btnMaisMinuto.TabIndex = 5;
            this.btnMaisMinuto.Text = "+";
            this.btnMaisMinuto.UseVisualStyleBackColor = true;
            this.btnMaisMinuto.Click += new System.EventHandler(this.btnMaisMinuto_Click);
            // 
            // btnMenosSegundo
            // 
            this.btnMenosSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenosSegundo.Location = new System.Drawing.Point(160, 90);
            this.btnMenosSegundo.Name = "btnMenosSegundo";
            this.btnMenosSegundo.Size = new System.Drawing.Size(40, 40);
            this.btnMenosSegundo.TabIndex = 8;
            this.btnMenosSegundo.Text = "-";
            this.btnMenosSegundo.UseVisualStyleBackColor = true;
            this.btnMenosSegundo.Click += new System.EventHandler(this.btnMenosSegundo_Click);
            // 
            // btnMaisSegundo
            // 
            this.btnMaisSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisSegundo.Location = new System.Drawing.Point(160, 0);
            this.btnMaisSegundo.Name = "btnMaisSegundo";
            this.btnMaisSegundo.Size = new System.Drawing.Size(40, 40);
            this.btnMaisSegundo.TabIndex = 7;
            this.btnMaisSegundo.Text = "+";
            this.btnMaisSegundo.UseVisualStyleBackColor = true;
            this.btnMaisSegundo.Click += new System.EventHandler(this.btnMaisSegundo_Click);
            // 
            // ucTempo1
            // 
            this.ucTempo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucTempo1.Horario = System.TimeSpan.Parse("23:59:59");
            this.ucTempo1.Location = new System.Drawing.Point(0, 46);
            this.ucTempo1.Name = "ucTempo1";
            this.ucTempo1.Size = new System.Drawing.Size(246, 38);
            this.ucTempo1.TabIndex = 0;
            // 
            // ucGerenciadorTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMenosSegundo);
            this.Controls.Add(this.btnMaisSegundo);
            this.Controls.Add(this.btnMenosMinuto);
            this.Controls.Add(this.btnMaisMinuto);
            this.Controls.Add(this.btnMenosHora);
            this.Controls.Add(this.btnMaisHora);
            this.Controls.Add(this.ucTempo1);
            this.Name = "ucGerenciadorTempo";
            this.Size = new System.Drawing.Size(244, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private ucTempo ucTempo1;
        private System.Windows.Forms.Button btnMenosHora;
        private System.Windows.Forms.Button btnMaisHora;
        private System.Windows.Forms.Button btnMenosMinuto;
        private System.Windows.Forms.Button btnMaisMinuto;
        private System.Windows.Forms.Button btnMenosSegundo;
        private System.Windows.Forms.Button btnMaisSegundo;
    }
}
