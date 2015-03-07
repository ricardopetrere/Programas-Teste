namespace ExecuteProcess
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.btnSearchProcess = new System.Windows.Forms.Button();
            this.txtProcessArgument = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Executables|*.exe|All Files|*.*";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(3, 23);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(214, 20);
            this.txtProcessName.TabIndex = 0;
            // 
            // btnSearchProcess
            // 
            this.btnSearchProcess.Location = new System.Drawing.Point(223, 21);
            this.btnSearchProcess.Name = "btnSearchProcess";
            this.btnSearchProcess.Size = new System.Drawing.Size(57, 23);
            this.btnSearchProcess.TabIndex = 1;
            this.btnSearchProcess.Text = "Search";
            this.btnSearchProcess.UseVisualStyleBackColor = true;
            this.btnSearchProcess.Click += new System.EventHandler(this.btnSearchProcess_Click);
            // 
            // txtProcessArgument
            // 
            this.txtProcessArgument.Location = new System.Drawing.Point(3, 62);
            this.txtProcessArgument.Name = "txtProcessArgument";
            this.txtProcessArgument.Size = new System.Drawing.Size(214, 20);
            this.txtProcessArgument.TabIndex = 2;
            this.txtProcessArgument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcessArgument_KeyDown);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(223, 60);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(57, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Process Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arguments (optional):";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 88);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtProcessArgument);
            this.Controls.Add(this.btnSearchProcess);
            this.Controls.Add(this.txtProcessName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Execute Process";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Button btnSearchProcess;
        private System.Windows.Forms.TextBox txtProcessArgument;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

