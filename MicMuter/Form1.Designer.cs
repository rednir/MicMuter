namespace MicMuter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toggleMuteButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBarLabel = new System.Windows.Forms.TextBox();
            this.showOptionsCheckbox = new System.Windows.Forms.CheckBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // toggleMuteButton
            // 
            this.toggleMuteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toggleMuteButton.Location = new System.Drawing.Point(12, 12);
            this.toggleMuteButton.Name = "toggleMuteButton";
            this.toggleMuteButton.Size = new System.Drawing.Size(264, 23);
            this.toggleMuteButton.TabIndex = 0;
            this.toggleMuteButton.Text = "Toggle Mute";
            this.toggleMuteButton.UseVisualStyleBackColor = true;
            this.toggleMuteButton.Click += new System.EventHandler(this.toggleMuteButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(85, 41);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 18);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 50;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressBarLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.progressBarLabel.Location = new System.Drawing.Point(12, 42);
            this.progressBarLabel.MaxLength = 32;
            this.progressBarLabel.Multiline = true;
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.ReadOnly = true;
            this.progressBarLabel.ShortcutsEnabled = false;
            this.progressBarLabel.Size = new System.Drawing.Size(67, 18);
            this.progressBarLabel.TabIndex = 2;
            this.progressBarLabel.Text = "Mic volume:";
            this.progressBarLabel.WordWrap = false;
            // 
            // showOptionsCheckbox
            // 
            this.showOptionsCheckbox.AutoSize = true;
            this.showOptionsCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showOptionsCheckbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showOptionsCheckbox.Location = new System.Drawing.Point(186, 122);
            this.showOptionsCheckbox.Name = "showOptionsCheckbox";
            this.showOptionsCheckbox.Size = new System.Drawing.Size(104, 18);
            this.showOptionsCheckbox.TabIndex = 3;
            this.showOptionsCheckbox.Text = "Show options";
            this.showOptionsCheckbox.UseVisualStyleBackColor = true;
            this.showOptionsCheckbox.CheckedChanged += new System.EventHandler(this.showOptionsCheckbox_CheckedChanged);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Double click";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 152);
            this.Controls.Add(this.showOptionsCheckbox);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toggleMuteButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mic Muter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleMuteButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox progressBarLabel;
        private System.Windows.Forms.CheckBox showOptionsCheckbox;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

