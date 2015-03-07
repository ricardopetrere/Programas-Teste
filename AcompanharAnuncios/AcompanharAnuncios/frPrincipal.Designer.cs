namespace AcompanharAnuncios
{
    partial class frPrincipal
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Steam");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nuuvem - Versão Normal");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nuuvem - Versão Premium");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Jogo A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeAnuncios = new System.Windows.Forms.TreeView();
            this.contexttreeAnuncios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolCriarNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolApagarNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRenomearNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCriarGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.splitNavegador = new System.Windows.Forms.SplitContainer();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contexttreeAnuncios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitNavegador)).BeginInit();
            this.splitNavegador.Panel1.SuspendLayout();
            this.splitNavegador.Panel2.SuspendLayout();
            this.splitNavegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeAnuncios
            // 
            this.treeAnuncios.AllowDrop = true;
            this.treeAnuncios.ContextMenuStrip = this.contexttreeAnuncios;
            this.treeAnuncios.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeAnuncios.HideSelection = false;
            this.treeAnuncios.LabelEdit = true;
            this.treeAnuncios.Location = new System.Drawing.Point(0, 0);
            this.treeAnuncios.Name = "treeAnuncios";
            treeNode1.Name = "Node1";
            treeNode1.Tag = "http://store.steampowered.com/app/241930/";
            treeNode1.Text = "Steam";
            treeNode2.Name = "Node2";
            treeNode2.Tag = "http://www.nuuvem.com.br/produto/2060-middle-earth-shadow-of-mordor";
            treeNode2.Text = "Nuuvem - Versão Normal";
            treeNode3.Name = "Node3";
            treeNode3.Tag = "http://www.nuuvem.com.br/produto/2372-middle-earth-shadow-of-mordor-premium-editi" +
    "on";
            treeNode3.Text = "Nuuvem - Versão Premium";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Jogo A";
            this.treeAnuncios.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeAnuncios.ShowNodeToolTips = true;
            this.treeAnuncios.Size = new System.Drawing.Size(141, 411);
            this.treeAnuncios.TabIndex = 0;
            this.treeAnuncios.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeAnuncios_AfterLabelEdit);
            this.treeAnuncios.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeAnuncios_AfterSelect);
            this.treeAnuncios.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeAnuncios_NodeMouseClick);
            this.treeAnuncios.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.treeAnuncios_ControlAdded);
            this.treeAnuncios.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.treeAnuncios_ControlRemoved);
            this.treeAnuncios.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.treeAnuncios_QueryContinueDrag);
            this.treeAnuncios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeAnuncios_KeyDown);
            this.treeAnuncios.MouseEnter += new System.EventHandler(this.treeAnuncios_MouseEnter);
            this.treeAnuncios.MouseLeave += new System.EventHandler(this.treeAnuncios_MouseLeave);
            // 
            // contexttreeAnuncios
            // 
            this.contexttreeAnuncios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCriarNodo,
            this.toolApagarNodo,
            this.toolRenomearNodo,
            this.toolCriarGrupo});
            this.contexttreeAnuncios.Name = "contexttreeAnuncios";
            this.contexttreeAnuncios.Size = new System.Drawing.Size(162, 92);
            // 
            // toolCriarNodo
            // 
            this.toolCriarNodo.Name = "toolCriarNodo";
            this.toolCriarNodo.Size = new System.Drawing.Size(161, 22);
            this.toolCriarNodo.Text = "Criar Nodo";
            this.toolCriarNodo.Click += new System.EventHandler(this.toolCriarNodo_Click);
            // 
            // toolApagarNodo
            // 
            this.toolApagarNodo.Name = "toolApagarNodo";
            this.toolApagarNodo.Size = new System.Drawing.Size(161, 22);
            this.toolApagarNodo.Text = "Apagar Nodo";
            this.toolApagarNodo.Click += new System.EventHandler(this.toolApagarNodo_Click);
            // 
            // toolRenomearNodo
            // 
            this.toolRenomearNodo.Name = "toolRenomearNodo";
            this.toolRenomearNodo.Size = new System.Drawing.Size(161, 22);
            this.toolRenomearNodo.Text = "Renomear Nodo";
            this.toolRenomearNodo.Click += new System.EventHandler(this.toolRenomearNodo_Click);
            // 
            // toolCriarGrupo
            // 
            this.toolCriarGrupo.Name = "toolCriarGrupo";
            this.toolCriarGrupo.Size = new System.Drawing.Size(161, 22);
            this.toolCriarGrupo.Text = "Criar Grupo";
            this.toolCriarGrupo.Click += new System.EventHandler(this.toolCriarGrupo_Click);
            // 
            // splitNavegador
            // 
            this.splitNavegador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitNavegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitNavegador.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitNavegador.IsSplitterFixed = true;
            this.splitNavegador.Location = new System.Drawing.Point(144, 0);
            this.splitNavegador.Name = "splitNavegador";
            this.splitNavegador.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitNavegador.Panel1
            // 
            this.splitNavegador.Panel1.Controls.Add(this.btnRemover);
            this.splitNavegador.Panel1.Controls.Add(this.btnAdicionar);
            this.splitNavegador.Panel1.Controls.Add(this.btnIr);
            this.splitNavegador.Panel1.Controls.Add(this.txtUrl);
            // 
            // splitNavegador.Panel2
            // 
            this.splitNavegador.Panel2.Controls.Add(this.webBrowser1);
            this.splitNavegador.Size = new System.Drawing.Size(640, 411);
            this.splitNavegador.SplitterDistance = 40;
            this.splitNavegador.SplitterWidth = 1;
            this.splitNavegador.TabIndex = 1;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(591, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(35, 35);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemover, "Remove a página do grupo atual");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(550, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 35);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "+";
            this.toolTip1.SetToolTip(this.btnAdicionar, "Adiciona a página para o grupo atual");
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnIr
            // 
            this.btnIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIr.Location = new System.Drawing.Point(509, 2);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(35, 35);
            this.btnIr.TabIndex = 1;
            this.btnIr.Text = ">";
            this.toolTip1.SetToolTip(this.btnIr, "Navega até a página desejada");
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(6, 10);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(497, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(638, 368);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(141, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 411);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitNavegador);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeAnuncios);
            this.MinimumSize = new System.Drawing.Size(400, 39);
            this.Name = "frPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acompanhar Anúncios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frPrincipal_Load);
            this.contexttreeAnuncios.ResumeLayout(false);
            this.splitNavegador.Panel1.ResumeLayout(false);
            this.splitNavegador.Panel1.PerformLayout();
            this.splitNavegador.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitNavegador)).EndInit();
            this.splitNavegador.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeAnuncios;
        private System.Windows.Forms.SplitContainer splitNavegador;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contexttreeAnuncios;
        private System.Windows.Forms.ToolStripMenuItem toolRenomearNodo;
        private System.Windows.Forms.ToolStripMenuItem toolApagarNodo;
        private System.Windows.Forms.ToolStripMenuItem toolCriarNodo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem toolCriarGrupo;
    }
}

