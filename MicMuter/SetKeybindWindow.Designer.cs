namespace MicMuter
{
    partial class SetKeybindWindow
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
            this.keybindLabel = new System.Windows.Forms.Label();
            this.keybindSaveButton = new System.Windows.Forms.Button();
            this.keybindResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keybindLabel
            // 
            this.keybindLabel.AutoSize = true;
            this.keybindLabel.Location = new System.Drawing.Point(23, 9);
            this.keybindLabel.Name = "keybindLabel";
            this.keybindLabel.Size = new System.Drawing.Size(87, 13);
            this.keybindLabel.TabIndex = 0;
            this.keybindLabel.Text = "Set keybind to: ";
            this.keybindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keybindSaveButton
            // 
            this.keybindSaveButton.Location = new System.Drawing.Point(104, 61);
            this.keybindSaveButton.Name = "keybindSaveButton";
            this.keybindSaveButton.Size = new System.Drawing.Size(178, 23);
            this.keybindSaveButton.TabIndex = 1;
            this.keybindSaveButton.Text = "Save and restart program";
            this.keybindSaveButton.UseVisualStyleBackColor = true;
            this.keybindSaveButton.Click += new System.EventHandler(this.keybindSaveButton_Click);
            // 
            // keybindResetButton
            // 
            this.keybindResetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.keybindResetButton.Location = new System.Drawing.Point(23, 61);
            this.keybindResetButton.Name = "keybindResetButton";
            this.keybindResetButton.Size = new System.Drawing.Size(75, 23);
            this.keybindResetButton.TabIndex = 2;
            this.keybindResetButton.Text = "Reset";
            this.keybindResetButton.UseVisualStyleBackColor = true;
            this.keybindResetButton.Click += new System.EventHandler(this.keybindResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(You cannot use only modifier keys as your keybind, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "like \"Ctrl+Alt\" or \"Alt+Shift\")";
            // 
            // SetKeybindWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 121);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keybindResetButton);
            this.Controls.Add(this.keybindSaveButton);
            this.Controls.Add(this.keybindLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetKeybindWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Set Keybind";
            this.Load += new System.EventHandler(this.SetKeybindWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetKeybindWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keybindLabel;
        private System.Windows.Forms.Button keybindSaveButton;
        private System.Windows.Forms.Button keybindResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}