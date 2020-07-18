namespace Password_Cs
{
    partial class Form1
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
            this.MetroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MetroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.MetroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.MetroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mcbSpecial = new MetroFramework.Controls.MetroCheckBox();
            this.mcbNumber = new MetroFramework.Controls.MetroCheckBox();
            this.mcbLowercase = new MetroFramework.Controls.MetroCheckBox();
            this.mcbUppercase = new MetroFramework.Controls.MetroCheckBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.MetroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // MetroLabel1
            // 
            this.MetroLabel1.AutoSize = true;
            this.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetroLabel1.ForeColor = System.Drawing.Color.Black;
            this.MetroLabel1.Location = new System.Drawing.Point(208, 82);
            this.MetroLabel1.Name = "MetroLabel1";
            this.MetroLabel1.Size = new System.Drawing.Size(58, 20);
            this.MetroLabel1.TabIndex = 6;
            this.MetroLabel1.Text = "Lenght";
            this.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroLabel2
            // 
            this.MetroLabel2.AutoSize = true;
            this.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetroLabel2.ForeColor = System.Drawing.Color.Black;
            this.MetroLabel2.Location = new System.Drawing.Point(274, 82);
            this.MetroLabel2.Name = "MetroLabel2";
            this.MetroLabel2.Size = new System.Drawing.Size(0, 0);
            this.MetroLabel2.TabIndex = 7;
            this.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroTrackBar1
            // 
            this.MetroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.MetroTrackBar1.LargeChange = 1;
            this.MetroTrackBar1.Location = new System.Drawing.Point(42, 117);
            this.MetroTrackBar1.Maximum = 50;
            this.MetroTrackBar1.Minimum = 5;
            this.MetroTrackBar1.Name = "MetroTrackBar1";
            this.MetroTrackBar1.Size = new System.Drawing.Size(432, 23);
            this.MetroTrackBar1.TabIndex = 8;
            this.MetroTrackBar1.Text = "MetroTrackBar1";
            this.MetroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTrackBar1.Value = 5;
            this.MetroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MetroTrackBar1_Scroll);
            this.MetroTrackBar1.Click += new System.EventHandler(this.MetroTrackBar1_Click);
            // 
            // MetroTextBox1
            // 
            this.MetroTextBox1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MetroTextBox1.CustomButton.Image = null;
            this.MetroTextBox1.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.MetroTextBox1.CustomButton.Name = "";
            this.MetroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroTextBox1.CustomButton.TabIndex = 1;
            this.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetroTextBox1.CustomButton.UseSelectable = true;
            this.MetroTextBox1.CustomButton.Visible = false;
            this.MetroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.MetroTextBox1.ForeColor = System.Drawing.Color.Coral;
            this.MetroTextBox1.Lines = new string[0];
            this.MetroTextBox1.Location = new System.Drawing.Point(42, 173);
            this.MetroTextBox1.MaxLength = 32767;
            this.MetroTextBox1.Name = "MetroTextBox1";
            this.MetroTextBox1.PasswordChar = '\0';
            this.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBox1.SelectedText = "";
            this.MetroTextBox1.SelectionLength = 0;
            this.MetroTextBox1.SelectionStart = 0;
            this.MetroTextBox1.ShortcutsEnabled = true;
            this.MetroTextBox1.Size = new System.Drawing.Size(432, 25);
            this.MetroTextBox1.TabIndex = 9;
            this.MetroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTextBox1.UseSelectable = true;
            this.MetroTextBox1.WaterMarkColor = System.Drawing.Color.White;
            this.MetroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroButton1
            // 
            this.MetroButton1.Location = new System.Drawing.Point(208, 234);
            this.MetroButton1.Name = "MetroButton1";
            this.MetroButton1.Size = new System.Drawing.Size(99, 39);
            this.MetroButton1.TabIndex = 10;
            this.MetroButton1.Text = "Copy";
            this.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroButton1.UseSelectable = true;
            this.MetroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(0, 0);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 0;
            this.metroButton3.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(632, 350);
            this.metroTabControl1.TabIndex = 13;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mcbSpecial);
            this.metroTabPage1.Controls.Add(this.mcbNumber);
            this.metroTabPage1.Controls.Add(this.mcbLowercase);
            this.metroTabPage1.Controls.Add(this.mcbUppercase);
            this.metroTabPage1.Controls.Add(this.metroLink1);
            this.metroTabPage1.Controls.Add(this.MetroButton1);
            this.metroTabPage1.Controls.Add(this.MetroTextBox1);
            this.metroTabPage1.Controls.Add(this.MetroTrackBar1);
            this.metroTabPage1.Controls.Add(this.MetroLabel2);
            this.metroTabPage1.Controls.Add(this.MetroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(624, 308);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Main";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mcbSpecial
            // 
            this.mcbSpecial.AutoSize = true;
            this.mcbSpecial.Location = new System.Drawing.Point(359, 41);
            this.mcbSpecial.Name = "mcbSpecial";
            this.mcbSpecial.Size = new System.Drawing.Size(131, 17);
            this.mcbSpecial.TabIndex = 18;
            this.mcbSpecial.Text = "Special Characters";
            this.mcbSpecial.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcbSpecial.UseSelectable = true;
            // 
            // mcbNumber
            // 
            this.mcbNumber.AutoSize = true;
            this.mcbNumber.Location = new System.Drawing.Point(257, 41);
            this.mcbNumber.Name = "mcbNumber";
            this.mcbNumber.Size = new System.Drawing.Size(78, 17);
            this.mcbNumber.TabIndex = 17;
            this.mcbNumber.Text = "Numbers";
            this.mcbNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcbNumber.UseSelectable = true;
            // 
            // mcbLowercase
            // 
            this.mcbLowercase.AutoSize = true;
            this.mcbLowercase.Location = new System.Drawing.Point(149, 41);
            this.mcbLowercase.Name = "mcbLowercase";
            this.mcbLowercase.Size = new System.Drawing.Size(85, 17);
            this.mcbLowercase.TabIndex = 16;
            this.mcbLowercase.Text = "Lowercase";
            this.mcbLowercase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcbLowercase.UseSelectable = true;
            // 
            // mcbUppercase
            // 
            this.mcbUppercase.AutoSize = true;
            this.mcbUppercase.Location = new System.Drawing.Point(42, 41);
            this.mcbUppercase.Name = "mcbUppercase";
            this.mcbUppercase.Size = new System.Drawing.Size(87, 17);
            this.mcbUppercase.TabIndex = 15;
            this.mcbUppercase.Text = "Uppercase";
            this.mcbUppercase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mcbUppercase.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(529, 234);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(99, 39);
            this.metroLink1.TabIndex = 14;
            this.metroLink1.Text = "GitHub";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLink2);
            this.metroTabPage2.Controls.Add(this.MetroLabel4);
            this.metroTabPage2.Controls.Add(this.MetroLabel3);
            this.metroTabPage2.Controls.Add(this.metroComboBox2);
            this.metroTabPage2.Controls.Add(this.metroComboBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(624, 308);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Customize";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(529, 234);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(99, 39);
            this.metroLink2.TabIndex = 15;
            this.metroLink2.Text = "GitHub";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink2.UseSelectable = true;
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
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 24;
            this.metroComboBox2.Items.AddRange(new object[] {
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
            this.metroComboBox2.Location = new System.Drawing.Point(98, 93);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.metroComboBox1.Location = new System.Drawing.Point(98, 50);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 30);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 416);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Password Generator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal MetroFramework.Controls.MetroLabel MetroLabel1;
        internal MetroFramework.Controls.MetroTrackBar MetroTrackBar1;
        internal MetroFramework.Controls.MetroTextBox MetroTextBox1;
        internal MetroFramework.Controls.MetroButton MetroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel MetroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel MetroLabel4;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.Timer timer1;
        public MetroFramework.Controls.MetroLabel MetroLabel2;
        private MetroFramework.Controls.MetroCheckBox mcbSpecial;
        private MetroFramework.Controls.MetroCheckBox mcbNumber;
        private MetroFramework.Controls.MetroCheckBox mcbLowercase;
        private MetroFramework.Controls.MetroCheckBox mcbUppercase;
    }
}

