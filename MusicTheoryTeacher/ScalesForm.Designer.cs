namespace WinFormsApp1
{
    partial class ScalesForm
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
            bBluesScale = new RadioButton();
            bMajorScale = new RadioButton();
            bMinorScale = new RadioButton();
            SuspendLayout();
            // 
            // bBluesScale
            // 
            bBluesScale.Appearance = Appearance.Button;
            bBluesScale.BackColor = Color.FromArgb(33, 32, 37);
            bBluesScale.FlatAppearance.BorderSize = 0;
            bBluesScale.FlatAppearance.CheckedBackColor = Color.Black;
            bBluesScale.FlatStyle = FlatStyle.Flat;
            bBluesScale.Font = new Font("Mongolian Baiti", 15.75F);
            bBluesScale.ForeColor = SystemColors.Control;
            bBluesScale.Location = new Point(25, 100);
            bBluesScale.Name = "bBluesScale";
            bBluesScale.Size = new Size(123, 73);
            bBluesScale.TabIndex = 68;
            bBluesScale.Text = "Blues";
            bBluesScale.TextAlign = ContentAlignment.MiddleCenter;
            bBluesScale.UseVisualStyleBackColor = false;
            bBluesScale.CheckedChanged += CheckedChange;
            bBluesScale.Click += ButtonClick;
            // 
            // bMajorScale
            // 
            bMajorScale.Appearance = Appearance.Button;
            bMajorScale.BackColor = Color.FromArgb(33, 32, 37);
            bMajorScale.Checked = true;
            bMajorScale.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            bMajorScale.FlatAppearance.BorderSize = 3;
            bMajorScale.FlatAppearance.CheckedBackColor = Color.Black;
            bMajorScale.FlatStyle = FlatStyle.Flat;
            bMajorScale.Font = new Font("Mongolian Baiti", 15.75F);
            bMajorScale.ForeColor = Color.FromArgb(255, 128, 128);
            bMajorScale.Location = new Point(25, 12);
            bMajorScale.Name = "bMajorScale";
            bMajorScale.Size = new Size(123, 73);
            bMajorScale.TabIndex = 66;
            bMajorScale.TabStop = true;
            bMajorScale.Text = "Major";
            bMajorScale.TextAlign = ContentAlignment.MiddleCenter;
            bMajorScale.UseVisualStyleBackColor = false;
            bMajorScale.CheckedChanged += CheckedChange;
            bMajorScale.Click += ButtonClick;
            // 
            // bMinorScale
            // 
            bMinorScale.Appearance = Appearance.Button;
            bMinorScale.BackColor = Color.FromArgb(33, 32, 37);
            bMinorScale.FlatAppearance.BorderSize = 0;
            bMinorScale.FlatAppearance.CheckedBackColor = Color.Black;
            bMinorScale.FlatStyle = FlatStyle.Flat;
            bMinorScale.Font = new Font("Mongolian Baiti", 15.75F);
            bMinorScale.ForeColor = SystemColors.Control;
            bMinorScale.Location = new Point(163, 12);
            bMinorScale.Name = "bMinorScale";
            bMinorScale.Size = new Size(123, 73);
            bMinorScale.TabIndex = 67;
            bMinorScale.Text = "Minor";
            bMinorScale.TextAlign = ContentAlignment.MiddleCenter;
            bMinorScale.UseVisualStyleBackColor = false;
            bMinorScale.CheckedChanged += CheckedChange;
            bMinorScale.Click += ButtonClick;
            // 
            // ScalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 184);
            Controls.Add(bBluesScale);
            Controls.Add(bMajorScale);
            Controls.Add(bMinorScale);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScalesForm";
            Text = "ScalesForm";
            ResumeLayout(false);
        }

        #endregion

        public RadioButton bBluesScale;
        public RadioButton bMajorScale;
        public RadioButton bMinorScale;
    }
}