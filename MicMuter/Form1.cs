using AudioSwitcher.AudioApi.CoreAudio;
using Gma.System.MouseKeyHook;
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
using System.Windows.Input;
using Microsoft.Win32;

namespace MicMuter
{
    public partial class MainWindow : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;
        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            //m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            //m_GlobalHook.KeyPress += GlobalHookKeyPress;

            Action toggleMuteAction = () => { toggleMuteButton_Click(null, null); };
            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action> { { keybind, toggleMuteAction } });
            currectKeybindLabel.Text = $"Keybind: {keybind}";
        }

        CoreAudioDevice microphone = new CoreAudioController().DefaultCaptureDevice;
        System.Media.SoundPlayer muteSound = new System.Media.SoundPlayer(@"c:\Windows\Media\Speech Sleep.wav");
        System.Media.SoundPlayer unmuteSound = new System.Media.SoundPlayer(@"c:\Windows\Media\Speech On.wav");

        Combination keybind = Combination.FromString(Settings.Default.Keybind);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //KeyGesture CloseCmdKeyGesture = new KeyGesture(Keys.Control, Keys.Oem5);

            if (Settings.Default.FirstTime)
            {
                MessageBox.Show("By default, the keybind to toggle mute is set to Ctrl+Alt+Backslash (shown as ControlKey+Menu+Oem5). This can be changed in the options menu.\n\nYou can also toggle mute by click on the tray icon.", "Mic Muter");
                Settings.Default.FirstTime = false;
                Settings.Default.Save();
                Thread.Sleep(200);
            }
            try
            {
                setOptions();
                setProgressBar();
                setTrayIcon();
                Subscribe(); // keyboard hook
                this.Height = 191;
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"The following error occured during initialization. \n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.StartMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Settings.Default.DontShowExitDialog && !SetKeybindWindow.tempDontUseExitDialog)
            {
                DialogResult exitProgramQuestionResult = MessageBox.Show("Really exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = (exitProgramQuestionResult == DialogResult.No);
            }
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

        private void toggleMuteButton_Click(object sender, EventArgs e)
        {

            try
            {
                microphone.ToggleMute();
                setProgressBar();
                setTrayIcon();
            }
            catch (Exception ex) { MessageBox.Show($"The following error occurred when trying to toggle mute.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try
            {
                if (microphone.IsMuted && Settings.Default.PlaySound) { muteSound.Play(); } 
                else if (!microphone.IsMuted && Settings.Default.PlaySound) { unmuteSound.Play(); }
            }
            catch (Exception ex) { MessageBox.Show($"The following error occurred when trying to play a sound file.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
        
        private void setTrayIcon()
        {
            if (microphone.IsMuted)
            {
                trayIcon.Icon = Properties.Resources.trayiconMute;
            }
            else
            {
                trayIcon.Icon = Properties.Resources.trayicon;
            }
        }

        private void showOptionsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showOptionsCheckbox.Checked)
            {
                this.Height = 349;
            }
            else
            {
                this.Height = 191;
            }
        }

        private void setOptions()
        {
            optionsMenu.SetItemChecked(0, Settings.Default.StartMinimized);
            optionsMenu.SetItemChecked(1, Settings.Default.DontShowExitDialog);
            optionsMenu.SetItemChecked(2, Settings.Default.PlaySound);
            optionsMenu.SetItemChecked(3, Settings.Default.RunOnStartup);
        }

        private void optionsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.StartMinimized = optionsMenu.GetItemChecked(0);
            Settings.Default.DontShowExitDialog = optionsMenu.GetItemChecked(1);
            Settings.Default.PlaySound = optionsMenu.GetItemChecked(2);
            Settings.Default.RunOnStartup = optionsMenu.GetItemChecked(3);

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (Settings.Default.RunOnStartup)
            {
                rk.SetValue("MicMuter", Application.ExecutablePath);
            }
            else
            {
                rk.DeleteValue("MicMuter", false);
            }

            Settings.Default.Save();
        }

        private void trayIconMenu_Opening(object sender, CancelEventArgs e)
        { 
            trayIconMenu.Items.RemoveAt(3);
            if (microphone.IsMuted) { trayIconMenu.Items.Add("Unmute mic"); }
            else { trayIconMenu.Items.Add("Mute mic"); }

            if (this.WindowState == FormWindowState.Normal) { trayIconMenu.Items[1].Enabled = false; }
        }

        private void trayIconMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == trayIconMenu.Items[0])         // exit
            {
                this.Close();
            } 
            else if (e.ClickedItem == trayIconMenu.Items[1])            // show window
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                showOptionsCheckbox.Checked = false;
            }
            else if (e.ClickedItem == trayIconMenu.Items[3])            // toggle mute
            {
                toggleMuteButton_Click(null, null);
            }
        }
        private void trayIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            /*Show();
            this.WindowState = FormWindowState.Normal;
            showOptionsCheckbox.Checked = false;*/
        }
        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                toggleMuteButton_Click(null, null);
            }
        }

        private void editKeybindButton_Click(object sender, EventArgs e)
        {
            var setKeybindWindow = new SetKeybindWindow();
            setKeybindWindow.Show();
        }

        private void devLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/rednir/MicMuter");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
