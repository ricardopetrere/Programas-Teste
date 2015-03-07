namespace Quiz
{
    partial class frmResultado
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.cbEscolherPergunta = new System.Windows.Forms.ComboBox();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblRespostaDada = new System.Windows.Forms.Label();
            this.lblRespostaCorreta = new System.Windows.Forms.Label();
            this.lblTotalPerguntas = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblRespostaUser = new System.Windows.Forms.Label();
            this.lblRespostaPc = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumAcertos = new System.Windows.Forms.Label();
            this.lblNumErros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(12, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(122, 20);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "RESULTADO:";
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEscolherPergunta
            // 
            this.cbEscolherPergunta.FormattingEnabled = true;
            this.cbEscolherPergunta.Location = new System.Drawing.Point(151, 11);
            this.cbEscolherPergunta.Name = "cbEscolherPergunta";
            this.cbEscolherPergunta.Size = new System.Drawing.Size(121, 21);
            this.cbEscolherPergunta.TabIndex = 1;
            this.cbEscolherPergunta.SelectedIndexChanged += new System.EventHandler(this.cbEscolherPergunta_SelectedIndexChanged);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoEllipsis = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(12, 47);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(260, 20);
            this.lblPergunta.TabIndex = 2;
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRespostaDada
            // 
            this.lblRespostaDada.AutoSize = true;
            this.lblRespostaDada.Location = new System.Drawing.Point(12, 80);
            this.lblRespostaDada.Name = "lblRespostaDada";
            this.lblRespostaDada.Size = new System.Drawing.Size(84, 13);
            this.lblRespostaDada.TabIndex = 3;
            this.lblRespostaDada.Text = "Resposta Dada:";
            // 
            // lblRespostaCorreta
            // 
            this.lblRespostaCorreta.AutoSize = true;
            this.lblRespostaCorreta.Location = new System.Drawing.Point(171, 80);
            this.lblRespostaCorreta.Name = "lblRespostaCorreta";
            this.lblRespostaCorreta.Size = new System.Drawing.Size(92, 13);
            this.lblRespostaCorreta.TabIndex = 4;
            this.lblRespostaCorreta.Text = "Resposta Correta:";
            // 
            // lblTotalPerguntas
            // 
            this.lblTotalPerguntas.AutoSize = true;
            this.lblTotalPerguntas.Location = new System.Drawing.Point(12, 140);
            this.lblTotalPerguntas.Name = "lblTotalPerguntas";
            this.lblTotalPerguntas.Size = new System.Drawing.Size(165, 13);
            this.lblTotalPerguntas.TabIndex = 7;
            this.lblTotalPerguntas.Text = "Total de Perguntas Respondidas:";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Location = new System.Drawing.Point(12, 175);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(46, 13);
            this.lblAcertos.TabIndex = 9;
            this.lblAcertos.Text = "Acertos:";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Location = new System.Drawing.Point(12, 220);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(34, 13);
            this.lblErros.TabIndex = 10;
            this.lblErros.Text = "Erros:";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(183, 199);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(89, 51);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Sair do Quiz";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblRespostaUser
            // 
            this.lblRespostaUser.AutoEllipsis = true;
            this.lblRespostaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaUser.Location = new System.Drawing.Point(14, 100);
            this.lblRespostaUser.Name = "lblRespostaUser";
            this.lblRespostaUser.Size = new System.Drawing.Size(126, 20);
            this.lblRespostaUser.TabIndex = 14;
            // 
            // lblRespostaPc
            // 
            this.lblRespostaPc.AutoEllipsis = true;
            this.lblRespostaPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaPc.Location = new System.Drawing.Point(146, 100);
            this.lblRespostaPc.Name = "lblRespostaPc";
            this.lblRespostaPc.Size = new System.Drawing.Size(126, 20);
            this.lblRespostaPc.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(183, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 16;
            // 
            // lblNumAcertos
            // 
            this.lblNumAcertos.AutoSize = true;
            this.lblNumAcertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAcertos.Location = new System.Drawing.Point(64, 175);
            this.lblNumAcertos.Name = "lblNumAcertos";
            this.lblNumAcertos.Size = new System.Drawing.Size(0, 13);
            this.lblNumAcertos.TabIndex = 17;
            // 
            // lblNumErros
            // 
            this.lblNumErros.AutoSize = true;
            this.lblNumErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErros.Location = new System.Drawing.Point(64, 219);
            this.lblNumErros.Name = "lblNumErros";
            this.lblNumErros.Size = new System.Drawing.Size(0, 13);
            this.lblNumErros.TabIndex = 18;
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblNumErros);
            this.Controls.Add(this.lblNumAcertos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRespostaPc);
            this.Controls.Add(this.lblRespostaUser);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.lblTotalPerguntas);
            this.Controls.Add(this.lblRespostaCorreta);
            this.Controls.Add(this.lblRespostaDada);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.cbEscolherPergunta);
            this.Controls.Add(this.lblEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.ComboBox cbEscolherPergunta;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblRespostaDada;
        private System.Windows.Forms.Label lblRespostaCorreta;
        private System.Windows.Forms.Label lblTotalPerguntas;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblRespostaUser;
        private System.Windows.Forms.Label lblRespostaPc;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumAcertos;
        private System.Windows.Forms.Label lblNumErros;
    }
}