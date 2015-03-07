namespace CalculaGanhosPoupanca
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTotalFuturo = new System.Windows.Forms.TabPage();
            this.btnTotalFuturo_Calcular = new System.Windows.Forms.Button();
            this.txtTotalFuturo_Juros = new System.Windows.Forms.TextBox();
            this.txtTotalFuturo_Periodo = new System.Windows.Forms.TextBox();
            this.txtTotalFuturo_Inv_Mensal = new System.Windows.Forms.TextBox();
            this.txtTotalFuturo_Val_Inicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageGastoMensal = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageTotalFuturo.SuspendLayout();
            this.tabPageGastoMensal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTotalFuturo);
            this.tabControl1.Controls.Add(this.tabPageGastoMensal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTotalFuturo
            // 
            this.tabPageTotalFuturo.Controls.Add(this.btnTotalFuturo_Calcular);
            this.tabPageTotalFuturo.Controls.Add(this.txtTotalFuturo_Juros);
            this.tabPageTotalFuturo.Controls.Add(this.txtTotalFuturo_Periodo);
            this.tabPageTotalFuturo.Controls.Add(this.txtTotalFuturo_Inv_Mensal);
            this.tabPageTotalFuturo.Controls.Add(this.txtTotalFuturo_Val_Inicial);
            this.tabPageTotalFuturo.Controls.Add(this.label4);
            this.tabPageTotalFuturo.Controls.Add(this.label3);
            this.tabPageTotalFuturo.Controls.Add(this.label2);
            this.tabPageTotalFuturo.Controls.Add(this.label1);
            this.tabPageTotalFuturo.Location = new System.Drawing.Point(4, 22);
            this.tabPageTotalFuturo.Name = "tabPageTotalFuturo";
            this.tabPageTotalFuturo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTotalFuturo.Size = new System.Drawing.Size(576, 335);
            this.tabPageTotalFuturo.TabIndex = 0;
            this.tabPageTotalFuturo.Text = "Total Futuro (Investimentos Constantes)";
            this.tabPageTotalFuturo.UseVisualStyleBackColor = true;
            // 
            // btnTotalFuturo_Calcular
            // 
            this.btnTotalFuturo_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalFuturo_Calcular.Location = new System.Drawing.Point(468, 7);
            this.btnTotalFuturo_Calcular.Name = "btnTotalFuturo_Calcular";
            this.btnTotalFuturo_Calcular.Size = new System.Drawing.Size(100, 37);
            this.btnTotalFuturo_Calcular.TabIndex = 8;
            this.btnTotalFuturo_Calcular.Text = "&Calcular";
            this.toolTip1.SetToolTip(this.btnTotalFuturo_Calcular, "Calcular (Alt+C)");
            this.btnTotalFuturo_Calcular.UseVisualStyleBackColor = true;
            this.btnTotalFuturo_Calcular.Click += new System.EventHandler(this.btnTotalFuturo_Calcular_Click);
            // 
            // txtTotalFuturo_Juros
            // 
            this.txtTotalFuturo_Juros.Location = new System.Drawing.Point(362, 24);
            this.txtTotalFuturo_Juros.Name = "txtTotalFuturo_Juros";
            this.txtTotalFuturo_Juros.Size = new System.Drawing.Size(88, 20);
            this.txtTotalFuturo_Juros.TabIndex = 7;
            // 
            // txtTotalFuturo_Periodo
            // 
            this.txtTotalFuturo_Periodo.Location = new System.Drawing.Point(260, 24);
            this.txtTotalFuturo_Periodo.Name = "txtTotalFuturo_Periodo";
            this.txtTotalFuturo_Periodo.Size = new System.Drawing.Size(82, 20);
            this.txtTotalFuturo_Periodo.TabIndex = 6;
            // 
            // txtTotalFuturo_Inv_Mensal
            // 
            this.txtTotalFuturo_Inv_Mensal.Location = new System.Drawing.Point(139, 24);
            this.txtTotalFuturo_Inv_Mensal.Name = "txtTotalFuturo_Inv_Mensal";
            this.txtTotalFuturo_Inv_Mensal.Size = new System.Drawing.Size(101, 20);
            this.txtTotalFuturo_Inv_Mensal.TabIndex = 5;
            // 
            // txtTotalFuturo_Val_Inicial
            // 
            this.txtTotalFuturo_Val_Inicial.Location = new System.Drawing.Point(9, 24);
            this.txtTotalFuturo_Val_Inicial.Name = "txtTotalFuturo_Val_Inicial";
            this.txtTotalFuturo_Val_Inicial.Size = new System.Drawing.Size(112, 20);
            this.txtTotalFuturo_Val_Inicial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(359, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Taxa de Juros (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período (Meses)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(136, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Investimento Mensal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Inicial (Opcional)";
            // 
            // tabPageGastoMensal
            // 
            this.tabPageGastoMensal.Controls.Add(this.button1);
            this.tabPageGastoMensal.Controls.Add(this.textBox3);
            this.tabPageGastoMensal.Controls.Add(this.textBox2);
            this.tabPageGastoMensal.Controls.Add(this.groupBox1);
            this.tabPageGastoMensal.Controls.Add(this.label6);
            this.tabPageGastoMensal.Controls.Add(this.label5);
            this.tabPageGastoMensal.Location = new System.Drawing.Point(4, 22);
            this.tabPageGastoMensal.Name = "tabPageGastoMensal";
            this.tabPageGastoMensal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGastoMensal.Size = new System.Drawing.Size(576, 335);
            this.tabPageGastoMensal.TabIndex = 1;
            this.tabPageGastoMensal.Text = "Gasto Mensal Para Atingir Meta";
            this.tabPageGastoMensal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Calcular";
            this.toolTip1.SetToolTip(this.button1, "Calcular (Alt+C)");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(219, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 68);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha uma das opções";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Período";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Location = new System.Drawing.Point(75, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Invest. Mensal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(110, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Taxa de Juros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Meta";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Ganhos da Poupança";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTotalFuturo.ResumeLayout(false);
            this.tabPageTotalFuturo.PerformLayout();
            this.tabPageGastoMensal.ResumeLayout(false);
            this.tabPageGastoMensal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTotalFuturo;
        private System.Windows.Forms.Button btnTotalFuturo_Calcular;
        private System.Windows.Forms.TextBox txtTotalFuturo_Juros;
        private System.Windows.Forms.TextBox txtTotalFuturo_Periodo;
        private System.Windows.Forms.TextBox txtTotalFuturo_Inv_Mensal;
        private System.Windows.Forms.TextBox txtTotalFuturo_Val_Inicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageGastoMensal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;

    }
}

