using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using MicMuter.Properties;

namespace MicMuter
{
    public partial class SetKeybindWindow : Form
    {
        public static bool tempDontUseExitDialog = false;
        public SetKeybindWindow()
        {
            InitializeComponent();
        }

        List<string> keyPresses = new List<string>();

        private void SetKeybindWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void SetKeybindWindow_KeyDown(object sender, KeyEventArgs e)
        {
            keybindLabel.Text += Convert.ToString($"{e.KeyCode}+");
            keyPresses.Add(Convert.ToString(e.KeyCode));
        }

        private void keybindResetButton_Click(object sender, EventArgs e)
        {
            keybindLabel.Text = "Set keybind to: ";
            keyPresses.Clear();
        }

        private void keybindSaveButton_Click(object sender, EventArgs e)
        {
            if (keyPresses.Count > 4)
            {
                MessageBox.Show("The keybind consisted of too many keys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (keyPresses.Count == 0)
            {
                MicMuter.Properties.Settings.Default.Keybind = "0";
                Settings.Default.Save();
                tempDontUseExitDialog = true;
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                StringBuilder result = new StringBuilder();
                foreach (string key in keyPresses)
                {
                    result.Append(key + "+");
                }
                result.Remove(result.Length - 1, 1);
                MicMuter.Properties.Settings.Default.Keybind = result.ToString();
                Settings.Default.Save();
                tempDontUseExitDialog = true;
                Application.Restart();
                //Environment.Exit(0); causes freeze
            }
        }
    }
}
