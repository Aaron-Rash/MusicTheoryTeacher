namespace WinFormsApp1
{
    partial class ChordsForm
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
            bAugmentedChord = new RadioButton();
            bDiminishedChord = new RadioButton();
            bMinorChord = new RadioButton();
            bMajorChord = new RadioButton();
            SuspendLayout();
            // 
            // bAugmentedChord
            // 
            bAugmentedChord.Appearance = Appearance.Button;
            bAugmentedChord.BackColor = Color.FromArgb(33, 32, 37);
            bAugmentedChord.FlatAppearance.BorderSize = 0;
            bAugmentedChord.FlatAppearance.CheckedBackColor = Color.Black;
            bAugmentedChord.FlatStyle = FlatStyle.Flat;
            bAugmentedChord.Font = new Font("Mongolian Baiti", 15.75F);
            bAugmentedChord.ForeColor = SystemColors.Control;
            bAugmentedChord.Location = new Point(163, 100);
            bAugmentedChord.Name = "bAugmentedChord";
            bAugmentedChord.Size = new Size(123, 73);
            bAugmentedChord.TabIndex = 15;
            bAugmentedChord.Text = "Augmented";
            bAugmentedChord.TextAlign = ContentAlignment.MiddleCenter;
            bAugmentedChord.UseVisualStyleBackColor = false;
            bAugmentedChord.CheckedChanged += CheckedChange;
            bAugmentedChord.Click += ButtonClick;
            // 
            // bDiminishedChord
            // 
            bDiminishedChord.Appearance = Appearance.Button;
            bDiminishedChord.BackColor = Color.FromArgb(33, 32, 37);
            bDiminishedChord.FlatAppearance.BorderSize = 0;
            bDiminishedChord.FlatAppearance.CheckedBackColor = Color.Black;
            bDiminishedChord.FlatStyle = FlatStyle.Flat;
            bDiminishedChord.Font = new Font("Mongolian Baiti", 15.75F);
            bDiminishedChord.ForeColor = SystemColors.Control;
            bDiminishedChord.Location = new Point(25, 100);
            bDiminishedChord.Name = "bDiminishedChord";
            bDiminishedChord.Size = new Size(123, 73);
            bDiminishedChord.TabIndex = 14;
            bDiminishedChord.Text = "Diminished";
            bDiminishedChord.TextAlign = ContentAlignment.MiddleCenter;
            bDiminishedChord.UseVisualStyleBackColor = false;
            bDiminishedChord.CheckedChanged += CheckedChange;
            bDiminishedChord.Click += ButtonClick;
            // 
            // bMinorChord
            // 
            bMinorChord.Appearance = Appearance.Button;
            bMinorChord.BackColor = Color.FromArgb(33, 32, 37);
            bMinorChord.FlatAppearance.BorderSize = 0;
            bMinorChord.FlatAppearance.CheckedBackColor = Color.Black;
            bMinorChord.FlatStyle = FlatStyle.Flat;
            bMinorChord.Font = new Font("Mongolian Baiti", 15.75F);
            bMinorChord.ForeColor = SystemColors.Control;
            bMinorChord.Location = new Point(163, 12);
            bMinorChord.Name = "bMinorChord";
            bMinorChord.Size = new Size(123, 73);
            bMinorChord.TabIndex = 13;
            bMinorChord.Text = "Minor";
            bMinorChord.TextAlign = ContentAlignment.MiddleCenter;
            bMinorChord.UseVisualStyleBackColor = false;
            bMinorChord.CheckedChanged += CheckedChange;
            bMinorChord.Click += ButtonClick;
            // 
            // bMajorChord
            // 
            bMajorChord.Appearance = Appearance.Button;
            bMajorChord.BackColor = Color.FromArgb(33, 32, 37);
            bMajorChord.Checked = true;
            bMajorChord.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            bMajorChord.FlatAppearance.BorderSize = 3;
            bMajorChord.FlatAppearance.CheckedBackColor = Color.Black;
            bMajorChord.FlatStyle = FlatStyle.Flat;
            bMajorChord.Font = new Font("Mongolian Baiti", 15.75F);
            bMajorChord.ForeColor = Color.FromArgb(255, 128, 128);
            bMajorChord.Location = new Point(25, 12);
            bMajorChord.Name = "bMajorChord";
            bMajorChord.Size = new Size(123, 73);
            bMajorChord.TabIndex = 12;
            bMajorChord.TabStop = true;
            bMajorChord.Text = "Major";
            bMajorChord.TextAlign = ContentAlignment.MiddleCenter;
            bMajorChord.UseVisualStyleBackColor = false;
            bMajorChord.CheckedChanged += CheckedChange;
            bMajorChord.Click += ButtonClick;
            // 
            // ChordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 184);
            Controls.Add(bAugmentedChord);
            Controls.Add(bDiminishedChord);
            Controls.Add(bMinorChord);
            Controls.Add(bMajorChord);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChordsForm";
            Text = "ChordsForm";
            ResumeLayout(false);
        }

        #endregion

        public RadioButton bAugmentedChord;
        public RadioButton bDiminishedChord;
        public RadioButton bMinorChord;
        public RadioButton bMajorChord;
    }
}