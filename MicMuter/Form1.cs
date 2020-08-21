using AudioSwitcher.AudioApi.CoreAudio;
using MicMuter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;

namespace MicMuter
{
    public partial class MainWindow : Form
    {

        CoreAudioDevice microphone = new CoreAudioController().DefaultCaptureDevice;
        //List<string[]> settings = new List<string[]>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setProgressBar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitProgramQuestionResult = MessageBox.Show("Really exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exitProgramQuestionResult == DialogResult.No);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                Show();
            }
        }
        private void trayIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }



        private void toggleMuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                microphone.ToggleMute();
                setProgressBar();
            }
            catch (Exception ex) { MessageBox.Show($"The following error occurred when trying to toggle mute.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void setProgressBar()
        {

            if (microphone.IsMuted)
            {
                progressBar.Value = 0;
            } 
            else
            {
                progressBar.Value = Convert.ToInt32(microphone.Volume);
            }

            ToolTip progressBarTooltip = new ToolTip();
            progressBarTooltip.RemoveAll();
            progressBarTooltip.SetToolTip(progressBar, $"{ progressBar.Value}% ");
            progressBarTooltip.InitialDelay = 200;

        }

        private void showOptionsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

    }
}
