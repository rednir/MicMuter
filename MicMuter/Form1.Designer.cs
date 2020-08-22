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
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.trayShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayToggleMute = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenu = new System.Windows.Forms.CheckedListBox();
            this.editKeybindButton = new System.Windows.Forms.Button();
            this.currectKeybindLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devLink = new System.Windows.Forms.LinkLabel();
            this.trayIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleMuteButton
            // 
            this.toggleMuteButton.ForeColor = System.Drawing.SystemColors.MenuText;
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
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Click to toggle mute";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayExit,
            this.trayShowWindow,
            this.trayMenuSeparator1,
            this.trayToggleMute});
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.trayIconMenu.Size = new System.Drawing.Size(149, 76);
            this.trayIconMenu.Opening += new System.ComponentModel.CancelEventHandler(this.trayIconMenu_Opening);
            this.trayIconMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.trayIconMenu_ItemClicked);
            // 
            // trayExit
            // 
            this.trayExit.Name = "trayExit";
            this.trayExit.Size = new System.Drawing.Size(148, 22);
            this.trayExit.Text = "Exit";
            // 
            // trayShowWindow
            // 
            this.trayShowWindow.Name = "trayShowWindow";
            this.trayShowWindow.Size = new System.Drawing.Size(148, 22);
            this.trayShowWindow.Text = "Show window";
            // 
            // trayMenuSeparator1
            // 
            this.trayMenuSeparator1.Name = "trayMenuSeparator1";
            this.trayMenuSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // trayToggleMute
            // 
            this.trayToggleMute.Name = "trayToggleMute";
            this.trayToggleMute.Size = new System.Drawing.Size(148, 22);
            this.trayToggleMute.Text = "Toggle Mute";
            // 
            // optionsMenu
            // 
            this.optionsMenu.CheckOnClick = true;
            this.optionsMenu.FormattingEnabled = true;
            this.optionsMenu.Items.AddRange(new object[] {
            "Start minimized",
            "Don\'t show dialog on exit",
            "Play sound when toggling mute",
            "Run on windows startup"});
            this.optionsMenu.Location = new System.Drawing.Point(12, 154);
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(264, 72);
            this.optionsMenu.TabIndex = 4;
            this.optionsMenu.SelectedIndexChanged += new System.EventHandler(this.optionsMenu_SelectedIndexChanged);
            // 
            // editKeybindButton
            // 
            this.editKeybindButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editKeybindButton.Location = new System.Drawing.Point(225, 233);
            this.editKeybindButton.Name = "editKeybindButton";
            this.editKeybindButton.Size = new System.Drawing.Size(51, 23);
            this.editKeybindButton.TabIndex = 5;
            this.editKeybindButton.Text = "Edit";
            this.editKeybindButton.UseVisualStyleBackColor = true;
            this.editKeybindButton.Click += new System.EventHandler(this.editKeybindButton_Click);
            // 
            // currectKeybindLabel
            // 
            this.currectKeybindLabel.AutoSize = true;
            this.currectKeybindLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currectKeybindLabel.Location = new System.Drawing.Point(9, 238);
            this.currectKeybindLabel.Name = "currectKeybindLabel";
            this.currectKeybindLabel.Size = new System.Drawing.Size(60, 13);
            this.currectKeybindLabel.TabIndex = 6;
            this.currectKeybindLabel.Text = "Keybind: []";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "minimize to the system tray";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "The program will";
            // 
            // devLink
            // 
            this.devLink.ActiveLinkColor = System.Drawing.Color.Blue;
            this.devLink.AutoSize = true;
            this.devLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.devLink.Location = new System.Drawing.Point(108, 288);
            this.devLink.Name = "devLink";
            this.devLink.Size = new System.Drawing.Size(72, 13);
            this.devLink.TabIndex = 9;
            this.devLink.TabStop = true;
            this.devLink.Text = "Github page";
            this.devLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.devLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.devLink_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(288, 310);
            this.Controls.Add(this.devLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currectKeybindLabel);
            this.Controls.Add(this.editKeybindButton);
            this.Controls.Add(this.optionsMenu);
            this.Controls.Add(this.showOptionsCheckbox);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toggleMuteButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Mic Muter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.trayIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggleMuteButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox progressBarLabel;
        private System.Windows.Forms.CheckBox showOptionsCheckbox;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckedListBox optionsMenu;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem trayToggleMute;
        private System.Windows.Forms.ToolStripMenuItem trayShowWindow;
        private System.Windows.Forms.ToolStripMenuItem trayExit;
        private System.Windows.Forms.ToolStripSeparator trayMenuSeparator1;
        private System.Windows.Forms.Button editKeybindButton;
        private System.Windows.Forms.Label currectKeybindLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel devLink;
    }
}

