using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Keyboard_clicker_windows_by_rafalek__WinForms_
{
    public partial class Form1 : Form
    {
        private bool isClicking = false;
        private InputSimulator inputSimulator;
        private IKeyboardSimulator keyboardSimulator;
        private Keys hotkey = (Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.Hotkey.ToString());

        public Keys hotkeychange
        {
            get { return hotkey; }
            set { hotkey = value; }
        }

        Regex isNumberRegex = new Regex("[^0-9]+");

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            inputSimulator = new InputSimulator();
            keyboardSimulator = new InputSimulator().Keyboard;

            StopButton.FlatAppearance.MouseOverBackColor = StopButton.BackColor;
            StopButton.BackColorChanged += (s, e) =>
            {
                StopButton.FlatAppearance.MouseOverBackColor = StopButton.BackColor;
            };

            StartButton.FlatAppearance.MouseOverBackColor = StartButton.BackColor;
            StartButton.BackColorChanged += (s, e) =>
            {
                StartButton.FlatAppearance.MouseOverBackColor = StartButton.BackColor;
            };

        }


        private void InitializeComboBox()
        {
            KeyInput.Items.Add("Tab");
            KeyInput.Items.Add("CapsLock");
            KeyInput.Items.Add("Shift");
            KeyInput.Items.Add("Ctrl");
            KeyInput.Items.Add("Alt");
            KeyInput.Items.Add("Enter");
            KeyInput.Items.Add("Backspace");
            KeyInput.Items.Add("ESC");
            KeyInput.Items.Add("Space");
            KeyInput.Items.Add("NumLock");
            for (int j = 1; j <= 12; j++)
            {
                KeyInput.Items.Add(("F" + j).ToString());
            }
            for (int k = 0; k <= 9; k++)
            {
                KeyInput.Items.Add(k.ToString());
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                KeyInput.Items.Add(c.ToString());
            }
            for (int l = 0; l <= 9; l++)
            {
                KeyInput.Items.Add("Numpad" + l.ToString());
            }
        }

        private void TimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isNumberRegex.IsMatch(e.KeyChar.ToString());
        }

        private void KeyInput_SelectedValueChanged(object sender, EventArgs e)
        {
            if (KeyInput.SelectedItem != null)
            {
                string selectedCharacter = e.ToString();
            }
        }


        private async Task StartWorking()
        {
            while (isClicking)
            {
                if (KeyInput.SelectedItem != null)
                {
                    KeyInput.Enabled = false;
                    TimeInput.Enabled = false;
                    await Task.Delay(int.Parse(TimeInput.Text));
                    KeyCodes enumValue = (KeyCodes)Enum.Parse(typeof(KeyCodes), KeyInput.SelectedItem.ToString());
                    if (!isNumberRegex.IsMatch(KeyInput.SelectedItem.ToString()))
                    {
                        enumValue = (KeyCodes)Enum.Parse(typeof(KeyCodes), "N" + KeyInput.SelectedItem.ToString());
                    }
                    VirtualKeyCode userKey = (VirtualKeyCode)enumValue;
                    inputSimulator.Keyboard.KeyPress(userKey);
                }
                else
                {
                    break;
                }

            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            isClicking = true;
            await StartWorking();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isClicking = false;
            KeyInput.Enabled = true;
            TimeInput.Enabled = true;
        }



        protected override void WndProc(ref Message m)
        {

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == 2137)
            {

                if (isClicking)
                {
                    isClicking = false;
                    KeyInput.Enabled = true;
                    TimeInput.Enabled = true;
                }
                else
                {
                    isClicking = true;
                }
                StartWorking();
            }

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Register the F6 hotkey
            RegisterHotKey(this.Handle, 2137, 0, (int)hotkey);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unregister the hotkey when the form is closing
            UnregisterHotKey(this.Handle, 2137);
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeHotkeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm HotkeyPopup = new SettingsForm(this);
            HotkeyPopup.ShowDialog();

        }

        internal void RefreshWork()
        {
            UnregisterHotKey(this.Handle, 2137);
            Thread.Sleep(100);
            RegisterHotKey(this.Handle, 2137, 0, (int)hotkey);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyClicked.Text = e.KeyCode.ToString();
        }

    }

}
