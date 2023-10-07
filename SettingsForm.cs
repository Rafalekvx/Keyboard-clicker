using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_clicker_windows_by_rafalek__WinForms_
{
    public partial class SettingsForm : Form
    {



        Form1 mainForm;
        public SettingsForm(Form1 form1)
        {
            InitializeComponent();
            InitializeComboBox();
            mainForm = form1;
            HotkeyCombobox.SelectedItem = Properties.Settings.Default.Hotkey;
        }

        private void InitializeComboBox()
        {
            HotkeyCombobox.Items.Add("Tab");
            HotkeyCombobox.Items.Add("CapsLock");
            HotkeyCombobox.Items.Add("Shift");
            HotkeyCombobox.Items.Add("Ctrl");
            HotkeyCombobox.Items.Add("Alt");
            HotkeyCombobox.Items.Add("Enter");
            HotkeyCombobox.Items.Add("Backspace");
            HotkeyCombobox.Items.Add("ESC");
            HotkeyCombobox.Items.Add("Space");
            HotkeyCombobox.Items.Add("NumLock");
            for (int j = 1; j <= 12; j++)
            {
                HotkeyCombobox.Items.Add(("F" + j).ToString());
            }
            for (int k = 0; k <= 9; k++)
            {
                HotkeyCombobox.Items.Add(k.ToString());
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                HotkeyCombobox.Items.Add(c.ToString());
            }
            for (int l = 0; l <= 9; l++)
            {
                HotkeyCombobox.Items.Add("Numpad" + l.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Hotkey = HotkeyCombobox.SelectedItem.ToString();
            mainForm.hotkeychange = (Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.Hotkey.ToString());
            Properties.Settings.Default.Save();
            mainForm.RefreshWork();
            Close();
        }
    }
}
