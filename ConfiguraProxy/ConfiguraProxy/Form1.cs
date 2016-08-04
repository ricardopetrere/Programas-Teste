using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConfiguraProxy
{
    public partial class Form1 : Form
    {
        const String SUBKEY = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        const String PROXYENABLE = "ProxyEnable";
        const String PROXYSERVER = "ProxyServer";
        const char C_DIVISOR = ':';
        public RegistryKey registro;
        String[] server;
        private bool _permiteAlterar;
        public bool PermiteAlterar
        {
            get
            {
                return _permiteAlterar;
            }
            set
            {
                _permiteAlterar = value;
                checkBox1.Enabled = value;
                textBox1.Enabled = value;
                numericUpDown1.Enabled = value;
            }
        }

        private void DesligaEventos()
        {
            //"Desliga" os eventos
            checkBox1.CheckedChanged -= checkBox1_CheckedChanged;
            textBox1.TextChanged -= textBox1_TextChanged;
            numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
        }

        private void LigaEventos()
        {
            //"Religa" os eventos
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }

        void LeDados()
        {
            //registro = Registry.CurrentUser.OpenSubKey(SUBKEY, PermiteAlterar);
            checkBox1.Checked = (int)registro.GetValue(PROXYENABLE) > 0;
            server = registro.GetValue(PROXYSERVER).ToString().Split(C_DIVISOR);
            numericUpDown1.Value = Convert.ToInt16(server[1]);
            textBox1.Text = server[0];
            //registro.Close();
        }

        void GravarRegistro(String chave, object valor, RegistryValueKind tipo)
        {
            if(registro != null)
            {
                registro.SetValue(chave, valor, tipo);
            }
        }

        void GravarProxyServer()
        {
            GravarRegistro(PROXYSERVER, server[0] + C_DIVISOR + server[1], RegistryValueKind.String);
            //registro.SetValue(PROXYSERVER, server[0] + C_DIVISOR + server[1], RegistryValueKind.String);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GravarRegistro(PROXYENABLE, Convert.ToInt16(checkBox1.Checked), RegistryValueKind.DWord);
            //registro.SetValue(PROXYENABLE, Convert.ToInt16(checkBox1.Checked), RegistryValueKind.DWord);
            //Console.WriteLine("CheckedChanged");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //http://stackoverflow.com/questions/197725/programmatically-set-browser-proxy-settings-in-c-sharp
            try
            {
                registro = Registry.CurrentUser.OpenSubKey(SUBKEY, true);
                PermiteAlterar = true;
            }
            catch
            {
                registro = Registry.CurrentUser.OpenSubKey(SUBKEY);
                PermiteAlterar = false;
            }
            DesligaEventos();
            //Leitura inicial. Não ativar eventos
            LeDados();
            LigaEventos();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Feito para o caso do valor do NumericUpDown ter sido digitado, o que mantém o foco no controle e não executa _ValueChanged()
            Focus();

            registro.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LeDados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            server[0] = textBox1.Text;
            GravarProxyServer();
            //Console.WriteLine("TextChanged");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            server[1] = numericUpDown1.Value.ToString();
            GravarProxyServer();
            //Console.WriteLine("ValueChanged");
        }
    }
}
