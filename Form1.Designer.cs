namespace Keyboard_clicker_windows_by_rafalek__WinForms_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            KeyInput = new ComboBox();
            TimeInput = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            changeHotkeyToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            KeyClicked = new Label();
            StopButton = new ePOSOne.btnProduct.Button_WOC();
            StartButton = new ePOSOne.btnProduct.Button_WOC();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // KeyInput
            // 
            KeyInput.BackColor = Color.FromArgb(217, 217, 217);
            KeyInput.FlatStyle = FlatStyle.Flat;
            KeyInput.Font = new Font("Oswald", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KeyInput.FormattingEnabled = true;
            KeyInput.Location = new Point(21, 67);
            KeyInput.Name = "KeyInput";
            KeyInput.Size = new Size(119, 24);
            KeyInput.TabIndex = 0;
            KeyInput.Text = "Select a key";
            KeyInput.SelectedValueChanged += KeyInput_SelectedValueChanged;
            // 
            // TimeInput
            // 
            TimeInput.BackColor = Color.FromArgb(217, 217, 217);
            TimeInput.BorderStyle = BorderStyle.None;
            TimeInput.Font = new Font("Oswald", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TimeInput.Location = new Point(170, 67);
            TimeInput.Multiline = true;
            TimeInput.Name = "TimeInput";
            TimeInput.Size = new Size(130, 24);
            TimeInput.TabIndex = 1;
            TimeInput.KeyPress += TimeInput_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(217, 217, 217);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(5, 198);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 49);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oswald", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(14, 139, 109);
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(69, 16);
            label1.TabIndex = 5;
            label1.Text = "Select a key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oswald", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(14, 139, 109);
            label2.Location = new Point(170, 48);
            label2.Name = "label2";
            label2.Size = new Size(130, 16);
            label2.TabIndex = 6;
            label2.Text = "Interval of clicking in ms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oswald", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(122, 172);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Test space";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(323, 23);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 19);
            fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeHotkeyToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeHotkeyToolStripMenuItem
            // 
            changeHotkeyToolStripMenuItem.Name = "changeHotkeyToolStripMenuItem";
            changeHotkeyToolStripMenuItem.Size = new Size(154, 22);
            changeHotkeyToolStripMenuItem.Text = "Change hotkey";
            changeHotkeyToolStripMenuItem.Click += changeHotkeyToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(116, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oswald", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(194, 198);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "Last clicked key";
            // 
            // KeyClicked
            // 
            KeyClicked.AutoSize = true;
            KeyClicked.Font = new Font("Oswald", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            KeyClicked.ForeColor = Color.White;
            KeyClicked.Location = new Point(227, 221);
            KeyClicked.Name = "KeyClicked";
            KeyClicked.Size = new Size(36, 26);
            KeyClicked.TabIndex = 10;
            KeyClicked.Text = "Key";
            // 
            // StopButton
            // 
            StopButton.BorderColor = Color.FromArgb(14, 139, 109);
            StopButton.ButtonColor = Color.FromArgb(14, 139, 109);
            StopButton.FlatAppearance.BorderSize = 0;
            StopButton.FlatStyle = FlatStyle.Flat;
            StopButton.Font = new Font("Oswald", 15F, FontStyle.Bold, GraphicsUnit.Point);
            StopButton.Location = new Point(164, 105);
            StopButton.Name = "StopButton";
            StopButton.OnHoverBorderColor = Color.FromArgb(14, 139, 109);
            StopButton.OnHoverButtonColor = Color.FromArgb(14, 139, 109);
            StopButton.OnHoverTextColor = Color.White;
            StopButton.Size = new Size(136, 49);
            StopButton.TabIndex = 11;
            StopButton.Text = "STOP";
            StopButton.TextColor = Color.White;
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.BorderColor = Color.FromArgb(14, 139, 109);
            StartButton.ButtonColor = Color.FromArgb(14, 139, 109);
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Font = new Font("Oswald", 15F, FontStyle.Bold, GraphicsUnit.Point);
            StartButton.Location = new Point(12, 105);
            StartButton.Name = "StartButton";
            StartButton.OnHoverBorderColor = Color.FromArgb(14, 139, 109);
            StartButton.OnHoverButtonColor = Color.FromArgb(14, 139, 109);
            StartButton.OnHoverTextColor = Color.White;
            StartButton.Size = new Size(136, 49);
            StartButton.TabIndex = 12;
            StartButton.Text = "START";
            StartButton.TextColor = Color.White;
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 198, 198);
            ClientSize = new Size(323, 252);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(KeyInput);
            Controls.Add(TimeInput);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(KeyClicked);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(339, 291);
            MinimumSize = new Size(339, 291);
            Name = "Form1";
            Text = "Keyboard clicker by rafalek";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox KeyInput;
        private TextBox TimeInput;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem changeHotkeyToolStripMenuItem;
        private Label label4;
        private Label KeyClicked;
        private ePOSOne.btnProduct.Button_WOC StopButton;
        private ePOSOne.btnProduct.Button_WOC StartButton;
    }
}