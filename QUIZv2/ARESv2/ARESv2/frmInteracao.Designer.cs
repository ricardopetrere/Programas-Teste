namespace ARESv2
{
    partial class frmInteracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInteracao));
            this.btnSair = new System.Windows.Forms.Button();
            this.panPergunta = new System.Windows.Forms.Panel();
            this.txtNovoTema = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbMostrarPerguntas = new System.Windows.Forms.ComboBox();
            this.lblMostrarPerguntas = new System.Windows.Forms.Label();
            this.panMostrarPerguntas = new System.Windows.Forms.Panel();
            this.panPergunta.SuspendLayout();
            this.panMostrarPerguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(392, 141);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 40);
            this.btnSair.TabIndex = 99;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panPergunta
            // 
            this.panPergunta.Controls.Add(this.txtNovoTema);
            this.panPergunta.Controls.Add(this.txtD);
            this.panPergunta.Controls.Add(this.txtC);
            this.panPergunta.Controls.Add(this.txtB);
            this.panPergunta.Controls.Add(this.txtA);
            this.panPergunta.Controls.Add(this.rbD);
            this.panPergunta.Controls.Add(this.rbC);
            this.panPergunta.Controls.Add(this.rbB);
            this.panPergunta.Controls.Add(this.rbA);
            this.panPergunta.Controls.Add(this.cbTema);
            this.panPergunta.Controls.Add(this.lblTema);
            this.panPergunta.Controls.Add(this.lblPergunta);
            this.panPergunta.Controls.Add(this.txtPergunta);
            this.panPergunta.Location = new System.Drawing.Point(12, 12);
            this.panPergunta.Name = "panPergunta";
            this.panPergunta.Size = new System.Drawing.Size(460, 123);
            this.panPergunta.TabIndex = 4;
            // 
            // txtNovoTema
            // 
            this.txtNovoTema.Location = new System.Drawing.Point(233, 29);
            this.txtNovoTema.Name = "txtNovoTema";
            this.txtNovoTema.Size = new System.Drawing.Size(224, 20);
            this.txtNovoTema.TabIndex = 12;
            this.txtNovoTema.Text = "-- escreva aqui o novo tema --";
            this.txtNovoTema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNovoTema.Visible = false;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(273, 86);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(184, 20);
            this.txtD.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(43, 86);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(184, 20);
            this.txtC.TabIndex = 10;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(273, 60);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(184, 20);
            this.txtB.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(43, 60);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(184, 20);
            this.txtA.TabIndex = 8;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(233, 87);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(34, 17);
            this.rbD.TabIndex = 7;
            this.rbD.TabStop = true;
            this.rbD.Text = "d)";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(3, 87);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(34, 17);
            this.rbC.TabIndex = 6;
            this.rbC.TabStop = true;
            this.rbC.Text = "c)";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(233, 61);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(34, 17);
            this.rbB.TabIndex = 5;
            this.rbB.TabStop = true;
            this.rbB.Text = "b)";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(3, 61);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(34, 17);
            this.rbA.TabIndex = 4;
            this.rbA.TabStop = true;
            this.rbA.Text = "a)";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // cbTema
            // 
            this.cbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(46, 29);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(181, 21);
            this.cbTema.TabIndex = 3;
            this.cbTema.SelectedIndexChanged += new System.EventHandler(this.cbTema_SelectedIndexChanged);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(3, 32);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(37, 13);
            this.lblTema.TabIndex = 2;
            this.lblTema.Text = "Tema:";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(3, 7);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(65, 16);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "Pergunta:";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(74, 6);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(383, 20);
            this.txtPergunta.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(306, 141);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 40);
            this.btnSalvar.TabIndex = 98;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbMostrarPerguntas
            // 
            this.cbMostrarPerguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMostrarPerguntas.FormattingEnabled = true;
            this.cbMostrarPerguntas.Location = new System.Drawing.Point(64, 5);
            this.cbMostrarPerguntas.Name = "cbMostrarPerguntas";
            this.cbMostrarPerguntas.Size = new System.Drawing.Size(227, 21);
            this.cbMostrarPerguntas.TabIndex = 100;
            this.cbMostrarPerguntas.SelectedIndexChanged += new System.EventHandler(this.cbMostrarPerguntas_SelectedIndexChanged);
            // 
            // lblMostrarPerguntas
            // 
            this.lblMostrarPerguntas.AutoSize = true;
            this.lblMostrarPerguntas.Location = new System.Drawing.Point(0, 8);
            this.lblMostrarPerguntas.Name = "lblMostrarPerguntas";
            this.lblMostrarPerguntas.Size = new System.Drawing.Size(58, 13);
            this.lblMostrarPerguntas.TabIndex = 101;
            this.lblMostrarPerguntas.Text = "Perguntas:";
            // 
            // panMostrarPerguntas
            // 
            this.panMostrarPerguntas.Controls.Add(this.lblMostrarPerguntas);
            this.panMostrarPerguntas.Controls.Add(this.cbMostrarPerguntas);
            this.panMostrarPerguntas.Location = new System.Drawing.Point(12, 141);
            this.panMostrarPerguntas.Name = "panMostrarPerguntas";
            this.panMostrarPerguntas.Size = new System.Drawing.Size(295, 32);
            this.panMostrarPerguntas.TabIndex = 102;
            // 
            // frmInteracao
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 195);
            this.Controls.Add(this.panMostrarPerguntas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panPergunta);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInteracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInteracao_Load);
            this.panPergunta.ResumeLayout(false);
            this.panPergunta.PerformLayout();
            this.panMostrarPerguntas.ResumeLayout(false);
            this.panMostrarPerguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panPergunta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ComboBox cbMostrarPerguntas;
        private System.Windows.Forms.Label lblMostrarPerguntas;
        private System.Windows.Forms.Panel panMostrarPerguntas;
        private System.Windows.Forms.TextBox txtNovoTema;
    }
}