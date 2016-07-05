using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alarme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = Properties.Resources.icone;
            rbTimer.Checked = true;
            timer1.Start();
            timer1_Tick(this, new EventArgs());
            ucGerenciadorTempoHorario.Horario = DateTime.Now.TimeOfDay;
        }
        TimeSpan t_agora;
        TimeSpan t_alarme;
        bool MinimizarParaIcone
        {
            get
            {
                return cbMinimizar.Checked;
            }
        }
        bool FecharParaIcone
        {
            get
            {
                return cbFechar.Checked;
            }
        }
        bool _alarmeAtivo = false;
        bool AlarmeAtivo
        {
            get
            {
                return _alarmeAtivo;
            }
            set
            {
                _alarmeAtivo = value;
                btnAtivar.Text = (_alarmeAtivo) ? "Cancelar alarme" : "Ativar Alarme";
                lblMostraHorarioAlarme.Visible = _alarmeAtivo;
                rbTimer.Enabled = !_alarmeAtivo;
                rbHorario.Enabled = !_alarmeAtivo;
                if (rbTimer.Checked)
                    ucGerenciadorTempoTimer.Enabled = !_alarmeAtivo;
                if (rbHorario.Checked)
                    ucGerenciadorTempoHorario.Enabled = !_alarmeAtivo;
            }
        }
        void MostrarNotifyIcon()
        {
            notifyIcon1.Visible = true;
            if (AlarmeAtivo)
            {
                notifyIcon1.ShowBalloonTip(5000, "", $"Alarme acionado para: {t_alarme.ToString()}", ToolTipIcon.None);
                notifyIcon1.Text = $"Alarme ativo para: {t_alarme.ToString()}";
            }
            else
            {
                notifyIcon1.ShowBalloonTip(5000, "", "Programa minimizado", ToolTipIcon.None);
                notifyIcon1.Text = "Alarme desativado";
            }
            Hide();
        }
        void MostrarJanela()
        {
            Show();
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t_agora = DateTime.ParseExact(DateTime.Now.ToLongTimeString(), "HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture).TimeOfDay;
            ucTempo1.Horario = t_agora;
            if (AlarmeAtivo)
            {
                if (TimeSpan.Compare(t_agora, t_alarme) == 0)
                {
                    notifyIcon1.ShowBalloonTip(10000, "", "Alarme atingido!", ToolTipIcon.Info);
                    //new System.Media.SoundPlayer(@"c:\Windows\Media\chimes.wav").Play();
                    System.Media.SystemSounds.Asterisk.Play();
                    AlarmeAtivo = false;
                }
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            ucGerenciadorTempoTimer.Enabled = rbTimer.Checked;
            ucGerenciadorTempoHorario.Enabled = rbHorario.Checked;
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (!AlarmeAtivo)
            {
                if (rbTimer.Checked)
                {
                    t_alarme = t_agora.Add(ucGerenciadorTempoTimer.Horario);
                }
                else
                {
                    t_alarme = ucGerenciadorTempoHorario.Horario;
                }
                if (TimeSpan.Compare(t_alarme, t_agora) <= 0)
                {
                    MessageBox.Show("Não é possível assinalar tal horário");
                    return;
                }

                AlarmeAtivo = true;
                lblMostraHorarioAlarme.Text = $"Alarme ativo para: {t_alarme.ToString()}";
                if (FecharParaIcone)
                {
                    MostrarNotifyIcon();
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja parar o alarme?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AlarmeAtivo = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FecharParaIcone)
            {
                if (!notifyIcon1.Visible)
                {
                    e.Cancel = true;
                    MostrarNotifyIcon();
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja fechar a aplicação?", "Atenção", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                MostrarJanela();
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarJanela();
            notifyIcon1.Visible = false;
        }

        private void menuItemFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (MinimizarParaIcone && WindowState == FormWindowState.Minimized)
            {
                MostrarNotifyIcon();
            }
        }
    }
}
