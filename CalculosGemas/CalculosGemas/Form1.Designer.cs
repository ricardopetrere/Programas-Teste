namespace CalculosGemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbB2 = new System.Windows.Forms.RadioButton();
            this.rbG2 = new System.Windows.Forms.RadioButton();
            this.rbB1 = new System.Windows.Forms.RadioButton();
            this.rbC2 = new System.Windows.Forms.RadioButton();
            this.rbG1 = new System.Windows.Forms.RadioButton();
            this.rbN2 = new System.Windows.Forms.RadioButton();
            this.rbC1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbN1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Gema = new System.Windows.Forms.MaskedTextBox();
            this.btn_Gema = new System.Windows.Forms.Button();
            this.lbl_Gema = new System.Windows.Forms.Label();
            this.rbEscolhaManual = new System.Windows.Forms.RadioButton();
            this.rbEscolhaAutomatica = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "g:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "b:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbB2);
            this.groupBox1.Controls.Add(this.rbG2);
            this.groupBox1.Controls.Add(this.rbB1);
            this.groupBox1.Controls.Add(this.rbC2);
            this.groupBox1.Controls.Add(this.rbG1);
            this.groupBox1.Controls.Add(this.rbN2);
            this.groupBox1.Controls.Add(this.rbC1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbN1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular:";
            // 
            // rbB2
            // 
            this.rbB2.AutoSize = true;
            this.rbB2.Location = new System.Drawing.Point(246, 56);
            this.rbB2.Name = "rbB2";
            this.rbB2.Size = new System.Drawing.Size(70, 17);
            this.rbB2.TabIndex = 7;
            this.rbB2.Tag = "7";
            this.rbB2.Text = "Método 2";
            this.rbB2.UseVisualStyleBackColor = true;
            this.rbB2.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // rbG2
            // 
            this.rbG2.AutoSize = true;
            this.rbG2.Location = new System.Drawing.Point(167, 56);
            this.rbG2.Name = "rbG2";
            this.rbG2.Size = new System.Drawing.Size(70, 17);
            this.rbG2.TabIndex = 5;
            this.rbG2.Tag = "5";
            this.rbG2.Text = "Método 2";
            this.rbG2.UseVisualStyleBackColor = true;
            this.rbG2.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // rbB1
            // 
            this.rbB1.AutoSize = true;
            this.rbB1.Location = new System.Drawing.Point(246, 32);
            this.rbB1.Name = "rbB1";
            this.rbB1.Size = new System.Drawing.Size(70, 17);
            this.rbB1.TabIndex = 6;
            this.rbB1.Tag = "6";
            this.rbB1.Text = "Método 1";
            this.rbB1.UseVisualStyleBackColor = true;
            this.rbB1.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // rbC2
            // 
            this.rbC2.AutoSize = true;
            this.rbC2.Location = new System.Drawing.Point(88, 56);
            this.rbC2.Name = "rbC2";
            this.rbC2.Size = new System.Drawing.Size(70, 17);
            this.rbC2.TabIndex = 3;
            this.rbC2.Tag = "3";
            this.rbC2.Text = "Método 2";
            this.rbC2.UseVisualStyleBackColor = true;
            this.rbC2.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // rbG1
            // 
            this.rbG1.AutoSize = true;
            this.rbG1.Location = new System.Drawing.Point(167, 32);
            this.rbG1.Name = "rbG1";
            this.rbG1.Size = new System.Drawing.Size(70, 17);
            this.rbG1.TabIndex = 4;
            this.rbG1.Tag = "4";
            this.rbG1.Text = "Método 1";
            this.rbG1.UseVisualStyleBackColor = true;
            this.rbG1.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // rbN2
            // 
            this.rbN2.AutoSize = true;
            this.rbN2.Location = new System.Drawing.Point(9, 56);
            this.rbN2.Name = "rbN2";
            this.rbN2.Size = new System.Drawing.Size(70, 17);
            this.rbN2.TabIndex = 1;
            this.rbN2.Tag = "1";
            this.rbN2.Text = "Método 2";
            this.rbN2.UseVisualStyleBackColor = true;
            this.rbN2.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // rbC1
            // 
            this.rbC1.AutoSize = true;
            this.rbC1.Location = new System.Drawing.Point(88, 32);
            this.rbC1.Name = "rbC1";
            this.rbC1.Size = new System.Drawing.Size(70, 17);
            this.rbC1.TabIndex = 2;
            this.rbC1.Tag = "2";
            this.rbC1.Text = "Método 1";
            this.rbC1.UseVisualStyleBackColor = true;
            this.rbC1.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "b:";
            // 
            // rbN1
            // 
            this.rbN1.AutoSize = true;
            this.rbN1.Checked = true;
            this.rbN1.Location = new System.Drawing.Point(9, 32);
            this.rbN1.Name = "rbN1";
            this.rbN1.Size = new System.Drawing.Size(70, 17);
            this.rbN1.TabIndex = 0;
            this.rbN1.TabStop = true;
            this.rbN1.Tag = "0";
            this.rbN1.Text = "Método 1";
            this.rbN1.UseVisualStyleBackColor = true;
            this.rbN1.CheckedChanged += new System.EventHandler(this.rbN1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "g:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "c:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(12, 265);
            this.txtN.MaxLength = 5;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(40, 20);
            this.txtN.TabIndex = 10;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(58, 265);
            this.txtC.MaxLength = 5;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(40, 20);
            this.txtC.TabIndex = 11;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(104, 265);
            this.txtG.MaxLength = 5;
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(40, 20);
            this.txtG.TabIndex = 12;
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(150, 265);
            this.txtB.MaxLength = 5;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(40, 20);
            this.txtB.TabIndex = 13;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 291);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(178, 56);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Preço:";
            // 
            // txt_Gema
            // 
            this.txt_Gema.Location = new System.Drawing.Point(196, 306);
            this.txt_Gema.Mask = "0.00";
            this.txt_Gema.Name = "txt_Gema";
            this.txt_Gema.Size = new System.Drawing.Size(40, 20);
            this.txt_Gema.TabIndex = 22;
            this.txt_Gema.TabStop = false;
            // 
            // btn_Gema
            // 
            this.btn_Gema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gema.Location = new System.Drawing.Point(242, 249);
            this.btn_Gema.Name = "btn_Gema";
            this.btn_Gema.Size = new System.Drawing.Size(95, 77);
            this.btn_Gema.TabIndex = 23;
            this.btn_Gema.TabStop = false;
            this.btn_Gema.Text = "$/1000 gemas";
            this.btn_Gema.UseVisualStyleBackColor = true;
            this.btn_Gema.Click += new System.EventHandler(this.btn_Gema_Click);
            // 
            // lbl_Gema
            // 
            this.lbl_Gema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Gema.Location = new System.Drawing.Point(196, 329);
            this.lbl_Gema.Name = "lbl_Gema";
            this.lbl_Gema.Size = new System.Drawing.Size(141, 18);
            this.lbl_Gema.TabIndex = 24;
            // 
            // rbEscolhaManual
            // 
            this.rbEscolhaManual.AutoSize = true;
            this.rbEscolhaManual.Checked = true;
            this.rbEscolhaManual.Location = new System.Drawing.Point(12, 149);
            this.rbEscolhaManual.Name = "rbEscolhaManual";
            this.rbEscolhaManual.Size = new System.Drawing.Size(103, 17);
            this.rbEscolhaManual.TabIndex = 26;
            this.rbEscolhaManual.TabStop = true;
            this.rbEscolhaManual.Text = "Escolher cálculo";
            this.rbEscolhaManual.UseVisualStyleBackColor = true;
            this.rbEscolhaManual.CheckedChanged += new System.EventHandler(this.rbEscolhaManual_CheckedChanged);
            // 
            // rbEscolhaAutomatica
            // 
            this.rbEscolhaAutomatica.AutoSize = true;
            this.rbEscolhaAutomatica.Location = new System.Drawing.Point(168, 149);
            this.rbEscolhaAutomatica.Name = "rbEscolhaAutomatica";
            this.rbEscolhaAutomatica.Size = new System.Drawing.Size(118, 17);
            this.rbEscolhaAutomatica.TabIndex = 27;
            this.rbEscolhaAutomatica.Text = "Escolha automática";
            this.rbEscolhaAutomatica.UseVisualStyleBackColor = true;
            this.rbEscolhaAutomatica.CheckedChanged += new System.EventHandler(this.rbEscolhaManual_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Gemas:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(196, 265);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(40, 20);
            this.txtQtd.TabIndex = 29;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 354);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbEscolhaAutomatica);
            this.Controls.Add(this.rbEscolhaManual);
            this.Controls.Add(this.lbl_Gema);
            this.Controls.Add(this.btn_Gema);
            this.Controls.Add(this.txt_Gema);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculos de custos de gemas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbB2;
        private System.Windows.Forms.RadioButton rbG2;
        private System.Windows.Forms.RadioButton rbB1;
        private System.Windows.Forms.RadioButton rbC2;
        private System.Windows.Forms.RadioButton rbG1;
        private System.Windows.Forms.RadioButton rbN2;
        private System.Windows.Forms.RadioButton rbC1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbN1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_Gema;
        private System.Windows.Forms.Button btn_Gema;
        private System.Windows.Forms.Label lbl_Gema;
        private System.Windows.Forms.RadioButton rbEscolhaManual;
        private System.Windows.Forms.RadioButton rbEscolhaAutomatica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQtd;
    }
}

