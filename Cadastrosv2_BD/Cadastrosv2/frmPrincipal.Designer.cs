namespace Cadastrosv2
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
            this.components = new System.ComponentModel.Container();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblEscolhaCadastro = new System.Windows.Forms.Label();
            this.cbEscolhaCadastro = new System.Windows.Forms.ComboBox();
            this.panEscolhaCadastro = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTel3 = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.lblTel3 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panCadastro = new System.Windows.Forms.Panel();
            this.txtDescTel3 = new System.Windows.Forms.TextBox();
            this.txtDescTel2 = new System.Windows.Forms.TextBox();
            this.txtDescTel1 = new System.Windows.Forms.TextBox();
            this.panOpcoes = new System.Windows.Forms.Panel();
            this.panSalvar = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panEscolhaCadastro.SuspendLayout();
            this.panCadastro.SuspendLayout();
            this.panOpcoes.SuspendLayout();
            this.panSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 50);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "&Adicionar Cadastro";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(0, 56);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 50);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "&Remover Cadastro";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(0, 112);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "&Editar Cadastro";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(0, 168);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(80, 50);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "&Selecionar Cadastro";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblEscolhaCadastro
            // 
            this.lblEscolhaCadastro.AutoSize = true;
            this.lblEscolhaCadastro.Location = new System.Drawing.Point(3, 8);
            this.lblEscolhaCadastro.Name = "lblEscolhaCadastro";
            this.lblEscolhaCadastro.Size = new System.Drawing.Size(161, 13);
            this.lblEscolhaCadastro.TabIndex = 5;
            this.lblEscolhaCadastro.Text = "Escolha entre um dos cadastros:";
            // 
            // cbEscolhaCadastro
            // 
            this.cbEscolhaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolhaCadastro.FormattingEnabled = true;
            this.cbEscolhaCadastro.Location = new System.Drawing.Point(170, 5);
            this.cbEscolhaCadastro.Name = "cbEscolhaCadastro";
            this.cbEscolhaCadastro.Size = new System.Drawing.Size(151, 21);
            this.cbEscolhaCadastro.TabIndex = 6;
            this.cbEscolhaCadastro.SelectionChangeCommitted += new System.EventHandler(this.cbEscolhaCadastro_SelectionChangeCommitted);
            // 
            // panEscolhaCadastro
            // 
            this.panEscolhaCadastro.Controls.Add(this.lblEscolhaCadastro);
            this.panEscolhaCadastro.Controls.Add(this.cbEscolhaCadastro);
            this.panEscolhaCadastro.Location = new System.Drawing.Point(29, 238);
            this.panEscolhaCadastro.Name = "panEscolhaCadastro";
            this.panEscolhaCadastro.Size = new System.Drawing.Size(356, 30);
            this.panEscolhaCadastro.TabIndex = 27;
            this.panEscolhaCadastro.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(108, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTel3
            // 
            this.txtTel3.Location = new System.Drawing.Point(219, 172);
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Size = new System.Drawing.Size(102, 20);
            this.txtTel3.TabIndex = 17;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(111, 172);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(102, 20);
            this.txtTel2.TabIndex = 15;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(3, 172);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(102, 20);
            this.txtTel1.TabIndex = 13;
            // 
            // lblTel3
            // 
            this.lblTel3.AutoSize = true;
            this.lblTel3.Location = new System.Drawing.Point(216, 143);
            this.lblTel3.Name = "lblTel3";
            this.lblTel3.Size = new System.Drawing.Size(34, 13);
            this.lblTel3.TabIndex = 59;
            this.lblTel3.Text = "Tel 3:";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(108, 143);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(34, 13);
            this.lblTel2.TabIndex = 58;
            this.lblTel2.Text = "Tel 2:";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(3, 143);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(34, 13);
            this.lblTel1.TabIndex = 57;
            this.lblTel1.Text = "Tel 1:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(53, 100);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(268, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(4, 103);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 55;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(65, 70);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(256, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(3, 73);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 53;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(111, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(42, 33);
            this.txtData.Mask = "00/00/00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(63, 20);
            this.txtData.TabIndex = 8;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 36);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 49;
            this.lblData.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "Nome:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panCadastro
            // 
            this.panCadastro.Controls.Add(this.txtDescTel3);
            this.panCadastro.Controls.Add(this.txtDescTel2);
            this.panCadastro.Controls.Add(this.txtDescTel1);
            this.panCadastro.Controls.Add(this.lblNome);
            this.panCadastro.Controls.Add(this.txtNome);
            this.panCadastro.Controls.Add(this.lblData);
            this.panCadastro.Controls.Add(this.txtData);
            this.panCadastro.Controls.Add(this.lblEmail);
            this.panCadastro.Controls.Add(this.txtEmail);
            this.panCadastro.Controls.Add(this.txtTel3);
            this.panCadastro.Controls.Add(this.lblEndereco);
            this.panCadastro.Controls.Add(this.txtTel2);
            this.panCadastro.Controls.Add(this.txtEndereco);
            this.panCadastro.Controls.Add(this.txtTel1);
            this.panCadastro.Controls.Add(this.lblCidade);
            this.panCadastro.Controls.Add(this.lblTel3);
            this.panCadastro.Controls.Add(this.txtCidade);
            this.panCadastro.Controls.Add(this.lblTel2);
            this.panCadastro.Controls.Add(this.lblTel1);
            this.panCadastro.Location = new System.Drawing.Point(29, 12);
            this.panCadastro.Name = "panCadastro";
            this.panCadastro.Size = new System.Drawing.Size(327, 195);
            this.panCadastro.TabIndex = 68;
            this.panCadastro.Visible = false;
            // 
            // txtDescTel3
            // 
            this.txtDescTel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescTel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescTel3.Location = new System.Drawing.Point(253, 141);
            this.txtDescTel3.Name = "txtDescTel3";
            this.txtDescTel3.Size = new System.Drawing.Size(68, 20);
            this.txtDescTel3.TabIndex = 16;
            // 
            // txtDescTel2
            // 
            this.txtDescTel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescTel2.Location = new System.Drawing.Point(145, 141);
            this.txtDescTel2.Name = "txtDescTel2";
            this.txtDescTel2.Size = new System.Drawing.Size(68, 20);
            this.txtDescTel2.TabIndex = 14;
            // 
            // txtDescTel1
            // 
            this.txtDescTel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescTel1.Location = new System.Drawing.Point(40, 141);
            this.txtDescTel1.Name = "txtDescTel1";
            this.txtDescTel1.Size = new System.Drawing.Size(65, 20);
            this.txtDescTel1.TabIndex = 12;
            // 
            // panOpcoes
            // 
            this.panOpcoes.Controls.Add(this.btnAdicionar);
            this.panOpcoes.Controls.Add(this.btnRemover);
            this.panOpcoes.Controls.Add(this.btnSelecionar);
            this.panOpcoes.Controls.Add(this.btnEditar);
            this.panOpcoes.Location = new System.Drawing.Point(362, 19);
            this.panOpcoes.Name = "panOpcoes";
            this.panOpcoes.Size = new System.Drawing.Size(80, 218);
            this.panOpcoes.TabIndex = 69;
            // 
            // panSalvar
            // 
            this.panSalvar.Controls.Add(this.btnCancelar);
            this.panSalvar.Controls.Add(this.btnSalvar);
            this.panSalvar.Location = new System.Drawing.Point(140, 210);
            this.panSalvar.Name = "panSalvar";
            this.panSalvar.Size = new System.Drawing.Size(210, 23);
            this.panSalvar.TabIndex = 70;
            this.panSalvar.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 292);
            this.Controls.Add(this.panSalvar);
            this.Controls.Add(this.panOpcoes);
            this.Controls.Add(this.panCadastro);
            this.Controls.Add(this.panEscolhaCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panEscolhaCadastro.ResumeLayout(false);
            this.panEscolhaCadastro.PerformLayout();
            this.panCadastro.ResumeLayout(false);
            this.panCadastro.PerformLayout();
            this.panOpcoes.ResumeLayout(false);
            this.panSalvar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblEscolhaCadastro;
        private System.Windows.Forms.ComboBox cbEscolhaCadastro;
        private System.Windows.Forms.Panel panEscolhaCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtTel3;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label lblTel3;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panCadastro;
        private System.Windows.Forms.Panel panOpcoes;
        private System.Windows.Forms.Panel panSalvar;
        private System.Windows.Forms.TextBox txtDescTel3;
        private System.Windows.Forms.TextBox txtDescTel2;
        private System.Windows.Forms.TextBox txtDescTel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}