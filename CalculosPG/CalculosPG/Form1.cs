using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculosPG
{
    public partial class Form1 : Form
    {
        public Form1(String[] args)
        {
            InitializeComponent();
            if (args.Length > 0)
            {
                txtPrimeiroTermo.Text = args[0];
            }
            if (args.Length > 1)
            {
                txtRazao.Text = args[1];
            }
            if (args.Length == 3)
            {
                txtQuantidadeTermos.Text = args[2];
                CalcularPG();
            }
        }

        void CriarAtalho(String nomearquivo)
        {
            //http://stackoverflow.com/questions/1501608/how-do-you-create-an-application-shortcut-lnk-file-in-c-sharp-with-command-li
            //WshShell wsh = new WshShell();
            //IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(
            //    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\shorcut.lnk") as IWshRuntimeLibrary.IWshShortcut;
            //shortcut.Arguments = "c:\\app\\settings1.xml";
            //shortcut.TargetPath = "c:\\app\\myftp.exe";
            //// not sure about what this is for
            //shortcut.WindowStyle = 1;
            //shortcut.Description = "my shortcut description";
            //shortcut.WorkingDirectory = "c:\\app";
            //shortcut.IconLocation = "specify icon location";
            //shortcut.Save();
            WshShell wsh = new WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = wsh.CreateShortcut(nomearquivo) as IWshRuntimeLibrary.IWshShortcut;
            shortcut.Arguments = string.Format("{0} {1} {2}", txtPrimeiroTermo.Text, txtRazao.Text, txtQuantidadeTermos.Text);
            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WindowStyle = 1;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Save();
        }

        void CalcularPG()
        {
            /*
             * Fórmula:
             * 
             * Sn = a*(q^n - 1)/(q-1),
             * onde a = termo inicial, q = razão, n = nº de termos
             */
            double sn = 0;
            double a = 0;
            double q = 0;
            int n = 0;
            bool valido = true;
            if (!double.TryParse(txtPrimeiroTermo.Text, out a))
            {
                valido = false;
            }
            if (!double.TryParse(txtRazao.Text, out q))
            {
                valido = false;
            }
            if (!int.TryParse(txtQuantidadeTermos.Text, out n))
            {
                valido = false;
            }
            if (valido)
            {
                //Existe um cenário de exceção, onde q = 1, em que a conta original daria 0/0, quando deveria dar a*n
                if (q == 1)
                {
                    sn = a * n;
                }
                else
                {
                    sn = a * ((Math.Pow(q, n) - 1) / (q - 1));
                }
                txtResultado.Text = string.Format("{0:n3}", sn);
                //txtResultado.Text = sn.ToString();
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPG();
        }

        private void PressionarEnter(object sender, KeyEventArgs e)
        {
            if (sender == txtQuantidadeTermos)
            {
                if (e.KeyCode == Keys.Up)
                {
                    int n = 0;
                    if (int.TryParse(txtQuantidadeTermos.Text, out n))
                    {
                        n++;
                        txtQuantidadeTermos.Text = n.ToString();
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    int n = 0;
                    if (int.TryParse(txtQuantidadeTermos.Text, out n))
                    {
                        if (n > 0)
                            n--;
                        txtQuantidadeTermos.Text = n.ToString();
                    }
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                CalcularPG();
            }
        }

        private void btnCriarAtalho_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                CriarAtalho(saveFileDialog1.FileName);
            }
        }
    }
}
