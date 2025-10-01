namespace WinFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bInterval = new RadioButton();
            bChord = new RadioButton();
            panel2 = new Panel();
            piano23 = new Button();
            piano24 = new Button();
            piano21 = new Button();
            piano19 = new Button();
            piano20 = new Button();
            piano18 = new Button();
            piano16 = new Button();
            piano14 = new Button();
            piano7 = new Button();
            piano17 = new Button();
            piano9 = new Button();
            piano13 = new Button();
            piano4 = new Button();
            piano15 = new Button();
            piano11 = new Button();
            piano2 = new Button();
            piano1 = new Button();
            piano3 = new Button();
            piano5 = new Button();
            piano6 = new Button();
            piano8 = new Button();
            piano10 = new Button();
            piano12 = new Button();
            piano22 = new Button();
            panel3 = new Panel();
            piano25 = new Button();
            bScale = new RadioButton();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            pbBlueScreen = new PictureBox();
            pictureBox1 = new PictureBox();
            lNote = new Label();
            lCategory = new Label();
            lMode = new Label();
            panel4 = new Panel();
            radioButton3 = new RadioButton();
            panel1 = new Panel();
            bB = new RadioButton();
            bC = new RadioButton();
            bA = new RadioButton();
            bD = new RadioButton();
            bG = new RadioButton();
            bE = new RadioButton();
            bF = new RadioButton();
            panelCategory = new Panel();
            bAbout = new Button();
            button1 = new Button();
            radioButton4 = new RadioButton();
            bGrand = new RadioButton();
            bWurlitzer = new RadioButton();
            bElectric = new RadioButton();
            panel5 = new Panel();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton8 = new RadioButton();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBlueScreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // bInterval
            // 
            bInterval.Anchor = AnchorStyles.None;
            bInterval.Appearance = Appearance.Button;
            bInterval.BackColor = Color.FromArgb(163, 162, 167);
            bInterval.FlatAppearance.BorderColor = Color.Gainsboro;
            bInterval.FlatAppearance.BorderSize = 0;
            bInterval.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bInterval.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            bInterval.FlatStyle = FlatStyle.Flat;
            bInterval.Font = new Font("Mongolian Baiti", 15.75F);
            bInterval.ForeColor = Color.Black;
            bInterval.Location = new Point(19, 209);
            bInterval.Name = "bInterval";
            bInterval.Size = new Size(100, 48);
            bInterval.TabIndex = 61;
            bInterval.Text = "Interval";
            bInterval.TextAlign = ContentAlignment.MiddleCenter;
            bInterval.UseVisualStyleBackColor = false;
            bInterval.CheckedChanged += ModeCheckedChanged;
            bInterval.Click += ModeClick;
            // 
            // bChord
            // 
            bChord.Anchor = AnchorStyles.None;
            bChord.Appearance = Appearance.Button;
            bChord.BackColor = Color.FromArgb(163, 162, 167);
            bChord.FlatAppearance.BorderColor = Color.Gainsboro;
            bChord.FlatAppearance.BorderSize = 0;
            bChord.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bChord.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            bChord.FlatStyle = FlatStyle.Flat;
            bChord.Font = new Font("Mongolian Baiti", 15.75F);
            bChord.ForeColor = Color.Black;
            bChord.Location = new Point(19, 110);
            bChord.Name = "bChord";
            bChord.Size = new Size(100, 48);
            bChord.TabIndex = 62;
            bChord.Text = "Chord";
            bChord.TextAlign = ContentAlignment.MiddleCenter;
            bChord.UseVisualStyleBackColor = false;
            bChord.CheckedChanged += ModeCheckedChanged;
            bChord.Click += ModeClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(piano23);
            panel2.Controls.Add(piano24);
            panel2.Controls.Add(piano21);
            panel2.Controls.Add(piano19);
            panel2.Controls.Add(piano20);
            panel2.Controls.Add(piano18);
            panel2.Controls.Add(piano16);
            panel2.Controls.Add(piano14);
            panel2.Controls.Add(piano7);
            panel2.Controls.Add(piano17);
            panel2.Controls.Add(piano9);
            panel2.Controls.Add(piano13);
            panel2.Controls.Add(piano4);
            panel2.Controls.Add(piano15);
            panel2.Controls.Add(piano11);
            panel2.Controls.Add(piano2);
            panel2.Controls.Add(piano1);
            panel2.Controls.Add(piano3);
            panel2.Controls.Add(piano5);
            panel2.Controls.Add(piano6);
            panel2.Controls.Add(piano8);
            panel2.Controls.Add(piano10);
            panel2.Controls.Add(piano12);
            panel2.Controls.Add(piano22);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(413, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 283);
            panel2.TabIndex = 100;
            // 
            // piano23
            // 
            piano23.Anchor = AnchorStyles.Left;
            piano23.BackColor = Color.FromArgb(33, 32, 37);
            piano23.FlatAppearance.BorderColor = Color.Black;
            piano23.FlatAppearance.BorderSize = 2;
            piano23.FlatStyle = FlatStyle.Flat;
            piano23.ForeColor = Color.FromArgb(33, 32, 37);
            piano23.Location = new Point(792, 12);
            piano23.Margin = new Padding(4, 3, 4, 3);
            piano23.Name = "piano23";
            piano23.Size = new Size(32, 166);
            piano23.TabIndex = 112;
            piano23.Tag = "Bb4";
            piano23.UseVisualStyleBackColor = false;
            piano23.Click += PianoKeyClick;
            // 
            // piano24
            // 
            piano24.Anchor = AnchorStyles.Left;
            piano24.BackColor = Color.FromArgb(213, 214, 216);
            piano24.FlatAppearance.BorderColor = Color.Black;
            piano24.FlatAppearance.BorderSize = 2;
            piano24.FlatStyle = FlatStyle.Flat;
            piano24.ForeColor = Color.Transparent;
            piano24.Location = new Point(809, 12);
            piano24.Margin = new Padding(4, 3, 4, 3);
            piano24.Name = "piano24";
            piano24.Size = new Size(61, 259);
            piano24.TabIndex = 109;
            piano24.Tag = "B4";
            piano24.UseVisualStyleBackColor = false;
            piano24.Click += PianoKeyClick;
            // 
            // piano21
            // 
            piano21.Anchor = AnchorStyles.Left;
            piano21.BackColor = Color.FromArgb(33, 32, 37);
            piano21.FlatAppearance.BorderColor = Color.Black;
            piano21.FlatAppearance.BorderSize = 2;
            piano21.FlatStyle = FlatStyle.Flat;
            piano21.ForeColor = Color.FromArgb(33, 32, 37);
            piano21.Location = new Point(731, 12);
            piano21.Margin = new Padding(4, 3, 4, 3);
            piano21.Name = "piano21";
            piano21.Size = new Size(32, 166);
            piano21.TabIndex = 111;
            piano21.Tag = "Ab4";
            piano21.UseVisualStyleBackColor = false;
            piano21.Click += PianoKeyClick;
            // 
            // piano19
            // 
            piano19.Anchor = AnchorStyles.Left;
            piano19.BackColor = Color.FromArgb(33, 32, 37);
            piano19.FlatAppearance.BorderColor = Color.Black;
            piano19.FlatAppearance.BorderSize = 2;
            piano19.FlatStyle = FlatStyle.Flat;
            piano19.ForeColor = Color.FromArgb(33, 32, 37);
            piano19.Location = new Point(670, 12);
            piano19.Margin = new Padding(4, 3, 4, 3);
            piano19.Name = "piano19";
            piano19.Size = new Size(32, 166);
            piano19.TabIndex = 110;
            piano19.Tag = "Gb4";
            piano19.UseVisualStyleBackColor = false;
            piano19.Click += PianoKeyClick;
            // 
            // piano20
            // 
            piano20.Anchor = AnchorStyles.Left;
            piano20.BackColor = Color.FromArgb(213, 214, 216);
            piano20.FlatAppearance.BorderColor = Color.Black;
            piano20.FlatAppearance.BorderSize = 2;
            piano20.FlatStyle = FlatStyle.Flat;
            piano20.ForeColor = Color.Transparent;
            piano20.Location = new Point(687, 12);
            piano20.Margin = new Padding(4, 3, 4, 3);
            piano20.Name = "piano20";
            piano20.Size = new Size(61, 259);
            piano20.TabIndex = 107;
            piano20.Tag = "G4";
            piano20.UseVisualStyleBackColor = false;
            piano20.Click += PianoKeyClick;
            // 
            // piano18
            // 
            piano18.Anchor = AnchorStyles.Left;
            piano18.BackColor = Color.FromArgb(213, 214, 216);
            piano18.FlatAppearance.BorderColor = Color.Black;
            piano18.FlatAppearance.BorderSize = 2;
            piano18.FlatStyle = FlatStyle.Flat;
            piano18.ForeColor = Color.Transparent;
            piano18.Location = new Point(626, 12);
            piano18.Margin = new Padding(4, 3, 4, 3);
            piano18.Name = "piano18";
            piano18.Size = new Size(61, 259);
            piano18.TabIndex = 106;
            piano18.Tag = "F4";
            piano18.UseVisualStyleBackColor = false;
            piano18.Click += PianoKeyClick;
            // 
            // piano16
            // 
            piano16.Anchor = AnchorStyles.Left;
            piano16.BackColor = Color.FromArgb(33, 32, 37);
            piano16.FlatAppearance.BorderColor = Color.Black;
            piano16.FlatAppearance.BorderSize = 2;
            piano16.FlatStyle = FlatStyle.Flat;
            piano16.ForeColor = Color.FromArgb(33, 32, 37);
            piano16.Location = new Point(548, 12);
            piano16.Margin = new Padding(4, 3, 4, 3);
            piano16.Name = "piano16";
            piano16.Size = new Size(32, 166);
            piano16.TabIndex = 105;
            piano16.Tag = "Eb4";
            piano16.UseVisualStyleBackColor = false;
            piano16.Click += PianoKeyClick;
            // 
            // piano14
            // 
            piano14.Anchor = AnchorStyles.Left;
            piano14.BackColor = Color.FromArgb(33, 32, 37);
            piano14.FlatAppearance.BorderColor = Color.Black;
            piano14.FlatAppearance.BorderSize = 2;
            piano14.FlatStyle = FlatStyle.Flat;
            piano14.ForeColor = Color.FromArgb(33, 32, 37);
            piano14.Location = new Point(487, 12);
            piano14.Margin = new Padding(4, 3, 4, 3);
            piano14.Name = "piano14";
            piano14.Size = new Size(32, 166);
            piano14.TabIndex = 104;
            piano14.Tag = "Db4";
            piano14.UseVisualStyleBackColor = false;
            piano14.Click += PianoKeyClick;
            // 
            // piano7
            // 
            piano7.Anchor = AnchorStyles.Left;
            piano7.BackColor = Color.FromArgb(33, 32, 37);
            piano7.FlatAppearance.BorderColor = Color.Black;
            piano7.FlatAppearance.BorderSize = 2;
            piano7.FlatStyle = FlatStyle.Flat;
            piano7.ForeColor = Color.FromArgb(33, 32, 37);
            piano7.Location = new Point(243, 12);
            piano7.Margin = new Padding(4, 3, 4, 3);
            piano7.Name = "piano7";
            piano7.Size = new Size(32, 166);
            piano7.TabIndex = 98;
            piano7.Tag = "Gb3";
            piano7.UseVisualStyleBackColor = false;
            piano7.Click += PianoKeyClick;
            // 
            // piano17
            // 
            piano17.Anchor = AnchorStyles.Left;
            piano17.BackColor = Color.FromArgb(213, 214, 216);
            piano17.FlatAppearance.BorderColor = Color.Black;
            piano17.FlatAppearance.BorderSize = 2;
            piano17.FlatStyle = FlatStyle.Flat;
            piano17.ForeColor = Color.Transparent;
            piano17.Location = new Point(565, 12);
            piano17.Margin = new Padding(4, 3, 4, 3);
            piano17.Name = "piano17";
            piano17.Size = new Size(61, 259);
            piano17.TabIndex = 103;
            piano17.Tag = "E4";
            piano17.UseVisualStyleBackColor = false;
            piano17.Click += PianoKeyClick;
            // 
            // piano9
            // 
            piano9.Anchor = AnchorStyles.Left;
            piano9.BackColor = Color.FromArgb(33, 32, 37);
            piano9.FlatAppearance.BorderColor = Color.Black;
            piano9.FlatAppearance.BorderSize = 2;
            piano9.FlatStyle = FlatStyle.Flat;
            piano9.ForeColor = Color.FromArgb(33, 32, 37);
            piano9.Location = new Point(304, 12);
            piano9.Margin = new Padding(4, 3, 4, 3);
            piano9.Name = "piano9";
            piano9.Size = new Size(32, 166);
            piano9.TabIndex = 99;
            piano9.Tag = "Ab3";
            piano9.UseVisualStyleBackColor = false;
            piano9.Click += PianoKeyClick;
            // 
            // piano13
            // 
            piano13.Anchor = AnchorStyles.Left;
            piano13.BackColor = Color.FromArgb(213, 214, 216);
            piano13.FlatAppearance.BorderColor = Color.Black;
            piano13.FlatAppearance.BorderSize = 2;
            piano13.FlatStyle = FlatStyle.Flat;
            piano13.ForeColor = Color.Transparent;
            piano13.Location = new Point(443, 12);
            piano13.Margin = new Padding(4, 3, 4, 3);
            piano13.Name = "piano13";
            piano13.Size = new Size(61, 259);
            piano13.TabIndex = 102;
            piano13.Tag = "C4";
            piano13.UseVisualStyleBackColor = false;
            piano13.Click += PianoKeyClick;
            // 
            // piano4
            // 
            piano4.Anchor = AnchorStyles.Left;
            piano4.BackColor = Color.FromArgb(33, 32, 37);
            piano4.FlatAppearance.BorderColor = Color.Black;
            piano4.FlatAppearance.BorderSize = 2;
            piano4.FlatStyle = FlatStyle.Flat;
            piano4.ForeColor = Color.FromArgb(33, 32, 37);
            piano4.Location = new Point(122, 12);
            piano4.Margin = new Padding(4, 3, 4, 3);
            piano4.Name = "piano4";
            piano4.Size = new Size(32, 166);
            piano4.TabIndex = 97;
            piano4.Tag = "Eb3";
            piano4.UseVisualStyleBackColor = false;
            piano4.Click += PianoKeyClick;
            // 
            // piano15
            // 
            piano15.Anchor = AnchorStyles.Left;
            piano15.BackColor = Color.FromArgb(213, 214, 216);
            piano15.FlatAppearance.BorderColor = Color.Black;
            piano15.FlatAppearance.BorderSize = 2;
            piano15.FlatStyle = FlatStyle.Flat;
            piano15.ForeColor = Color.Transparent;
            piano15.Location = new Point(504, 12);
            piano15.Margin = new Padding(4, 3, 4, 3);
            piano15.Name = "piano15";
            piano15.Size = new Size(61, 259);
            piano15.TabIndex = 101;
            piano15.Tag = "D4";
            piano15.UseVisualStyleBackColor = false;
            piano15.Click += PianoKeyClick;
            // 
            // piano11
            // 
            piano11.Anchor = AnchorStyles.Left;
            piano11.BackColor = Color.FromArgb(33, 32, 37);
            piano11.FlatAppearance.BorderColor = Color.Black;
            piano11.FlatAppearance.BorderSize = 2;
            piano11.FlatStyle = FlatStyle.Flat;
            piano11.ForeColor = Color.FromArgb(33, 32, 37);
            piano11.Location = new Point(366, 12);
            piano11.Margin = new Padding(4, 3, 4, 3);
            piano11.Name = "piano11";
            piano11.Size = new Size(32, 166);
            piano11.TabIndex = 100;
            piano11.Tag = "Bb3";
            piano11.UseVisualStyleBackColor = false;
            piano11.Click += PianoKeyClick;
            // 
            // piano2
            // 
            piano2.Anchor = AnchorStyles.Left;
            piano2.BackColor = Color.FromArgb(33, 32, 37);
            piano2.FlatAppearance.BorderColor = Color.Black;
            piano2.FlatAppearance.BorderSize = 2;
            piano2.FlatStyle = FlatStyle.Flat;
            piano2.ForeColor = Color.FromArgb(33, 32, 37);
            piano2.Location = new Point(60, 12);
            piano2.Margin = new Padding(4, 3, 4, 3);
            piano2.Name = "piano2";
            piano2.Size = new Size(32, 166);
            piano2.TabIndex = 96;
            piano2.Tag = "Db3";
            piano2.UseVisualStyleBackColor = false;
            piano2.Click += PianoKeyClick;
            // 
            // piano1
            // 
            piano1.Anchor = AnchorStyles.Left;
            piano1.BackColor = Color.FromArgb(213, 214, 216);
            piano1.FlatAppearance.BorderColor = Color.Black;
            piano1.FlatAppearance.BorderSize = 2;
            piano1.FlatStyle = FlatStyle.Flat;
            piano1.ForeColor = Color.Transparent;
            piano1.Location = new Point(16, 12);
            piano1.Margin = new Padding(4, 3, 4, 3);
            piano1.Name = "piano1";
            piano1.Size = new Size(61, 259);
            piano1.TabIndex = 90;
            piano1.Tag = "C3";
            piano1.UseVisualStyleBackColor = false;
            piano1.Click += PianoKeyClick;
            // 
            // piano3
            // 
            piano3.Anchor = AnchorStyles.Left;
            piano3.BackColor = Color.FromArgb(213, 214, 216);
            piano3.FlatAppearance.BorderColor = Color.Black;
            piano3.FlatAppearance.BorderSize = 2;
            piano3.FlatStyle = FlatStyle.Flat;
            piano3.ForeColor = Color.Transparent;
            piano3.Location = new Point(77, 12);
            piano3.Margin = new Padding(4, 3, 4, 3);
            piano3.Name = "piano3";
            piano3.Size = new Size(61, 259);
            piano3.TabIndex = 89;
            piano3.Tag = "D3";
            piano3.UseVisualStyleBackColor = false;
            piano3.Click += PianoKeyClick;
            // 
            // piano5
            // 
            piano5.Anchor = AnchorStyles.Left;
            piano5.BackColor = Color.FromArgb(213, 214, 216);
            piano5.FlatAppearance.BorderColor = Color.Black;
            piano5.FlatAppearance.BorderSize = 2;
            piano5.FlatStyle = FlatStyle.Flat;
            piano5.ForeColor = Color.Transparent;
            piano5.Location = new Point(138, 12);
            piano5.Margin = new Padding(4, 3, 4, 3);
            piano5.Name = "piano5";
            piano5.Size = new Size(61, 259);
            piano5.TabIndex = 91;
            piano5.Tag = "E3";
            piano5.UseVisualStyleBackColor = false;
            piano5.Click += PianoKeyClick;
            // 
            // piano6
            // 
            piano6.Anchor = AnchorStyles.Left;
            piano6.BackColor = Color.FromArgb(213, 214, 216);
            piano6.FlatAppearance.BorderColor = Color.Black;
            piano6.FlatAppearance.BorderSize = 2;
            piano6.FlatStyle = FlatStyle.Flat;
            piano6.ForeColor = Color.Transparent;
            piano6.Location = new Point(199, 12);
            piano6.Margin = new Padding(4, 3, 4, 3);
            piano6.Name = "piano6";
            piano6.Size = new Size(61, 259);
            piano6.TabIndex = 92;
            piano6.Tag = "F3";
            piano6.UseVisualStyleBackColor = false;
            piano6.Click += PianoKeyClick;
            // 
            // piano8
            // 
            piano8.Anchor = AnchorStyles.Left;
            piano8.BackColor = Color.FromArgb(213, 214, 216);
            piano8.FlatAppearance.BorderColor = Color.Black;
            piano8.FlatAppearance.BorderSize = 2;
            piano8.FlatStyle = FlatStyle.Flat;
            piano8.ForeColor = Color.Transparent;
            piano8.Location = new Point(260, 12);
            piano8.Margin = new Padding(4, 3, 4, 3);
            piano8.Name = "piano8";
            piano8.Size = new Size(61, 259);
            piano8.TabIndex = 93;
            piano8.Tag = "G3";
            piano8.UseVisualStyleBackColor = false;
            piano8.Click += PianoKeyClick;
            // 
            // piano10
            // 
            piano10.Anchor = AnchorStyles.Left;
            piano10.BackColor = Color.FromArgb(213, 214, 216);
            piano10.FlatAppearance.BorderColor = Color.Black;
            piano10.FlatAppearance.BorderSize = 2;
            piano10.FlatStyle = FlatStyle.Flat;
            piano10.ForeColor = Color.Transparent;
            piano10.Location = new Point(321, 12);
            piano10.Margin = new Padding(4, 3, 4, 3);
            piano10.Name = "piano10";
            piano10.Size = new Size(61, 259);
            piano10.TabIndex = 94;
            piano10.Tag = "A3";
            piano10.UseVisualStyleBackColor = false;
            piano10.Click += PianoKeyClick;
            // 
            // piano12
            // 
            piano12.Anchor = AnchorStyles.Left;
            piano12.BackColor = Color.FromArgb(213, 214, 216);
            piano12.FlatAppearance.BorderColor = Color.Black;
            piano12.FlatAppearance.BorderSize = 2;
            piano12.FlatStyle = FlatStyle.Flat;
            piano12.ForeColor = Color.Transparent;
            piano12.Location = new Point(382, 12);
            piano12.Margin = new Padding(4, 3, 4, 3);
            piano12.Name = "piano12";
            piano12.Size = new Size(61, 259);
            piano12.TabIndex = 95;
            piano12.Tag = "B3";
            piano12.UseVisualStyleBackColor = false;
            piano12.Click += PianoKeyClick;
            // 
            // piano22
            // 
            piano22.Anchor = AnchorStyles.Left;
            piano22.BackColor = Color.FromArgb(213, 214, 216);
            piano22.FlatAppearance.BorderColor = Color.Black;
            piano22.FlatAppearance.BorderSize = 2;
            piano22.FlatStyle = FlatStyle.Flat;
            piano22.ForeColor = Color.Transparent;
            piano22.Location = new Point(748, 12);
            piano22.Margin = new Padding(4, 3, 4, 3);
            piano22.Name = "piano22";
            piano22.Size = new Size(61, 259);
            piano22.TabIndex = 108;
            piano22.Tag = "A4";
            piano22.UseVisualStyleBackColor = false;
            piano22.Click += PianoKeyClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(74, 72, 81);
            panel3.Controls.Add(piano25);
            panel3.Location = new Point(21, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(916, 266);
            panel3.TabIndex = 96;
            // 
            // piano25
            // 
            piano25.Anchor = AnchorStyles.Left;
            piano25.BackColor = Color.FromArgb(213, 214, 216);
            piano25.FlatAppearance.BorderColor = Color.Black;
            piano25.FlatAppearance.BorderSize = 2;
            piano25.FlatStyle = FlatStyle.Flat;
            piano25.ForeColor = Color.Transparent;
            piano25.Location = new Point(848, 0);
            piano25.Margin = new Padding(4, 3, 4, 3);
            piano25.Name = "piano25";
            piano25.Size = new Size(61, 259);
            piano25.TabIndex = 110;
            piano25.Tag = "C5";
            piano25.UseVisualStyleBackColor = false;
            piano25.Click += PianoKeyClick;
            // 
            // bScale
            // 
            bScale.Anchor = AnchorStyles.None;
            bScale.Appearance = Appearance.Button;
            bScale.BackColor = Color.FromArgb(163, 162, 167);
            bScale.Checked = true;
            bScale.FlatAppearance.BorderColor = Color.Gainsboro;
            bScale.FlatAppearance.BorderSize = 2;
            bScale.FlatAppearance.CheckedBackColor = Color.White;
            bScale.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bScale.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            bScale.FlatStyle = FlatStyle.Flat;
            bScale.Font = new Font("Mongolian Baiti", 15.75F);
            bScale.ForeColor = Color.Black;
            bScale.Location = new Point(19, 11);
            bScale.Name = "bScale";
            bScale.Size = new Size(100, 48);
            bScale.TabIndex = 63;
            bScale.TabStop = true;
            bScale.Text = "Scale";
            bScale.TextAlign = ContentAlignment.MiddleCenter;
            bScale.UseVisualStyleBackColor = false;
            bScale.CheckedChanged += ModeCheckedChanged;
            bScale.Click += ModeClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1195, 262);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 107;
            label1.Text = "Aaron Rash";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.FromArgb(74, 72, 81);
            radioButton1.Enabled = false;
            radioButton1.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.White;
            radioButton1.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(21, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 48);
            radioButton1.TabIndex = 64;
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.FromArgb(74, 72, 81);
            radioButton2.Enabled = false;
            radioButton2.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.White;
            radioButton2.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(21, 112);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 48);
            radioButton2.TabIndex = 65;
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // pbBlueScreen
            // 
            pbBlueScreen.Image = (Image)resources.GetObject("pbBlueScreen.Image");
            pbBlueScreen.Location = new Point(443, 153);
            pbBlueScreen.Name = "pbBlueScreen";
            pbBlueScreen.Size = new Size(193, 106);
            pbBlueScreen.SizeMode = PictureBoxSizeMode.Zoom;
            pbBlueScreen.TabIndex = 101;
            pbBlueScreen.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 105;
            pictureBox1.TabStop = false;
            // 
            // lNote
            // 
            lNote.FlatStyle = FlatStyle.Flat;
            lNote.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNote.Location = new Point(445, 199);
            lNote.Name = "lNote";
            lNote.Size = new Size(191, 23);
            lNote.TabIndex = 104;
            lNote.Text = "Note";
            lNote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lCategory
            // 
            lCategory.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCategory.Location = new Point(445, 220);
            lCategory.Name = "lCategory";
            lCategory.Size = new Size(194, 23);
            lCategory.TabIndex = 103;
            lCategory.Text = "Category";
            lCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lMode
            // 
            lMode.BackColor = SystemColors.Control;
            lMode.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMode.Location = new Point(445, 177);
            lMode.Name = "lMode";
            lMode.Size = new Size(191, 23);
            lMode.TabIndex = 102;
            lMode.Text = "Mode";
            lMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(bInterval);
            panel4.Controls.Add(bChord);
            panel4.Controls.Add(bScale);
            panel4.Controls.Add(radioButton1);
            panel4.Controls.Add(radioButton2);
            panel4.Controls.Add(radioButton3);
            panel4.Location = new Point(12, 301);
            panel4.Name = "panel4";
            panel4.Size = new Size(133, 283);
            panel4.TabIndex = 106;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.FromArgb(74, 72, 81);
            radioButton3.Enabled = false;
            radioButton3.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatAppearance.CheckedBackColor = Color.White;
            radioButton3.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(21, 211);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 48);
            radioButton3.TabIndex = 66;
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(200, 195, 189);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(bB);
            panel1.Controls.Add(bC);
            panel1.Controls.Add(bA);
            panel1.Controls.Add(bD);
            panel1.Controls.Add(bG);
            panel1.Controls.Add(bE);
            panel1.Controls.Add(bF);
            panel1.Location = new Point(656, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 106);
            panel1.TabIndex = 99;
            // 
            // bB
            // 
            bB.Appearance = Appearance.Button;
            bB.BackColor = Color.FromArgb(33, 32, 37);
            bB.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bB.FlatAppearance.BorderSize = 0;
            bB.FlatAppearance.CheckedBackColor = Color.Black;
            bB.FlatStyle = FlatStyle.Flat;
            bB.Font = new Font("Mongolian Baiti", 21.75F);
            bB.ForeColor = SystemColors.Control;
            bB.Location = new Point(611, 18);
            bB.Name = "bB";
            bB.Padding = new Padding(16);
            bB.Size = new Size(75, 71);
            bB.TabIndex = 54;
            bB.Text = "B";
            bB.TextAlign = ContentAlignment.MiddleCenter;
            bB.UseVisualStyleBackColor = false;
            bB.CheckedChanged += NoteCheckedChanged;
            bB.Click += NoteClick;
            // 
            // bC
            // 
            bC.Appearance = Appearance.Button;
            bC.BackColor = Color.FromArgb(33, 32, 37);
            bC.Checked = true;
            bC.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bC.FlatAppearance.BorderSize = 3;
            bC.FlatAppearance.CheckedBackColor = Color.Black;
            bC.FlatStyle = FlatStyle.Flat;
            bC.Font = new Font("Mongolian Baiti", 21.75F);
            bC.ForeColor = Color.FromArgb(82, 253, 252);
            bC.Location = new Point(17, 18);
            bC.Name = "bC";
            bC.Padding = new Padding(16);
            bC.Size = new Size(75, 71);
            bC.TabIndex = 48;
            bC.TabStop = true;
            bC.Text = "C";
            bC.TextAlign = ContentAlignment.MiddleCenter;
            bC.UseVisualStyleBackColor = false;
            bC.CheckedChanged += NoteCheckedChanged;
            bC.Click += NoteClick;
            // 
            // bA
            // 
            bA.Appearance = Appearance.Button;
            bA.BackColor = Color.FromArgb(33, 32, 37);
            bA.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bA.FlatAppearance.BorderSize = 0;
            bA.FlatAppearance.CheckedBackColor = Color.Black;
            bA.FlatStyle = FlatStyle.Flat;
            bA.Font = new Font("Mongolian Baiti", 21.75F);
            bA.ForeColor = SystemColors.Control;
            bA.Location = new Point(512, 18);
            bA.Name = "bA";
            bA.Padding = new Padding(16);
            bA.Size = new Size(75, 71);
            bA.TabIndex = 53;
            bA.Text = "A";
            bA.TextAlign = ContentAlignment.MiddleCenter;
            bA.UseVisualStyleBackColor = false;
            bA.CheckedChanged += NoteCheckedChanged;
            bA.Click += NoteClick;
            // 
            // bD
            // 
            bD.Appearance = Appearance.Button;
            bD.BackColor = Color.FromArgb(33, 32, 37);
            bD.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bD.FlatAppearance.BorderSize = 0;
            bD.FlatAppearance.CheckedBackColor = Color.Black;
            bD.FlatStyle = FlatStyle.Flat;
            bD.Font = new Font("Mongolian Baiti", 21.75F);
            bD.ForeColor = SystemColors.Control;
            bD.Location = new Point(116, 18);
            bD.Name = "bD";
            bD.Padding = new Padding(16);
            bD.Size = new Size(75, 71);
            bD.TabIndex = 49;
            bD.Text = "D";
            bD.TextAlign = ContentAlignment.MiddleCenter;
            bD.UseVisualStyleBackColor = false;
            bD.CheckedChanged += NoteCheckedChanged;
            bD.Click += NoteClick;
            // 
            // bG
            // 
            bG.Appearance = Appearance.Button;
            bG.BackColor = Color.FromArgb(33, 32, 37);
            bG.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bG.FlatAppearance.BorderSize = 0;
            bG.FlatAppearance.CheckedBackColor = Color.Black;
            bG.FlatStyle = FlatStyle.Flat;
            bG.Font = new Font("Mongolian Baiti", 21.75F);
            bG.ForeColor = SystemColors.Control;
            bG.Location = new Point(413, 18);
            bG.Name = "bG";
            bG.Padding = new Padding(16);
            bG.Size = new Size(75, 71);
            bG.TabIndex = 52;
            bG.Text = "G";
            bG.TextAlign = ContentAlignment.MiddleCenter;
            bG.UseVisualStyleBackColor = false;
            bG.CheckedChanged += NoteCheckedChanged;
            bG.Click += NoteClick;
            // 
            // bE
            // 
            bE.Appearance = Appearance.Button;
            bE.BackColor = Color.FromArgb(33, 32, 37);
            bE.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bE.FlatAppearance.BorderSize = 0;
            bE.FlatAppearance.CheckedBackColor = Color.Black;
            bE.FlatStyle = FlatStyle.Flat;
            bE.Font = new Font("Mongolian Baiti", 21.75F);
            bE.ForeColor = SystemColors.Control;
            bE.Location = new Point(215, 18);
            bE.Name = "bE";
            bE.Padding = new Padding(16);
            bE.Size = new Size(75, 71);
            bE.TabIndex = 50;
            bE.Text = "E";
            bE.TextAlign = ContentAlignment.MiddleCenter;
            bE.UseVisualStyleBackColor = false;
            bE.CheckedChanged += NoteCheckedChanged;
            bE.Click += NoteClick;
            // 
            // bF
            // 
            bF.Appearance = Appearance.Button;
            bF.BackColor = Color.FromArgb(33, 32, 37);
            bF.FlatAppearance.BorderColor = Color.FromArgb(82, 253, 252);
            bF.FlatAppearance.BorderSize = 0;
            bF.FlatAppearance.CheckedBackColor = Color.Black;
            bF.FlatStyle = FlatStyle.Flat;
            bF.Font = new Font("Mongolian Baiti", 21.75F);
            bF.ForeColor = SystemColors.Control;
            bF.Location = new Point(314, 18);
            bF.Name = "bF";
            bF.Padding = new Padding(16);
            bF.Size = new Size(75, 71);
            bF.TabIndex = 51;
            bF.Text = "F";
            bF.TextAlign = ContentAlignment.MiddleCenter;
            bF.UseVisualStyleBackColor = false;
            bF.CheckedChanged += NoteCheckedChanged;
            bF.Click += NoteClick;
            // 
            // panelCategory
            // 
            panelCategory.BackColor = Color.FromArgb(200, 195, 189);
            panelCategory.BorderStyle = BorderStyle.FixedSingle;
            panelCategory.Location = new Point(12, 75);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(308, 184);
            panelCategory.TabIndex = 98;
            // 
            // bAbout
            // 
            bAbout.Location = new Point(12, 12);
            bAbout.Name = "bAbout";
            bAbout.Size = new Size(75, 23);
            bAbout.TabIndex = 108;
            bAbout.Text = "About";
            bAbout.UseVisualStyleBackColor = true;
            bAbout.Click += bAbout_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(163, 162, 167);
            button1.FlatAppearance.MouseDownBackColor = Color.LightGray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mongolian Baiti", 14.25F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(488, 86);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(100, 48);
            button1.TabIndex = 109;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayKeys;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.None;
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.FromArgb(74, 72, 81);
            radioButton4.Enabled = false;
            radioButton4.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton4.FlatAppearance.BorderSize = 0;
            radioButton4.FlatAppearance.CheckedBackColor = Color.White;
            radioButton4.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(1144, 390);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 48);
            radioButton4.TabIndex = 110;
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // bGrand
            // 
            bGrand.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bGrand.Appearance = Appearance.Button;
            bGrand.BackColor = Color.FromArgb(163, 162, 167);
            bGrand.Checked = true;
            bGrand.FlatAppearance.BorderColor = Color.Gainsboro;
            bGrand.FlatAppearance.BorderSize = 2;
            bGrand.FlatAppearance.CheckedBackColor = Color.White;
            bGrand.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bGrand.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            bGrand.FlatStyle = FlatStyle.Flat;
            bGrand.Font = new Font("Mongolian Baiti", 14.25F);
            bGrand.ForeColor = Color.Black;
            bGrand.Location = new Point(4, 7);
            bGrand.Margin = new Padding(0);
            bGrand.Name = "bGrand";
            bGrand.Size = new Size(100, 48);
            bGrand.TabIndex = 111;
            bGrand.TabStop = true;
            bGrand.Text = "Grand";
            bGrand.TextAlign = ContentAlignment.MiddleCenter;
            bGrand.UseVisualStyleBackColor = false;
            bGrand.CheckedChanged += InstrumentCheckedChanged;
            // 
            // bWurlitzer
            // 
            bWurlitzer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bWurlitzer.Appearance = Appearance.Button;
            bWurlitzer.BackColor = Color.FromArgb(163, 162, 167);
            bWurlitzer.FlatAppearance.BorderColor = Color.Gainsboro;
            bWurlitzer.FlatAppearance.BorderSize = 0;
            bWurlitzer.FlatAppearance.CheckedBackColor = Color.White;
            bWurlitzer.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bWurlitzer.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            bWurlitzer.FlatStyle = FlatStyle.Flat;
            bWurlitzer.Font = new Font("Mongolian Baiti", 14.25F);
            bWurlitzer.ForeColor = Color.Black;
            bWurlitzer.Location = new Point(4, 64);
            bWurlitzer.Margin = new Padding(0);
            bWurlitzer.Name = "bWurlitzer";
            bWurlitzer.Size = new Size(100, 48);
            bWurlitzer.TabIndex = 112;
            bWurlitzer.Text = "Wurlitzer";
            bWurlitzer.TextAlign = ContentAlignment.MiddleCenter;
            bWurlitzer.UseVisualStyleBackColor = false;
            bWurlitzer.CheckedChanged += InstrumentCheckedChanged;
            // 
            // bElectric
            // 
            bElectric.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bElectric.Appearance = Appearance.Button;
            bElectric.BackColor = Color.FromArgb(163, 162, 167);
            bElectric.FlatAppearance.BorderColor = Color.Gainsboro;
            bElectric.FlatAppearance.BorderSize = 0;
            bElectric.FlatAppearance.CheckedBackColor = Color.White;
            bElectric.FlatAppearance.MouseDownBackColor = Color.LightGray;
            bElectric.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            bElectric.FlatStyle = FlatStyle.Flat;
            bElectric.Font = new Font("Mongolian Baiti", 14.25F);
            bElectric.ForeColor = Color.Black;
            bElectric.Location = new Point(4, 121);
            bElectric.Margin = new Padding(0);
            bElectric.Name = "bElectric";
            bElectric.Size = new Size(100, 48);
            bElectric.TabIndex = 113;
            bElectric.Text = "Electric";
            bElectric.TextAlign = ContentAlignment.MiddleCenter;
            bElectric.UseVisualStyleBackColor = false;
            bElectric.CheckedChanged += InstrumentCheckedChanged;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(bGrand);
            panel5.Controls.Add(bWurlitzer);
            panel5.Controls.Add(radioButton6);
            panel5.Controls.Add(radioButton7);
            panel5.Controls.Add(bElectric);
            panel5.Controls.Add(radioButton5);
            panel5.Location = new Point(326, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(111, 184);
            panel5.TabIndex = 114;
            // 
            // radioButton6
            // 
            radioButton6.Anchor = AnchorStyles.None;
            radioButton6.Appearance = Appearance.Button;
            radioButton6.BackColor = Color.FromArgb(74, 72, 81);
            radioButton6.Enabled = false;
            radioButton6.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton6.FlatAppearance.BorderSize = 0;
            radioButton6.FlatAppearance.CheckedBackColor = Color.White;
            radioButton6.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton6.FlatStyle = FlatStyle.Flat;
            radioButton6.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton6.ForeColor = Color.Black;
            radioButton6.Location = new Point(6, 9);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(100, 48);
            radioButton6.TabIndex = 115;
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.CheckedChanged += InstrumentCheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.Anchor = AnchorStyles.None;
            radioButton7.Appearance = Appearance.Button;
            radioButton7.BackColor = Color.FromArgb(74, 72, 81);
            radioButton7.Enabled = false;
            radioButton7.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton7.FlatAppearance.BorderSize = 0;
            radioButton7.FlatAppearance.CheckedBackColor = Color.White;
            radioButton7.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton7.FlatStyle = FlatStyle.Flat;
            radioButton7.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton7.ForeColor = Color.Black;
            radioButton7.Location = new Point(6, 66);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(100, 48);
            radioButton7.TabIndex = 115;
            radioButton7.TextAlign = ContentAlignment.MiddleCenter;
            radioButton7.UseVisualStyleBackColor = false;
            radioButton7.CheckedChanged += InstrumentCheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.None;
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackColor = Color.FromArgb(74, 72, 81);
            radioButton5.Enabled = false;
            radioButton5.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton5.FlatAppearance.BorderSize = 0;
            radioButton5.FlatAppearance.CheckedBackColor = Color.White;
            radioButton5.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton5.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton5.FlatStyle = FlatStyle.Flat;
            radioButton5.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton5.ForeColor = Color.Black;
            radioButton5.Location = new Point(6, 123);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(100, 48);
            radioButton5.TabIndex = 115;
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += InstrumentCheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.Anchor = AnchorStyles.None;
            radioButton8.Appearance = Appearance.Button;
            radioButton8.BackColor = Color.FromArgb(74, 72, 81);
            radioButton8.Enabled = false;
            radioButton8.FlatAppearance.BorderColor = Color.Gainsboro;
            radioButton8.FlatAppearance.BorderSize = 0;
            radioButton8.FlatAppearance.CheckedBackColor = Color.White;
            radioButton8.FlatAppearance.MouseDownBackColor = Color.LightGray;
            radioButton8.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            radioButton8.FlatStyle = FlatStyle.Flat;
            radioButton8.Font = new Font("Mongolian Baiti", 15.75F);
            radioButton8.ForeColor = Color.Black;
            radioButton8.Location = new Point(490, 88);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(100, 48);
            radioButton8.TabIndex = 116;
            radioButton8.TextAlign = ContentAlignment.MiddleCenter;
            radioButton8.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 195, 189);
            ClientSize = new Size(1389, 616);
            Controls.Add(panel5);
            Controls.Add(button1);
            Controls.Add(bAbout);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lNote);
            Controls.Add(lCategory);
            Controls.Add(lMode);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelCategory);
            Controls.Add(pbBlueScreen);
            Controls.Add(radioButton4);
            Controls.Add(radioButton8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Theory Teacher";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBlueScreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton bInterval;
        private RadioButton bChord;
        private RadioButton bScale;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private PictureBox pbBlueScreen;
        private PictureBox pictureBox1;
        private Label lNote;
        private Label lCategory;
        private Label lMode;
        private Panel panel4;
        private RadioButton radioButton3;
        private Panel panel1;
        private RadioButton bB;
        private RadioButton bC;
        private RadioButton bA;
        private RadioButton bD;
        private RadioButton bG;
        private RadioButton bE;
        private RadioButton bF;
        private Panel panelCategory;
        public Button piano23;
        public Button piano24;
        public Button piano21;
        public Button piano19;
        public Button piano20;
        public Button piano18;
        public Button piano16;
        public Button piano14;
        public Button piano7;
        public Button piano17;
        public Button piano9;
        public Button piano13;
        public Button piano4;
        public Button piano15;
        public Button piano11;
        public Button piano2;
        public Button piano1;
        public Button piano3;
        public Button piano5;
        public Button piano6;
        public Button piano8;
        public Button piano10;
        public Button piano12;
        public Button piano22;
        private Panel panel3;
        private Button bAbout;
        public Button piano25;
        public Panel panel2;
        private Button button1;
        private RadioButton radioButton4;
        private RadioButton bGrand;
        private RadioButton bWurlitzer;
        private RadioButton bElectric;
        private Panel panel5;
        private RadioButton Electric;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
    }
}
