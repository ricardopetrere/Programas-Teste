using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ExecuteProcess
{
    /// <summary>
    /// The main form
    /// </summary>
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The path to the process itself (relative or absolute)
        /// </summary>
        string ProcessName;
        /// <summary>
        /// The arguments of the process
        /// </summary>
        string ProcessArguments;
        /// <summary>
        /// Declares if the user intends to run the Command Prompt (CMD)
        /// </summary>
        bool IsCMD = false;
        private void btnSearchProcess_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtProcessName.Text = openFileDialog1.FileName;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ProcessName = txtProcessName.Text.Trim().ToLower();
            ProcessArguments = txtProcessArgument.Text.Trim().ToLower();
            IsCMD = ProcessName.EndsWith("cmd.exe") || (ProcessName.CompareTo("cmd")==0);
            errorProvider1.Clear();
            if (ProcessName != "")
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo
                {
                    FileName = ProcessName.ToLower(),
                    Arguments = ((IsCMD) ? "/c " : "") + ProcessArguments.ToLower(),
                    UseShellExecute = !IsCMD,
                    RedirectStandardOutput = IsCMD
                };
                try
                {
                    p.Start();
                    if (IsCMD)
                        new frResponse(p.StandardOutput.ReadToEnd()).ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                errorProvider1.SetError(btnSearchProcess, "Select a process to execute");
            }
        }

        private void txtProcessArgument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnExecute_Click(sender, e);
        }
    }
}
