namespace Keyboard_clicker_windows_by_rafalek__WinForms_
{
    partial class SettingsForm
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
            HotkeyCombobox = new ComboBox();
            CancelButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // HotkeyCombobox
            // 
            HotkeyCombobox.FormattingEnabled = true;
            HotkeyCombobox.Location = new Point(24, 26);
            HotkeyCombobox.Name = "HotkeyCombobox";
            HotkeyCombobox.Size = new Size(121, 23);
            HotkeyCombobox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 74);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(65, 41);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += button1_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(95, 74);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(64, 41);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 136);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(HotkeyCombobox);
            Name = "SettingsForm";
            Text = "Settings";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox HotkeyCombobox;
        private Button CancelButton;
        private Button SaveButton;
    }
}