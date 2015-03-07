namespace Quiz
{
    partial class frmPrincipal
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
            this.lblTemas = new System.Windows.Forms.Label();
            this.cbTemas = new System.Windows.Forms.ComboBox();
            this.lblQtdeQuestoes = new System.Windows.Forms.Label();
            this.cbQtdeQuestoes = new System.Windows.Forms.ComboBox();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblCarregou = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemas
            // 
            this.lblTemas.AutoSize = true;
            this.lblTemas.Location = new System.Drawing.Point(22, 22);
            this.lblTemas.Name = "lblTemas";
            this.lblTemas.Size = new System.Drawing.Size(42, 13);
            this.lblTemas.TabIndex = 0;
            this.lblTemas.Text = "Temas:";
            // 
            // cbTemas
            // 
            this.cbTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemas.FormattingEnabled = true;
            this.cbTemas.Location = new System.Drawing.Point(121, 19);
            this.cbTemas.MaxDropDownItems = 10;
            this.cbTemas.Name = "cbTemas";
            this.cbTemas.Size = new System.Drawing.Size(121, 21);
            this.cbTemas.TabIndex = 1;
            this.cbTemas.SelectedIndexChanged += new System.EventHandler(this.cbTemas_SelectedIndexChanged);
            // 
            // lblQtdeQuestoes
            // 
            this.lblQtdeQuestoes.AutoSize = true;
            this.lblQtdeQuestoes.Location = new System.Drawing.Point(20, 73);
            this.lblQtdeQuestoes.Name = "lblQtdeQuestoes";
            this.lblQtdeQuestoes.Size = new System.Drawing.Size(95, 13);
            this.lblQtdeQuestoes.TabIndex = 2;
            this.lblQtdeQuestoes.Text = "Total de questões:";
            // 
            // cbQtdeQuestoes
            // 
            this.cbQtdeQuestoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQtdeQuestoes.FormattingEnabled = true;
            this.cbQtdeQuestoes.Location = new System.Drawing.Point(121, 70);
            this.cbQtdeQuestoes.MaxDropDownItems = 100;
            this.cbQtdeQuestoes.Name = "cbQtdeQuestoes";
            this.cbQtdeQuestoes.Size = new System.Drawing.Size(121, 21);
            this.cbQtdeQuestoes.TabIndex = 3;
            // 
            // btnQuiz
            // 
            this.btnQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.Location = new System.Drawing.Point(12, 140);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(127, 30);
            this.btnQuiz.TabIndex = 4;
            this.btnQuiz.Text = "&Começar Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(145, 140);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(127, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCarregou
            // 
            this.lblCarregou.ForeColor = System.Drawing.Color.Red;
            this.lblCarregou.Location = new System.Drawing.Point(12, 122);
            this.lblCarregou.Name = "lblCarregou";
            this.lblCarregou.Size = new System.Drawing.Size(260, 15);
            this.lblCarregou.TabIndex = 6;
            this.lblCarregou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.lblCarregou);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.cbQtdeQuestoes);
            this.Controls.Add(this.lblQtdeQuestoes);
            this.Controls.Add(this.cbTemas);
            this.Controls.Add(this.lblTemas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemas;
        private System.Windows.Forms.ComboBox cbTemas;
        private System.Windows.Forms.Label lblQtdeQuestoes;
        private System.Windows.Forms.ComboBox cbQtdeQuestoes;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCarregou;
    }
}

