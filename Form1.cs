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
        }


        private void InitializeComboBox()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                KeyInput.Items.Add(c.ToString());
            }

            KeyInput.Items.Add("Tab");
            KeyInput.Items.Add("CapsLock");
            KeyInput.Items.Add("Shift");
            KeyInput.Items.Add("Ctrl");
            KeyInput.Items.Add("Alt");
            KeyInput.Items.Add("Enter");
            KeyInput.Items.Add("Backspace");
            KeyInput.Items.Add("ESC");
            KeyInput.Items.Add("Space");
        }

        private void TimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.KeyChar.ToString());
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
                    await Task.Delay(int.Parse(TimeInput.Text));
                    KeyCodes enumValue = (KeyCodes)Enum.Parse(typeof(KeyCodes), KeyInput.SelectedItem.ToString());
                    VirtualKeyCode userKey = (VirtualKeyCode)enumValue;
                    inputSimulator.Keyboard.KeyPress(userKey);
                }
                else { break; }
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
        }



        protected async override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            switch (m.Msg)
            {
                case WM_HOTKEY:
                    int key = (int)m.WParam;

                    if (key == 2137)
                    {
                        if (isClicking)
                        {
                            isClicking = false;
                        }
                        else
                        {
                            isClicking = true;
                        }
                        await StartWorking();
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Register the F6 hotkey
            RegisterHotKey(Handle, 2137, 0, (int)Keys.F6);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unregister the hotkey when the form is closing
            UnregisterHotkey();
        }

        private void RegisterHotkey(Keys key)
        {
            inputSimulator.Keyboard
                .KeyDown(VirtualKeyCode.CONTROL)
                .KeyPress((VirtualKeyCode)key)
                .KeyUp(VirtualKeyCode.CONTROL);
        }

        private void UnregisterHotkey()
        {
            // Unregister the F6 hotkey
            UnregisterHotKey(Handle, 2137);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeHotkeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}