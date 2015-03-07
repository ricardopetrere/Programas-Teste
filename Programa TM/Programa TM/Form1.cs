using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programa_TM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool login = false;
        bool portal = false;
        string[] links = { "http://www.centroeducacionalfsa.org.br/cefsa/CEFSA_Aluno/Default.aspx", "cefsa.org.br", "Acessar CEFSA", "Acessar Portal" };

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                splitContainer1.SplitterDistance = splitContainer1.Top + 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int index = Convert.ToInt16(portal);
            webBrowser1.Navigate(links[index]);
            linkLabel1.Text = links[index + 2];
            portal = !portal;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {//"javascript:__doPostBack('ctl00$BtLogOut','')"
            if (e.Url.ToString() == "javascript:__doPostBack('ctl00$BtLogOut','')")
                Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {//http://www.vbdotnetforums.com/windows-forms/52832-how-auto-login-using-webbrowser-control.html
            if (!login)
            {
                login = true;
                portal = true;
                webBrowser1.Document.GetElementById("txtRA").SetAttribute("value", Environment.UserName);
                //webBrowser1.Document.GetElementById("txtSenha").SetAttribute("value", "");
                //webBrowser1.Document.GetElementById("BTSend").InvokeMember("click");
                //splitContainer1.Panel2.Enabled = false;
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
