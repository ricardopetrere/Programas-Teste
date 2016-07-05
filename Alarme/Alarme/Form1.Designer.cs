namespace Alarme
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextOpcaoFechar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTimer = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbHorario = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAtivar = new System.Windows.Forms.Button();
            this.cbFechar = new System.Windows.Forms.CheckBox();
            this.lblMostraHorarioAlarme = new System.Windows.Forms.Label();
            this.ucGerenciadorTempoTimer = new Alarme.ucGerenciadorTempo();
            this.ucGerenciadorTempoHorario = new Alarme.ucGerenciadorTempo();
            this.ucTempo1 = new Alarme.ucTempo();
            this.cbMinimizar = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextOpcaoFechar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextOpcaoFechar;
            this.notifyIcon1.Text = "Alarme desativado";
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextOpcaoFechar
            // 
            this.contextOpcaoFechar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFechar});
            this.contextOpcaoFechar.Name = "contextOpcaoFechar";
            this.contextOpcaoFechar.Size = new System.Drawing.Size(110, 26);
            // 
            // menuItemFechar
            // 
            this.menuItemFechar.Name = "menuItemFechar";
            this.menuItemFechar.Size = new System.Drawing.Size(109, 22);
            this.menuItemFechar.Text = "Fechar";
            this.menuItemFechar.Click += new System.EventHandler(this.menuItemFechar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora Atual:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbTimer
            // 
            this.rbTimer.AutoSize = true;
            this.rbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTimer.Location = new System.Drawing.Point(12, 135);
            this.rbTimer.Name = "rbTimer";
            this.rbTimer.Size = new System.Drawing.Size(149, 35);
            this.rbTimer.TabIndex = 8;
            this.rbTimer.Text = "Daqui a...";
            this.rbTimer.UseVisualStyleBackColor = true;
            this.rbTimer.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ajustar alarme:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbHorario
            // 
            this.rbHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbHorario.AutoSize = true;
            this.rbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHorario.Location = new System.Drawing.Point(377, 135);
            this.rbHorario.Name = "rbHorario";
            this.rbHorario.Size = new System.Drawing.Size(182, 35);
            this.rbHorario.TabIndex = 11;
            this.rbHorario.Text = "No horário...";
            this.rbHorario.UseVisualStyleBackColor = true;
            this.rbHorario.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivar.Location = new System.Drawing.Point(262, 176);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(109, 70);
            this.btnAtivar.TabIndex = 16;
            this.btnAtivar.Text = "Ativar Alarme";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // cbFechar
            // 
            this.cbFechar.AutoSize = true;
            this.cbFechar.Location = new System.Drawing.Point(407, 35);
            this.cbFechar.Name = "cbFechar";
            this.cbFechar.Size = new System.Drawing.Size(204, 17);
            this.cbFechar.TabIndex = 17;
            this.cbFechar.Text = "Fechar Tela para Área de Notificação";
            this.cbFechar.UseVisualStyleBackColor = true;
            // 
            // lblMostraHorarioAlarme
            // 
            this.lblMostraHorarioAlarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraHorarioAlarme.Location = new System.Drawing.Point(262, 248);
            this.lblMostraHorarioAlarme.Name = "lblMostraHorarioAlarme";
            this.lblMostraHorarioAlarme.Size = new System.Drawing.Size(109, 60);
            this.lblMostraHorarioAlarme.TabIndex = 18;
            this.lblMostraHorarioAlarme.Text = "Alarme ativo para: 23:59:59";
            this.lblMostraHorarioAlarme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMostraHorarioAlarme.Visible = false;
            // 
            // ucGerenciadorTempoTimer
            // 
            this.ucGerenciadorTempoTimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGerenciadorTempoTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucGerenciadorTempoTimer.Horario = System.TimeSpan.Parse("00:00:00");
            this.ucGerenciadorTempoTimer.Location = new System.Drawing.Point(12, 176);
            this.ucGerenciadorTempoTimer.Name = "ucGerenciadorTempoTimer";
            this.ucGerenciadorTempoTimer.Size = new System.Drawing.Size(244, 132);
            this.ucGerenciadorTempoTimer.TabIndex = 19;
            // 
            // ucGerenciadorTempoHorario
            // 
            this.ucGerenciadorTempoHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGerenciadorTempoHorario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGerenciadorTempoHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucGerenciadorTempoHorario.Horario = System.TimeSpan.Parse("23:59:59");
            this.ucGerenciadorTempoHorario.Location = new System.Drawing.Point(377, 176);
            this.ucGerenciadorTempoHorario.Name = "ucGerenciadorTempoHorario";
            this.ucGerenciadorTempoHorario.Size = new System.Drawing.Size(244, 132);
            this.ucGerenciadorTempoHorario.TabIndex = 20;
            // 
            // ucTempo1
            // 
            this.ucTempo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucTempo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTempo1.Enabled = false;
            this.ucTempo1.Horario = System.TimeSpan.Parse("23:59:59");
            this.ucTempo1.Location = new System.Drawing.Point(0, 41);
            this.ucTempo1.Name = "ucTempo1";
            this.ucTempo1.Size = new System.Drawing.Size(246, 38);
            this.ucTempo1.TabIndex = 21;
            // 
            // cbMinimizar
            // 
            this.cbMinimizar.AutoSize = true;
            this.cbMinimizar.Location = new System.Drawing.Point(407, 12);
            this.cbMinimizar.Name = "cbMinimizar";
            this.cbMinimizar.Size = new System.Drawing.Size(214, 17);
            this.cbMinimizar.TabIndex = 17;
            this.cbMinimizar.Text = "Minimizar Tela para Área de Notificação";
            this.cbMinimizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucTempo1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(153, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(248, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 81);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMinimizar);
            this.Controls.Add(this.ucGerenciadorTempoHorario);
            this.Controls.Add(this.ucGerenciadorTempoTimer);
            this.Controls.Add(this.lblMostraHorarioAlarme);
            this.Controls.Add(this.cbFechar);
            this.Controls.Add(this.btnAtivar);
            this.Controls.Add(this.rbHorario);
            this.Controls.Add(this.rbTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextOpcaoFechar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextOpcaoFechar;
        private System.Windows.Forms.ToolStripMenuItem menuItemFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbHorario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.CheckBox cbFechar;
        private System.Windows.Forms.Label lblMostraHorarioAlarme;
        private ucGerenciadorTempo ucGerenciadorTempoTimer;
        private ucGerenciadorTempo ucGerenciadorTempoHorario;
        private ucTempo ucTempo1;
        private System.Windows.Forms.CheckBox cbMinimizar;
        private System.Windows.Forms.Panel panel1;
    }
}

