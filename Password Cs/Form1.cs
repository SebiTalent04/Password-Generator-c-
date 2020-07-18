using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Password_Cs
{
    public partial class Form1 : MetroForm
    {


        public Form1()
        {
            InitializeComponent();
            MetroTextBox1.Enabled = false;
            MetroTextBox1.Text = GeneratePassword(MetroTrackBar1.Value);
            MetroLabel2.Text = MetroTrackBar1.Value.ToString();
            this.StyleManager = metroStyleManager1;
            metroTabControl1.TabIndex = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; // 10 secs
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            metroStyleManager1.Style = Properties.Settings.Default.Style;
            metroStyleManager1.Theme = Properties.Settings.Default.Theme;
            metroComboBox1.Style = Properties.Settings.Default.StyleCombo1;
            metroComboBox2.Style = Properties.Settings.Default.StyleCombo2;
            metroTabControl1.Style = Properties.Settings.Default.StyleTab;
            metroTabControl1.Theme = Properties.Settings.Default.ThemeTab;
            mcbUppercase.CheckState = Properties.Settings.Default.CheckBox1;
            mcbLowercase.CheckState = Properties.Settings.Default.CheckBox2;
            mcbNumber.CheckState = Properties.Settings.Default.CheckBox3;
            mcbSpecial.CheckState = Properties.Settings.Default.CheckBox4;
            mcbUppercase.Style = Properties.Settings.Default.StyleCheck1;
            mcbLowercase.Style = Properties.Settings.Default.StyleCheck2;
            mcbNumber.Style = Properties.Settings.Default.StyleCheck3;
            mcbSpecial.Style = Properties.Settings.Default.StyleCheck4;
            metroComboBox1.SelectedIndex = Properties.Settings.Default.Combo1;
            metroComboBox2.SelectedIndex = Properties.Settings.Default.Combo2;
            MetroTrackBar1.Value = Properties.Settings.Default.TrackBarVal;
            MetroTrackBar1.Theme = Properties.Settings.Default.TrackBarTheme;
            MetroLabel2.Text = Properties.Settings.Default.LabelVal;

            metroLink1.Theme = Properties.Settings.Default.MetroLink1Theme;
            metroLink2.Theme = Properties.Settings.Default.MetroLink2Theme;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Style = metroStyleManager1.Style;
            Properties.Settings.Default.Theme = metroStyleManager1.Theme;
            Properties.Settings.Default.CheckBox1 = mcbUppercase.CheckState;
            Properties.Settings.Default.CheckBox2 = mcbLowercase.CheckState;
            Properties.Settings.Default.CheckBox3 = mcbNumber.CheckState;
            Properties.Settings.Default.CheckBox4 = mcbSpecial.CheckState;
            Properties.Settings.Default.StyleCheck1 = mcbUppercase.Style;
            Properties.Settings.Default.StyleCheck2 = mcbLowercase.Style;
            Properties.Settings.Default.StyleCheck3 = mcbNumber.Style;
            Properties.Settings.Default.StyleCheck4 = mcbSpecial.Style;
            Properties.Settings.Default.StyleCombo1 = metroComboBox1.Style;
            Properties.Settings.Default.StyleCombo2 = metroComboBox2.Style;
            Properties.Settings.Default.StyleTab = metroTabControl1.Style;
            Properties.Settings.Default.ThemeTab = metroTabControl1.Theme;
            Properties.Settings.Default.LabelVal = MetroLabel2.Text;
            Properties.Settings.Default.Combo1 = metroComboBox1.SelectedIndex;
            Properties.Settings.Default.Combo2 = metroComboBox2.SelectedIndex;
            Properties.Settings.Default.TrackBarVal = MetroTrackBar1.Value;
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
            MetroLabel2.Text = MetroTrackBar1.Value.ToString();
            MetroTextBox1.Text = GeneratePassword(MetroTrackBar1.Value);
        }

        private void MetroTrackBar1_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private string GeneratePassword(int length = 1)
        {
            string all = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string Upper = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string Lower = "abcdefghijklmnopqrstuvwxyz";
            string Number = "0123456789";
            string Special = "!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string UpperLower = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string UpperNumber = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            string UpperSpecial = "ABCDEFGHJKLMNOPQRSTUVWXYZ!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string UpperLowerNumber = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string UpperLowerSpecial = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string UpperNumberSpecial = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string LowerNumber = "abcdefghijklmnopqrstuvwxyz0123456789";
            string LowerSpecial = "abcdefghijklmnopqrstuvwxyz!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string NumberSpecial = "0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            string LowerNumberSpecial = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-`~<>,./\\;:[]{}()=+|";
            Random random = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                ///////////////////
                ///  Uppercase  ///
                ///////////////////
                if (mcbUppercase.Checked)
                {
                    chars[i] = Upper[random.Next(0, Upper.Length)];
                    //Uppercase + Lowercase
                    if (mcbLowercase.Checked)
                    {
                        chars[i] = UpperLower[random.Next(0, UpperLower.Length)];
                    }
                    //Uppercase + Number
                    if (mcbNumber.Checked)
                    {
                        chars[i] = UpperNumber[random.Next(0, UpperNumber.Length)];
                    }
                    //Uppercase + Special
                    if (mcbSpecial.Checked)
                    {
                        chars[i] = UpperSpecial[random.Next(0, UpperSpecial.Length)];
                    }
                    //Uppercase + Lowercase + Number
                    if (mcbLowercase.Checked && mcbNumber.Checked || mcbNumber.Checked && mcbLowercase.Checked)
                    {
                        chars[i] = UpperLowerNumber[random.Next(0, UpperLowerNumber.Length)];
                    }
                    //Uppercase + Lowercase + Special
                    if (mcbLowercase.Checked && mcbSpecial.Checked || mcbSpecial.Checked && mcbLowercase.Checked)
                    {
                        chars[i] = UpperLowerSpecial[random.Next(0, UpperLowerSpecial.Length)];
                    }
                    //Uppercase + Number + Special
                    if (mcbNumber.Checked && mcbSpecial.Checked  || mcbSpecial.Checked && mcbNumber.Checked)
                    {
                        chars[i] = UpperNumberSpecial[random.Next(0, UpperNumberSpecial.Length)];
                    }
                    //Uppercase + Lowercase + Number + Special (All)
                    if (mcbLowercase.Checked && mcbNumber.Checked && mcbSpecial.Checked) //|| mcbLowercase.Checked && mcbSpecial.Checked && mcbNumber.Checked || mcbNumber.Checked && mcbLowercase.Checked && mcbSpecial.Checked || mcbNumber.Checked && mcbSpecial.Checked && mcbLowercase.Checked || mcbSpecial.Checked && mcbNumber.Checked && mcbLowercase.Checked || mcbSpecial.Checked && mcbLowercase.Checked && mcbNumber.Checked)
                    {
                        chars[i] = all[random.Next(0, all.Length)];
                    }
                }               
                ///////////////////
                ///  Lowercase  ///
                ///////////////////
                else if (mcbLowercase.Checked)
                {
                    chars[i] = Lower[random.Next(0, Lower.Length)];
                    //Lowercase + Number
                    if (mcbNumber.Checked)
                    {
                        chars[i] = LowerNumber[random.Next(0, LowerNumber.Length)];
                    }
                    //Lowercase + Special
                    if (mcbSpecial.Checked)
                    {
                        chars[i] = LowerSpecial[random.Next(0, LowerSpecial.Length)];
                    }
                    //Lowercase + Number + Special
                    if (mcbNumber.Checked && mcbSpecial.Checked)
                    {
                        chars[i] = LowerNumberSpecial[random.Next(0, LowerNumberSpecial.Length)];
                    }
                }
                ///////////////////
                ///   Number    ///
                ///////////////////
                else if (mcbNumber.Checked)
                {
                    chars[i] = Number[random.Next(0, Number.Length)];

                    if(mcbSpecial.Checked)
                    {
                        chars[i] = NumberSpecial[random.Next(0, NumberSpecial.Length)];
                    }
                }

                ///////////////////
                ///   Special   ///
                ///////////////////
                else if (mcbSpecial.Checked)
                {
                    chars[i] = Special[random.Next(0, Special.Length)];
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
                    mcbUppercase.Theme = MetroThemeStyle.Dark;
                    mcbLowercase.Theme = MetroThemeStyle.Dark;
                    mcbNumber.Theme = MetroThemeStyle.Dark;
                    mcbSpecial.Theme = MetroThemeStyle.Dark;
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
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroThemeStyle.Light;
                    metroTabControl1.Theme = MetroThemeStyle.Light;
                    metroTabPage1.Theme = MetroThemeStyle.Light;
                    metroTabPage2.Theme = MetroThemeStyle.Light;
                    mcbUppercase.Theme = MetroThemeStyle.Light;
                    mcbLowercase.Theme = MetroThemeStyle.Light;
                    mcbNumber.Theme = MetroThemeStyle.Light;
                    mcbSpecial.Theme = MetroThemeStyle.Light;
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
                    break;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            metroTabControl1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            mcbUppercase.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            mcbLowercase.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            mcbNumber.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            mcbSpecial.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            metroComboBox1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            metroComboBox2.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
            MetroTextBox1.Style = (MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SebiTalent04");
        }
    }
}
