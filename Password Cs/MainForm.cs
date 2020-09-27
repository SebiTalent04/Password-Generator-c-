using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Password_Cs
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            txt_Pass.Enabled = false;
            lbl_Lenght.Text = tbar_Generate.Value.ToString();
            this.StyleManager = metroStyleManager1;
            metroTabControl1.TabIndex = 1;
            metroToolTip1.SetToolTip(tbar_Generate, "Click or drag to generate a password");
            metroToolTip1.SetToolTip(btn_Copy, "Copy the password to clipboard\n The clipboard is cleared after 1 minute");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        //Loading User Settings - Beginning

        private void Form1_Load(object sender, EventArgs e)
        {
            //CheckBoxes - Beginning
            mcb_Uppercase.CheckState = Properties.Settings.Default.check_Uppercase;
            mcb_Uppercase.Style = Properties.Settings.Default.style_Uppercase;
            mcb_Lowercase.CheckState = Properties.Settings.Default.check_Lowercase;
            mcb_Lowercase.Style = Properties.Settings.Default.style_Lowercase;
            mcb_Number.CheckState = Properties.Settings.Default.check_Number;
            mcb_Number.Style = Properties.Settings.Default.style_Number;
            mcb_Special.CheckState = Properties.Settings.Default.check_Special;
            mcb_Special.Style = Properties.Settings.Default.style_Special;
            //CheckBoxes - End

            //TrackBar - Beginning
            tbar_Generate.Value = Properties.Settings.Default.TrackBarVal;
            tbar_Generate.Theme = Properties.Settings.Default.TrackBarTheme;
            //TrackBar - End

            //ComboBoxes - Beginning
            mcmb_Theme.Style = Properties.Settings.Default.StyleCombo1;
            mcmb_Theme.SelectedIndex = Properties.Settings.Default.Combo1;
            mcmb_Style.Style = Properties.Settings.Default.StyleCombo2;
            mcmb_Style.SelectedIndex = Properties.Settings.Default.Combo2;
            //ComboBoxes - End

            //Tabs - Beginning
            metroTabControl1.Style = Properties.Settings.Default.StyleTab;
            metroTabControl1.Theme = Properties.Settings.Default.ThemeTab;
            //Tabs - End

            //
            lbl_Lenght.Text = Properties.Settings.Default.LabelVal;
            //

            //
            lnk_Github_1.Theme = Properties.Settings.Default.MetroLink1Theme;
            lnk_Github_2.Theme = Properties.Settings.Default.MetroLink2Theme;
            //

            txt_Pass.Text = GeneratePassword(tbar_Generate.Value);
            timer1.Interval = 1000; // 1 sec
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
        }

        //Loading User Settings - End


        //Saving User Settings - Beginning

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.check_Uppercase = mcb_Uppercase.CheckState;
            Properties.Settings.Default.check_Lowercase = mcb_Lowercase.CheckState;
            Properties.Settings.Default.check_Number = mcb_Number.CheckState;
            Properties.Settings.Default.check_Special = mcb_Special.CheckState;
            Properties.Settings.Default.style_Uppercase = mcb_Uppercase.Style;
            Properties.Settings.Default.style_Lowercase = mcb_Lowercase.Style;
            Properties.Settings.Default.style_Number = mcb_Number.Style;
            Properties.Settings.Default.style_Special = mcb_Special.Style;
            Properties.Settings.Default.StyleCombo1 = mcmb_Theme.Style;
            Properties.Settings.Default.StyleCombo2 = mcmb_Style.Style;
            Properties.Settings.Default.StyleTab = metroTabControl1.Style;
            Properties.Settings.Default.ThemeTab = metroTabControl1.Theme;
            Properties.Settings.Default.LabelVal = lbl_Lenght.Text;
            Properties.Settings.Default.Combo1 = mcmb_Theme.SelectedIndex;
            Properties.Settings.Default.Combo2 = mcmb_Style.SelectedIndex;
            Properties.Settings.Default.TrackBarVal = tbar_Generate.Value;
            Properties.Settings.Default.TrackBarTheme = tbar_Generate.Theme;
            Properties.Settings.Default.MetroLink1Theme = lnk_Github_1.Theme;
            Properties.Settings.Default.MetroLink2Theme = lnk_Github_2.Theme;
            Properties.Settings.Default.Save();
        }

        //Saving User Settings - End


        //Buttons - Beginning

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_Pass.Text);
                timer2.Start();
                timer2.Interval = 60000;
                timer2.Tick += new EventHandler(Timer2_Tick);
            }
            catch (System.ArgumentNullException)
            {
                MetroMessageBox.Show(this, "Nothing to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            timer2.Stop();
        }

        //Buttons - End


        //Github Links - Beginning

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SebiTalent04");
        }

        private void MetroLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SebiTalent04");
        }

        //Github Links - End


        //TrackBar Actions - Beginning

        private void MetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Lenght.Text = tbar_Generate.Value.ToString();
            txt_Pass.Text = GeneratePassword(tbar_Generate.Value);
            if (!mcb_Uppercase.Checked && !mcb_Lowercase.Checked && !mcb_Number.Checked && !mcb_Special.Checked)
            {
                MetroMessageBox.Show(this, "Check one checkbox first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MetroTrackBar1_Click(object sender, EventArgs e)
        {
            GeneratePassword();
            if (!mcb_Uppercase.Checked && !mcb_Lowercase.Checked && !mcb_Number.Checked && !mcb_Special.Checked)
            {
                MetroMessageBox.Show(this, "Check one checkbox first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //TrackBar Actions - End


        //Generating Password / CheckBoxes Verification - Beginning

        private string GeneratePassword(int length = 1)
        {
            //It can be simpler but idk how
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
                if (mcb_Uppercase.Checked)
                {
                    chars[i] = Upper[random.Next(0, Upper.Length)];
                    //Uppercase + Lowercase
                    if (mcb_Lowercase.Checked)
                    {
                        chars[i] = UpperLower[random.Next(0, UpperLower.Length)];
                    }
                    //Uppercase + Number
                    if (mcb_Number.Checked)
                    {
                        chars[i] = UpperNumber[random.Next(0, UpperNumber.Length)];
                    }
                    //Uppercase + Special
                    if (mcb_Special.Checked)
                    {
                        chars[i] = UpperSpecial[random.Next(0, UpperSpecial.Length)];
                    }
                    //Uppercase + Lowercase + Number
                    if (mcb_Lowercase.Checked && mcb_Number.Checked || mcb_Number.Checked && mcb_Lowercase.Checked)
                    {
                        chars[i] = UpperLowerNumber[random.Next(0, UpperLowerNumber.Length)];
                    }
                    //Uppercase + Lowercase + Special
                    if (mcb_Lowercase.Checked && mcb_Special.Checked || mcb_Special.Checked && mcb_Lowercase.Checked)
                    {
                        chars[i] = UpperLowerSpecial[random.Next(0, UpperLowerSpecial.Length)];
                    }
                    //Uppercase + Number + Special
                    if (mcb_Number.Checked && mcb_Special.Checked || mcb_Special.Checked && mcb_Number.Checked)
                    {
                        chars[i] = UpperNumberSpecial[random.Next(0, UpperNumberSpecial.Length)];
                    }
                    //Uppercase + Lowercase + Number + Special (All)
                    if (mcb_Lowercase.Checked && mcb_Number.Checked && mcb_Special.Checked) //|| mcbLowercase.Checked && mcbSpecial.Checked && mcbNumber.Checked || mcbNumber.Checked && mcbLowercase.Checked && mcbSpecial.Checked || mcbNumber.Checked && mcbSpecial.Checked && mcbLowercase.Checked || mcbSpecial.Checked && mcbNumber.Checked && mcbLowercase.Checked || mcbSpecial.Checked && mcbLowercase.Checked && mcbNumber.Checked)
                    {
                        chars[i] = all[random.Next(0, all.Length)];
                    }
                }
                ///////////////////
                ///  Lowercase  ///
                ///////////////////
                else if (mcb_Lowercase.Checked)
                {
                    chars[i] = Lower[random.Next(0, Lower.Length)];
                    //Lowercase + Number
                    if (mcb_Number.Checked)
                    {
                        chars[i] = LowerNumber[random.Next(0, LowerNumber.Length)];
                    }
                    //Lowercase + Special
                    if (mcb_Special.Checked)
                    {
                        chars[i] = LowerSpecial[random.Next(0, LowerSpecial.Length)];
                    }
                    //Lowercase + Number + Special
                    if (mcb_Number.Checked && mcb_Special.Checked)
                    {
                        chars[i] = LowerNumberSpecial[random.Next(0, LowerNumberSpecial.Length)];
                    }
                }
                ///////////////////
                ///   Number    ///
                ///////////////////
                else if (mcb_Number.Checked)
                {
                    chars[i] = Number[random.Next(0, Number.Length)];

                    if (mcb_Special.Checked)
                    {
                        chars[i] = NumberSpecial[random.Next(0, NumberSpecial.Length)];
                    }
                }

                ///////////////////
                ///   Special   ///
                ///////////////////
                else if (mcb_Special.Checked)
                {
                    chars[i] = Special[random.Next(0, Special.Length)];
                }
            }

            return new string(chars);
        }

        //Generating Password / CheckBoxes Verification - End


        //Theme Change Function - Beginning

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mcmb_Theme.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroThemeStyle.Dark;
                    metroTabControl1.Theme = MetroThemeStyle.Dark;
                    tabGenerate.Theme = MetroThemeStyle.Dark;
                    tabCustomize.Theme = MetroThemeStyle.Dark;
                    mcb_Uppercase.Theme = MetroThemeStyle.Dark;
                    mcb_Lowercase.Theme = MetroThemeStyle.Dark;
                    mcb_Number.Theme = MetroThemeStyle.Dark;
                    mcb_Special.Theme = MetroThemeStyle.Dark;
                    tbar_Generate.Theme = MetroThemeStyle.Dark;
                    txt_Pass.Theme = MetroThemeStyle.Dark;
                    lbl_Text.Theme = MetroThemeStyle.Dark;
                    lbl_Lenght.Theme = MetroThemeStyle.Dark;
                    MetroLabel3.Theme = MetroThemeStyle.Dark;
                    MetroLabel4.Theme = MetroThemeStyle.Dark;
                    lnk_Github_1.Theme = MetroThemeStyle.Dark;
                    lnk_Github_2.Theme = MetroThemeStyle.Dark;
                    btn_Copy.Theme = MetroThemeStyle.Dark;
                    mcmb_Theme.Theme = MetroThemeStyle.Dark;
                    mcmb_Style.Theme = MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroThemeStyle.Light;
                    metroTabControl1.Theme = MetroThemeStyle.Light;
                    tabGenerate.Theme = MetroThemeStyle.Light;
                    tabCustomize.Theme = MetroThemeStyle.Light;
                    mcb_Uppercase.Theme = MetroThemeStyle.Light;
                    mcb_Lowercase.Theme = MetroThemeStyle.Light;
                    mcb_Number.Theme = MetroThemeStyle.Light;
                    mcb_Special.Theme = MetroThemeStyle.Light;
                    tbar_Generate.Theme = MetroThemeStyle.Light;
                    txt_Pass.Theme = MetroThemeStyle.Light;
                    lbl_Text.Theme = MetroThemeStyle.Light;
                    lbl_Lenght.Theme = MetroThemeStyle.Light;
                    MetroLabel3.Theme = MetroThemeStyle.Light;
                    MetroLabel4.Theme = MetroThemeStyle.Light;
                    lnk_Github_1.Theme = MetroThemeStyle.Light;
                    lnk_Github_2.Theme = MetroThemeStyle.Light;
                    btn_Copy.Theme = MetroThemeStyle.Light;
                    mcmb_Theme.Theme = MetroThemeStyle.Light;
                    mcmb_Style.Theme = MetroThemeStyle.Light;
                    break;
            }
        }

        //Theme Change Function - End


        //Style Change Function - Beginning

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            metroTabControl1.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            mcb_Uppercase.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            mcb_Lowercase.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            mcb_Number.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            mcb_Special.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            mcmb_Theme.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            mcmb_Style.Style = (MetroColorStyle)Convert.ToInt32(mcmb_Style.SelectedIndex);
            this.Refresh();
        }

        //Style Change Function - End

        private void mcb_Uppercase_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.Text = GeneratePassword(tbar_Generate.Value);
        }

        private void mcb_Lowercase_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.Text = GeneratePassword(tbar_Generate.Value);
        }

        private void mcb_Number_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.Text = GeneratePassword(tbar_Generate.Value);
        }

        private void mcb_Special_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pass.Text = GeneratePassword(tbar_Generate.Value);
        }
    }
}
