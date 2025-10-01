namespace WinFormsApp1
{
    partial class IntervalForm
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
            bThird = new RadioButton();
            bFifth = new RadioButton();
            bTritone = new RadioButton();
            bSeventh = new RadioButton();
            SuspendLayout();
            // 
            // bThird
            // 
            bThird.Appearance = Appearance.Button;
            bThird.BackColor = Color.FromArgb(33, 32, 37);
            bThird.Checked = true;
            bThird.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            bThird.FlatAppearance.BorderSize = 3;
            bThird.FlatAppearance.CheckedBackColor = Color.Black;
            bThird.FlatStyle = FlatStyle.Flat;
            bThird.Font = new Font("Mongolian Baiti", 15.75F);
            bThird.ForeColor = Color.FromArgb(255, 128, 128);
            bThird.Location = new Point(25, 12);
            bThird.Name = "bThird";
            bThird.Size = new Size(123, 73);
            bThird.TabIndex = 71;
            bThird.TabStop = true;
            bThird.Text = "3rd";
            bThird.TextAlign = ContentAlignment.MiddleCenter;
            bThird.UseVisualStyleBackColor = false;
            bThird.CheckedChanged += CheckedChange;
            bThird.Click += ButtonClick;
            // 
            // bFifth
            // 
            bFifth.Appearance = Appearance.Button;
            bFifth.BackColor = Color.FromArgb(33, 32, 37);
            bFifth.FlatAppearance.BorderSize = 0;
            bFifth.FlatAppearance.CheckedBackColor = Color.Black;
            bFifth.FlatStyle = FlatStyle.Flat;
            bFifth.Font = new Font("Mongolian Baiti", 15.75F);
            bFifth.ForeColor = SystemColors.Control;
            bFifth.Location = new Point(163, 12);
            bFifth.Name = "bFifth";
            bFifth.Size = new Size(123, 73);
            bFifth.TabIndex = 72;
            bFifth.Text = "5th";
            bFifth.TextAlign = ContentAlignment.MiddleCenter;
            bFifth.UseVisualStyleBackColor = false;
            bFifth.CheckedChanged += CheckedChange;
            bFifth.Click += ButtonClick;
            // 
            // bTritone
            // 
            bTritone.Appearance = Appearance.Button;
            bTritone.BackColor = Color.FromArgb(33, 32, 37);
            bTritone.FlatAppearance.BorderSize = 0;
            bTritone.FlatAppearance.CheckedBackColor = Color.Black;
            bTritone.FlatStyle = FlatStyle.Flat;
            bTritone.Font = new Font("Mongolian Baiti", 15.75F);
            bTritone.ForeColor = SystemColors.Control;
            bTritone.Location = new Point(163, 100);
            bTritone.Name = "bTritone";
            bTritone.Size = new Size(123, 73);
            bTritone.TabIndex = 73;
            bTritone.Text = "Tritone";
            bTritone.TextAlign = ContentAlignment.MiddleCenter;
            bTritone.UseVisualStyleBackColor = false;
            bTritone.CheckedChanged += CheckedChange;
            bTritone.Click += ButtonClick;
            // 
            // bSeventh
            // 
            bSeventh.Appearance = Appearance.Button;
            bSeventh.BackColor = Color.FromArgb(33, 32, 37);
            bSeventh.FlatAppearance.BorderSize = 0;
            bSeventh.FlatAppearance.CheckedBackColor = Color.Black;
            bSeventh.FlatStyle = FlatStyle.Flat;
            bSeventh.Font = new Font("Mongolian Baiti", 15.75F);
            bSeventh.ForeColor = SystemColors.Control;
            bSeventh.Location = new Point(25, 100);
            bSeventh.Name = "bSeventh";
            bSeventh.Size = new Size(123, 73);
            bSeventh.TabIndex = 74;
            bSeventh.Text = "7th";
            bSeventh.TextAlign = ContentAlignment.MiddleCenter;
            bSeventh.UseVisualStyleBackColor = false;
            bSeventh.CheckedChanged += CheckedChange;
            bSeventh.Click += ButtonClick;
            // 
            // IntervalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 184);
            Controls.Add(bThird);
            Controls.Add(bFifth);
            Controls.Add(bTritone);
            Controls.Add(bSeventh);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IntervalForm";
            Text = "IntervalForm";
            ResumeLayout(false);
        }

        #endregion

        public RadioButton bThird;
        public RadioButton bFifth;
        public RadioButton bTritone;
        public RadioButton bSeventh;
    }
}