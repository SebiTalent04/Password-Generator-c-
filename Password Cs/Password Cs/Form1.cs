using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Password_Cs
{
    public partial class Form1 : MetroForm
    {

        private int passwordLength = 5;

        public Form1()
        {
            InitializeComponent();
            MetroTextBox1.Enabled = false;
            MetroTrackBar1.Value = passwordLength;
            MetroLabel2.Text = MetroTrackBar1.Value.ToString();
            MetroTextBox1.Text = GeneratePassword(passwordLength);
            this.StyleManager = metroStyleManager1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroStyleManager1.Style = Properties.Settings.Default.Style;
            metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            MetroCheckBox1.CheckState = Properties.Settings.Default.CheckBox1;
            MetroCheckBox2.CheckState = Properties.Settings.Default.CheckBox2;
            MetroCheckBox3.CheckState = Properties.Settings.Default.CheckBox3;
            MetroCheckBox4.CheckState = Properties.Settings.Default.CheckBox4;
            MetroCheckBox1.Style = Properties.Settings.Default.StyleCheck1;
            MetroCheckBox2.Style = Properties.Settings.Default.StyleCheck2;
            MetroCheckBox3.Style = Properties.Settings.Default.StyleCheck3;
            MetroCheckBox4.Style = Properties.Settings.Default.StyleCheck4;
            metroComboBox1.Style = Properties.Settings.Default.StyleCombo1;
            metroComboBox2.Style = Properties.Settings.Default.StyleCombo2;
            metroTabControl1.Style = Properties.Settings.Default.StyleTab;
            metroTabControl1.Theme = Properties.Settings.Default.ThemeTab;
            metroComboBox1.SelectedIndex = Properties.Settings.Default.Combo1;
            metroComboBox2.SelectedIndex = Properties.Settings.Default.Combo2;
           //MetroTrackBar1.Value = Properties.Settings.Default.TrackBarVal;
            MetroTrackBar1.Theme = Properties.Settings.Default.TrackBarTheme;
            metroLink1.Theme = Properties.Settings.Default.MetroLink1Theme;
            metroLink2.Theme = Properties.Settings.Default.MetroLink2Theme;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Style = metroStyleManager1.Style;
            Properties.Settings.Default.Theme = metroStyleManager1.Theme;
            Properties.Settings.Default.CheckBox1 = MetroCheckBox1.CheckState;
            Properties.Settings.Default.CheckBox2 = MetroCheckBox2.CheckState;
            Properties.Settings.Default.CheckBox3 = MetroCheckBox3.CheckState;
            Properties.Settings.Default.CheckBox4 = MetroCheckBox4.CheckState;
            Properties.Settings.Default.StyleCheck1 = MetroCheckBox1.Style;
            Properties.Settings.Default.StyleCheck2 = MetroCheckBox2.Style;
            Properties.Settings.Default.StyleCheck3 = MetroCheckBox3.Style;
            Properties.Settings.Default.StyleCheck4 = MetroCheckBox4.Style;
            Properties.Settings.Default.StyleCombo1 = metroComboBox1.Style;
            Properties.Settings.Default.StyleCombo2 = metroComboBox2.Style;
            Properties.Settings.Default.StyleTab = metroTabControl1.Style;
            Properties.Settings.Default.ThemeTab = metroTabControl1.Theme;
            Properties.Settings.Default.Combo1 = metroComboBox1.SelectedIndex;
            Properties.Settings.Default.Combo2 = metroComboBox2.SelectedIndex;
            //Properties.Settings.Default.TrackBarVal = MetroTrackBar1.Value;
            Properties.Settings.Default.TrackBarTheme = MetroTrackBar1.Theme;
            Properties.Settings.Default.MetroLink1Theme = metroLink1.Theme;
            Properties.Settings.Default.MetroLink2Theme = metroLink2.Theme;
            Properties.Settings.Default.Save();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(MetroTextBox1.Text);
            }
            catch (System.ArgumentNullException)
            {
                MetroMessageBox.Show(this, "Nothing to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            passwordLength = MetroTrackBar1.Value;
            MetroLabel2.Text = MetroTrackBar1.Value.ToString();
            MetroTextBox1.Text = GeneratePassword(passwordLength);
        }

        private string GeneratePassword(int length = 12)
        {
            string upper = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string number = "0123456789";
            string special = "!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            string upperlower = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string uppernumber = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            string upperspecial = "ABCDEFGHJKLMNOPQRSTUVWXYZ!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            string lowernumber = "abcdefghijklmnopqrstuvwxyz0123456789";
            string lowerspecial = "abcdefghijklmnopqrstuvwxyz!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            string numberspecial = "0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            string upperlowernumber = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string uppernumberspecial = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            string lowernumberspecial = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            string all = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()<>=+|";
            Random random = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                if (MetroCheckBox1.Checked)
                {
                    chars[i] = upper[random.Next(0, upper.Length)];
                }
                else if (MetroCheckBox2.Checked)
                {
                    chars[i] = lower[random.Next(0, lower.Length)];
                }
                else if (MetroCheckBox3.Checked)
                {
                    chars[i] = number[random.Next(0, number.Length)];
                }
                else if (MetroCheckBox4.Checked)
                {
                    chars[i] = special[random.Next(0, special.Length)];
                }

                if (MetroCheckBox1.Checked && MetroCheckBox2.Checked)
                {
                    chars[i] = upperlower[random.Next(0, upperlower.Length)];
                }
                else if (MetroCheckBox1.Checked && MetroCheckBox3.Checked)
                {
                    chars[i] = uppernumber[random.Next(0, uppernumber.Length)];
                }
                else if (MetroCheckBox1.Checked && MetroCheckBox4.Checked)
                {
                    chars[i] = upperspecial[random.Next(0, upperspecial.Length)];
                }

                if (MetroCheckBox2.Checked && MetroCheckBox3.Checked)
                {
                    chars[i] = lowernumber[random.Next(0, lowernumber.Length)];
                }
                else if (MetroCheckBox2.Checked && MetroCheckBox4.Checked)
                {
                    chars[i] = lowerspecial[random.Next(0, lowerspecial.Length)];
                }

                if (MetroCheckBox3.Checked && MetroCheckBox4.Checked)
                {
                    chars[i] = numberspecial[random.Next(0, numberspecial.Length)];
                }

                if (MetroCheckBox1.Checked && MetroCheckBox2.Checked && MetroCheckBox3.Checked)
                {
                    chars[i] = upperlowernumber[random.Next(0, upperlowernumber.Length)];
                }
                else if (MetroCheckBox1.Checked && MetroCheckBox3.Checked && MetroCheckBox4.Checked)
                {
                    chars[i] = uppernumberspecial[random.Next(0, uppernumberspecial.Length)];
                }
                else if (MetroCheckBox2.Checked && MetroCheckBox3.Checked && MetroCheckBox4.Checked)
                {
                    chars[i] = lowernumberspecial[random.Next(0, lowernumberspecial.Length)];
                }
                if (MetroCheckBox1.Checked && MetroCheckBox2.Checked && MetroCheckBox3.Checked && MetroCheckBox4.Checked)
                {
                    chars[i] = all[random.Next(0, all.Length)];
                }
            }
            return new string(chars);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroThemeStyle.Dark;
                    metroTabControl1.Theme = MetroThemeStyle.Dark;
                    metroTabPage1.Theme = MetroThemeStyle.Dark;
                    metroTabPage2.Theme = MetroThemeStyle.Dark;
                    MetroCheckBox1.Theme = MetroThemeStyle.Dark;
                    MetroCheckBox2.Theme = MetroThemeStyle.Dark;
                    MetroCheckBox3.Theme = MetroThemeStyle.Dark;
                    MetroCheckBox4.Theme = MetroThemeStyle.Dark;
                    MetroTrackBar1.Theme = MetroThemeStyle.Dark;
                    MetroTextBox1.Theme = MetroThemeStyle.Dark;
                    MetroLabel1.Theme = MetroThemeStyle.Dark;
                    MetroLabel2.Theme = MetroThemeStyle.Dark;
                    MetroLabel3.Theme = MetroThemeStyle.Dark;
                    MetroLabel4.Theme = MetroThemeStyle.Dark;
                    metroLink1.Theme = MetroThemeStyle.Dark;
                    metroLink2.Theme = MetroThemeStyle.Dark;
                    MetroButton1.Theme = MetroThemeStyle.Dark;
                    metroComboBox1.Theme = MetroThemeStyle.Dark;
                    metroComboBox2.Theme = MetroThemeStyle.Dark;
                    this.Refresh();
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroThemeStyle.Light;
                    metroTabControl1.Theme = MetroThemeStyle.Light;
                    metroTabPage1.Theme = MetroThemeStyle.Light;
                    metroTabPage2.Theme = MetroThemeStyle.Light;
                    MetroCheckBox1.Theme = MetroThemeStyle.Light;
                    MetroCheckBox2.Theme = MetroThemeStyle.Light;
                    MetroCheckBox3.Theme = MetroThemeStyle.Light;
                    MetroCheckBox4.Theme = MetroThemeStyle.Light;
                    MetroTrackBar1.Theme = MetroThemeStyle.Light;
                    MetroTextBox1.Theme = MetroThemeStyle.Light;
                    MetroLabel1.Theme = MetroThemeStyle.Light;
                    MetroLabel2.Theme = MetroThemeStyle.Light;
                    MetroLabel3.Theme = MetroThemeStyle.Light;
                    MetroLabel4.Theme = MetroThemeStyle.Light;
                    metroLink1.Theme = MetroThemeStyle.Light;
                    metroLink2.Theme = MetroThemeStyle.Light;
                    MetroButton1.Theme = MetroThemeStyle.Light;
                    metroComboBox1.Theme = MetroThemeStyle.Light;
                    metroComboBox2.Theme = MetroThemeStyle.Light;
                    this.Refresh();
                    break;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            metroTabControl1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            MetroCheckBox1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            MetroCheckBox2.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            MetroCheckBox3.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            MetroCheckBox4.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            metroComboBox1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            metroComboBox2.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            this.Refresh();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SebiTalent04");
        }
    }
}
