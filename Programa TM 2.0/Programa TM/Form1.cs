using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Programa_TM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string LINK_LOGIN_ALUNO = "http://www.centroeducacionalfsa.org.br/cefsa/CEFSA_Aluno/Default.aspx";
        static string LINK_EAD = "http://ead.cefsa.edu.br/ead/";
        static string LINK_CEFSA = "http://cefsa.org.br";
        static string LINK_LOGIN_PROFESSOR = "http://www.centroeducacionalfsa.org.br/cefsa/CEFSA_Professor/Default.aspx";
        static string DOMINIO_CEFSA = "FSASBC";

        enum Config
        {
            LOGIN_AUTOMATICO_PORTAL = 0, USUARIO_AUTOMATICO_PORTAL = 1, SENHA_AUTOMATICO_PORTAL = 2,
            LOGIN_AUTOMATICO_EAD = 3, USUARIO_AUTOMATICO_EAD = 4, SENHA_AUTOMATICO_EAD = 5
        }

        string[] config;

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                splitContainer1.SplitterDistance = splitContainer1.Top + 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
            try
            {
                //http://stackoverflow.com/questions/616584/how-do-i-get-the-name-of-the-current-executable-in-c
                config = File.ReadAllLines(System.AppDomain.CurrentDomain.FriendlyName.Replace("exe", "txt"));
                if (config[(int)Config.USUARIO_AUTOMATICO_PORTAL].Trim().Length == 0
                    || config[(int)Config.SENHA_AUTOMATICO_PORTAL].Trim().Length == 0)
                    config[(int)Config.LOGIN_AUTOMATICO_PORTAL] = "0";
                if (config[(int)Config.USUARIO_AUTOMATICO_EAD].Trim().Length == 0
                    || config[(int)Config.SENHA_AUTOMATICO_EAD].Trim().Length == 0)
                    config[(int)Config.LOGIN_AUTOMATICO_EAD] = "0";
            }
            catch
            { }
        }

        private void lblPortal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((sender as LinkLabel).Name == "lblPortal")
            {
                if (Environment.UserName.StartsWith("pro"))
                    webBrowser1.Navigate(LINK_LOGIN_PROFESSOR);
                else
                    webBrowser1.Navigate(LINK_LOGIN_ALUNO);
            }
            else if ((sender as LinkLabel).Name == "lblEAD")
            {
                webBrowser1.Navigate(LINK_EAD);
            }
            else if ((sender as LinkLabel).Name == "lblCEFSA")
            {
                webBrowser1.Navigate(LINK_CEFSA);
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {//"javascript:__doPostBack('ctl00$BtLogOut','')"
            if (e.Url.ToString() == "javascript:__doPostBack('ctl00$BtLogOut','')")
                e.Cancel = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {//http://www.vbdotnetforums.com/windows-forms/52832-how-auto-login-using-webbrowser-control.html
            if (e.Url.AbsoluteUri == "http://www.centroeducacionalfsa.org.br/cefsa/CEFSA_Aluno/Default.aspx")
            {
                webBrowser1.Document.GetElementById("ctl00_BtLogOut").Enabled = false;
            }
            else if (e.Url.AbsoluteUri == LINK_EAD + "login/index.php")
            {
                webBrowser1.Document.GetElementById("username").SetAttribute("value", (Environment.UserDomainName == DOMINIO_CEFSA ? (Environment.UserName.StartsWith("0") ? Environment.UserName.Substring(1) : Environment.UserName.Replace("pro", "")) : Environment.UserName));
                if (config[(int)Config.LOGIN_AUTOMATICO_EAD] == "1")
                {
                    webBrowser1.Document.GetElementById("username").SetAttribute("value", config[(int)Config.USUARIO_AUTOMATICO_EAD]);
                    webBrowser1.Document.GetElementById("password").SetAttribute("value", config[(int)Config.SENHA_AUTOMATICO_EAD]);
                    webBrowser1.Document.GetElementById("loginbtn").InvokeMember("click");
                    splitContainer1.Panel2.Enabled = false;
                }
            }
            else if (e.Url.AbsoluteUri == LINK_LOGIN_ALUNO.Replace("Default", "Login") + e.Url.Query ||
                e.Url.AbsoluteUri == LINK_LOGIN_PROFESSOR.Replace("Default", "Login") + e.Url.Query)
            {
                webBrowser1.Document.GetElementById("txtRA").SetAttribute("value", (Environment.UserDomainName == DOMINIO_CEFSA ? Environment.UserName.Replace("pro", "") : Environment.UserName));
                if (config[(int)Config.LOGIN_AUTOMATICO_PORTAL] == "1")
                {
                    webBrowser1.Document.GetElementById("txtRA").SetAttribute("value", config[(int)Config.USUARIO_AUTOMATICO_PORTAL]);
                    webBrowser1.Document.GetElementById("txtSenha").SetAttribute("value", config[(int)Config.SENHA_AUTOMATICO_PORTAL]);
                    webBrowser1.Document.GetElementById("BTSend").InvokeMember("click");
                    splitContainer1.Panel2.Enabled = false;
                }
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por:\nRicardo Petrére\nRA: 031125940");
        }
    }
}