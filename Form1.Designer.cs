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
            KeyInput = new ComboBox();
            TimeInput = new TextBox();
            textBox2 = new TextBox();
            StopButton = new Button();
            StartButton = new Button();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // KeyInput
            // 
            KeyInput.FormattingEnabled = true;
            KeyInput.Location = new Point(27, 71);
            KeyInput.Name = "KeyInput";
            KeyInput.Size = new Size(119, 23);
            KeyInput.TabIndex = 0;
            KeyInput.Text = "Select a key";
            KeyInput.SelectedValueChanged += KeyInput_SelectedValueChanged;
            // 
            // TimeInput
            // 
            TimeInput.Location = new Point(186, 71);
            TimeInput.Name = "TimeInput";
            TimeInput.Size = new Size(119, 23);
            TimeInput.TabIndex = 1;
            TimeInput.KeyPress += TimeInput_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 218);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 49);
            textBox2.TabIndex = 2;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(186, 125);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(119, 49);
            StopButton.TabIndex = 3;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(27, 125);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(119, 49);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 53);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Select a key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 53);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 6;
            label2.Text = "Interval of clicking in ms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 200);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Test space";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(339, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
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
            label4.Location = new Point(216, 218);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 9;
            label4.Text = "Last clicked key";
            // 
            // KeyClicked
            // 
            KeyClicked.AutoSize = true;
            KeyClicked.Location = new Point(239, 242);
            KeyClicked.Name = "KeyClicked";
            KeyClicked.Size = new Size(26, 15);
            KeyClicked.TabIndex = 10;
            KeyClicked.Text = "Key";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 291);
            Controls.Add(KeyClicked);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(textBox2);
            Controls.Add(TimeInput);
            Controls.Add(KeyInput);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
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
        private Button StopButton;
        private Button StartButton;
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
    }
}