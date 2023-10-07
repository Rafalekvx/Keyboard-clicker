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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            HotkeyCombobox = new ComboBox();
            SaveButton = new ePOSOne.btnProduct.Button_WOC();
            CancelButton = new ePOSOne.btnProduct.Button_WOC();
            SuspendLayout();
            // 
            // HotkeyCombobox
            // 
            HotkeyCombobox.BackColor = Color.FromArgb(217, 217, 217);
            HotkeyCombobox.FlatStyle = FlatStyle.Flat;
            HotkeyCombobox.Font = new Font("Oswald", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HotkeyCombobox.FormattingEnabled = true;
            HotkeyCombobox.Location = new Point(48, 26);
            HotkeyCombobox.Name = "HotkeyCombobox";
            HotkeyCombobox.Size = new Size(121, 24);
            HotkeyCombobox.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(198, 198, 198);
            SaveButton.BorderColor = Color.FromArgb(14, 139, 109);
            SaveButton.ButtonColor = Color.FromArgb(14, 139, 109);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Oswald", 15F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(111, 74);
            SaveButton.Name = "SaveButton";
            SaveButton.OnHoverBorderColor = Color.FromArgb(14, 139, 109);
            SaveButton.OnHoverButtonColor = Color.FromArgb(14, 139, 109);
            SaveButton.OnHoverTextColor = Color.White;
            SaveButton.Size = new Size(98, 41);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "SAVE";
            SaveButton.TextColor = Color.White;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(198, 198, 198);
            CancelButton.BorderColor = Color.FromArgb(14, 139, 109);
            CancelButton.ButtonColor = Color.FromArgb(14, 139, 109);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Oswald", 15F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.Location = new Point(7, 74);
            CancelButton.Name = "CancelButton";
            CancelButton.OnHoverBorderColor = Color.FromArgb(14, 139, 109);
            CancelButton.OnHoverButtonColor = Color.FromArgb(14, 139, 109);
            CancelButton.OnHoverTextColor = Color.White;
            CancelButton.Size = new Size(98, 41);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "CANCEL";
            CancelButton.TextColor = Color.White;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += button1_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 198, 198);
            ClientSize = new Size(221, 136);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(HotkeyCombobox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            Text = "Settings";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox HotkeyCombobox;
        private ePOSOne.btnProduct.Button_WOC SaveButton;
        private ePOSOne.btnProduct.Button_WOC CancelButton;
    }
}