namespace Password_Cs
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabGenerate = new MetroFramework.Controls.MetroTabPage();
            this.mcb_Special = new MetroFramework.Controls.MetroCheckBox();
            this.mcb_Number = new MetroFramework.Controls.MetroCheckBox();
            this.mcb_Lowercase = new MetroFramework.Controls.MetroCheckBox();
            this.mcb_Uppercase = new MetroFramework.Controls.MetroCheckBox();
            this.lnk_Github_1 = new MetroFramework.Controls.MetroLink();
            this.btn_Copy = new MetroFramework.Controls.MetroButton();
            this.txt_Pass = new MetroFramework.Controls.MetroTextBox();
            this.tbar_Generate = new MetroFramework.Controls.MetroTrackBar();
            this.lbl_Lenght = new MetroFramework.Controls.MetroLabel();
            this.lbl_Text = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabCustomize = new MetroFramework.Controls.MetroTabPage();
            this.lnk_Github_2 = new MetroFramework.Controls.MetroLink();
            this.MetroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mcmb_Style = new MetroFramework.Controls.MetroComboBox();
            this.mcmb_Theme = new MetroFramework.Controls.MetroComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tabGenerate.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabCustomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tabGenerate
            // 
            this.tabGenerate.Controls.Add(this.mcb_Special);
            this.tabGenerate.Controls.Add(this.mcb_Number);
            this.tabGenerate.Controls.Add(this.mcb_Lowercase);
            this.tabGenerate.Controls.Add(this.mcb_Uppercase);
            this.tabGenerate.Controls.Add(this.lnk_Github_1);
            this.tabGenerate.Controls.Add(this.btn_Copy);
            this.tabGenerate.Controls.Add(this.txt_Pass);
            this.tabGenerate.Controls.Add(this.tbar_Generate);
            this.tabGenerate.Controls.Add(this.lbl_Lenght);
            this.tabGenerate.Controls.Add(this.lbl_Text);
            this.tabGenerate.HorizontalScrollbarBarColor = true;
            this.tabGenerate.HorizontalScrollbarHighlightOnWheel = false;
            this.tabGenerate.HorizontalScrollbarSize = 10;
            this.tabGenerate.Location = new System.Drawing.Point(4, 38);
            this.tabGenerate.Name = "tabGenerate";
            this.tabGenerate.Size = new System.Drawing.Size(624, 308);
            this.tabGenerate.TabIndex = 1;
            this.tabGenerate.Text = "Generate";
            this.tabGenerate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabGenerate.VerticalScrollbarBarColor = true;
            this.tabGenerate.VerticalScrollbarHighlightOnWheel = false;
            this.tabGenerate.VerticalScrollbarSize = 10;
            // 
            // mcb_Special
            // 
            this.mcb_Special.AutoSize = true;
            this.mcb_Special.Location = new System.Drawing.Point(359, 41);
            this.mcb_Special.Name = "mcb_Special";
            this.mcb_Special.Size = new System.Drawing.Size(131, 17);
            this.mcb_Special.TabIndex = 18;
            this.mcb_Special.Text = "Special Characters";
            this.mcb_Special.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcb_Special.UseSelectable = true;
            this.mcb_Special.CheckedChanged += new System.EventHandler(this.mcb_Special_CheckedChanged);
            // 
            // mcb_Number
            // 
            this.mcb_Number.AutoSize = true;
            this.mcb_Number.Location = new System.Drawing.Point(257, 41);
            this.mcb_Number.Name = "mcb_Number";
            this.mcb_Number.Size = new System.Drawing.Size(78, 17);
            this.mcb_Number.TabIndex = 17;
            this.mcb_Number.Text = "Numbers";
            this.mcb_Number.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcb_Number.UseSelectable = true;
            this.mcb_Number.CheckedChanged += new System.EventHandler(this.mcb_Number_CheckedChanged);
            // 
            // mcb_Lowercase
            // 
            this.mcb_Lowercase.AutoSize = true;
            this.mcb_Lowercase.Location = new System.Drawing.Point(149, 41);
            this.mcb_Lowercase.Name = "mcb_Lowercase";
            this.mcb_Lowercase.Size = new System.Drawing.Size(85, 17);
            this.mcb_Lowercase.TabIndex = 16;
            this.mcb_Lowercase.Text = "Lowercase";
            this.mcb_Lowercase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcb_Lowercase.UseSelectable = true;
            this.mcb_Lowercase.CheckedChanged += new System.EventHandler(this.mcb_Lowercase_CheckedChanged);
            // 
            // mcb_Uppercase
            // 
            this.mcb_Uppercase.AutoSize = true;
            this.mcb_Uppercase.Location = new System.Drawing.Point(42, 41);
            this.mcb_Uppercase.Name = "mcb_Uppercase";
            this.mcb_Uppercase.Size = new System.Drawing.Size(87, 17);
            this.mcb_Uppercase.TabIndex = 15;
            this.mcb_Uppercase.Text = "Uppercase";
            this.mcb_Uppercase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcb_Uppercase.UseSelectable = true;
            this.mcb_Uppercase.CheckedChanged += new System.EventHandler(this.mcb_Uppercase_CheckedChanged);
            // 
            // lnk_Github_1
            // 
            this.lnk_Github_1.Location = new System.Drawing.Point(529, 234);
            this.lnk_Github_1.Name = "lnk_Github_1";
            this.lnk_Github_1.Size = new System.Drawing.Size(99, 39);
            this.lnk_Github_1.TabIndex = 14;
            this.lnk_Github_1.Text = "GitHub";
            this.lnk_Github_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnk_Github_1.UseSelectable = true;
            this.lnk_Github_1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(174, 234);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(146, 39);
            this.btn_Copy.TabIndex = 10;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Copy.UseSelectable = true;
            this.btn_Copy.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_Pass.CustomButton.Image = null;
            this.txt_Pass.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txt_Pass.CustomButton.Name = "";
            this.txt_Pass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pass.CustomButton.TabIndex = 1;
            this.txt_Pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pass.CustomButton.UseSelectable = true;
            this.txt_Pass.CustomButton.Visible = false;
            this.txt_Pass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_Pass.ForeColor = System.Drawing.Color.Coral;
            this.txt_Pass.Lines = new string[0];
            this.txt_Pass.Location = new System.Drawing.Point(42, 173);
            this.txt_Pass.MaxLength = 32767;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '\0';
            this.txt_Pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pass.SelectedText = "";
            this.txt_Pass.SelectionLength = 0;
            this.txt_Pass.SelectionStart = 0;
            this.txt_Pass.ShortcutsEnabled = true;
            this.txt_Pass.Size = new System.Drawing.Size(448, 25);
            this.txt_Pass.TabIndex = 9;
            this.txt_Pass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_Pass.UseSelectable = true;
            this.txt_Pass.WaterMarkColor = System.Drawing.Color.White;
            this.txt_Pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbar_Generate
            // 
            this.tbar_Generate.BackColor = System.Drawing.Color.Transparent;
            this.tbar_Generate.LargeChange = 1;
            this.tbar_Generate.Location = new System.Drawing.Point(42, 117);
            this.tbar_Generate.Maximum = 50;
            this.tbar_Generate.Minimum = 5;
            this.tbar_Generate.Name = "tbar_Generate";
            this.tbar_Generate.Size = new System.Drawing.Size(448, 23);
            this.tbar_Generate.TabIndex = 8;
            this.tbar_Generate.Text = "MetroTrackBar1";
            this.tbar_Generate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbar_Generate.Value = 5;
            this.tbar_Generate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MetroTrackBar1_Scroll);
            this.tbar_Generate.Click += new System.EventHandler(this.MetroTrackBar1_Click);
            // 
            // lbl_Lenght
            // 
            this.lbl_Lenght.AutoSize = true;
            this.lbl_Lenght.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Lenght.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lenght.Location = new System.Drawing.Point(274, 82);
            this.lbl_Lenght.Name = "lbl_Lenght";
            this.lbl_Lenght.Size = new System.Drawing.Size(0, 0);
            this.lbl_Lenght.TabIndex = 7;
            this.lbl_Lenght.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Text.ForeColor = System.Drawing.Color.Black;
            this.lbl_Text.Location = new System.Drawing.Point(208, 82);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(58, 20);
            this.lbl_Text.TabIndex = 6;
            this.lbl_Text.Text = "Lenght";
            this.lbl_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabGenerate);
            this.metroTabControl1.Controls.Add(this.tabCustomize);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(632, 350);
            this.metroTabControl1.TabIndex = 13;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabCustomize
            // 
            this.tabCustomize.Controls.Add(this.lnk_Github_2);
            this.tabCustomize.Controls.Add(this.MetroLabel4);
            this.tabCustomize.Controls.Add(this.MetroLabel3);
            this.tabCustomize.Controls.Add(this.mcmb_Style);
            this.tabCustomize.Controls.Add(this.mcmb_Theme);
            this.tabCustomize.HorizontalScrollbarBarColor = true;
            this.tabCustomize.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCustomize.HorizontalScrollbarSize = 10;
            this.tabCustomize.Location = new System.Drawing.Point(4, 38);
            this.tabCustomize.Name = "tabCustomize";
            this.tabCustomize.Size = new System.Drawing.Size(624, 308);
            this.tabCustomize.TabIndex = 5;
            this.tabCustomize.Text = "Customize";
            this.tabCustomize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabCustomize.VerticalScrollbarBarColor = true;
            this.tabCustomize.VerticalScrollbarHighlightOnWheel = false;
            this.tabCustomize.VerticalScrollbarSize = 10;
            // 
            // lnk_Github_2
            // 
            this.lnk_Github_2.Location = new System.Drawing.Point(529, 234);
            this.lnk_Github_2.Name = "lnk_Github_2";
            this.lnk_Github_2.Size = new System.Drawing.Size(99, 39);
            this.lnk_Github_2.TabIndex = 15;
            this.lnk_Github_2.Text = "GitHub";
            this.lnk_Github_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lnk_Github_2.UseSelectable = true;
            this.lnk_Github_2.Click += new System.EventHandler(this.MetroLink2_Click);
            // 
            // MetroLabel4
            // 
            this.MetroLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroLabel4.Location = new System.Drawing.Point(0, 93);
            this.MetroLabel4.Name = "MetroLabel4";
            this.MetroLabel4.Size = new System.Drawing.Size(65, 30);
            this.MetroLabel4.TabIndex = 5;
            this.MetroLabel4.Text = "Style";
            this.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroLabel3
            // 
            this.MetroLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.MetroLabel3.Location = new System.Drawing.Point(0, 50);
            this.MetroLabel3.Name = "MetroLabel3";
            this.MetroLabel3.Size = new System.Drawing.Size(92, 30);
            this.MetroLabel3.TabIndex = 4;
            this.MetroLabel3.Text = "Theme";
            this.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mcmb_Style
            // 
            this.mcmb_Style.FormattingEnabled = true;
            this.mcmb_Style.ItemHeight = 24;
            this.mcmb_Style.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.mcmb_Style.Location = new System.Drawing.Point(98, 93);
            this.mcmb_Style.Name = "mcmb_Style";
            this.mcmb_Style.Size = new System.Drawing.Size(121, 30);
            this.mcmb_Style.TabIndex = 3;
            this.mcmb_Style.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcmb_Style.UseSelectable = true;
            this.mcmb_Style.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // mcmb_Theme
            // 
            this.mcmb_Theme.FormattingEnabled = true;
            this.mcmb_Theme.ItemHeight = 24;
            this.mcmb_Theme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.mcmb_Theme.Location = new System.Drawing.Point(98, 50);
            this.mcmb_Theme.Name = "mcmb_Theme";
            this.mcmb_Theme.Size = new System.Drawing.Size(121, 30);
            this.mcmb_Theme.Style = MetroFramework.MetroColorStyle.Silver;
            this.mcmb_Theme.TabIndex = 2;
            this.mcmb_Theme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcmb_Theme.UseSelectable = true;
            this.mcmb_Theme.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 416);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Password Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tabGenerate.ResumeLayout(false);
            this.tabGenerate.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabCustomize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabPage tabGenerate;
        private MetroFramework.Controls.MetroCheckBox mcb_Special;
        private MetroFramework.Controls.MetroCheckBox mcb_Number;
        private MetroFramework.Controls.MetroCheckBox mcb_Lowercase;
        private MetroFramework.Controls.MetroCheckBox mcb_Uppercase;
        private MetroFramework.Controls.MetroLink lnk_Github_1;
        internal MetroFramework.Controls.MetroButton btn_Copy;
        internal MetroFramework.Controls.MetroTextBox txt_Pass;
        internal MetroFramework.Controls.MetroTrackBar tbar_Generate;
        public MetroFramework.Controls.MetroLabel lbl_Lenght;
        internal MetroFramework.Controls.MetroLabel lbl_Text;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabCustomize;
        private MetroFramework.Controls.MetroLink lnk_Github_2;
        private MetroFramework.Controls.MetroLabel MetroLabel4;
        private MetroFramework.Controls.MetroLabel MetroLabel3;
        private MetroFramework.Controls.MetroComboBox mcmb_Style;
        private MetroFramework.Controls.MetroComboBox mcmb_Theme;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}

