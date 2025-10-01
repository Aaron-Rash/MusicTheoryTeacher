namespace WinFormsApp1
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(200, 195, 189);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Print", 15.75F);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1048, 126);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(200, 195, 189);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe Print", 15.75F);
            textBox2.Location = new Point(12, 155);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(730, 123);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            textBox2.Text = "Each key on the piano is a semitone apart.\r\n1 semitone is known as a half step, two semitones is a whole step.\r\nThe major scale pattern is as follows:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(200, 195, 189);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe Print", 15.75F);
            textBox3.Location = new Point(12, 482);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(747, 76);
            textBox3.TabIndex = 2;
            textBox3.TabStop = false;
            textBox3.Text = "Dont waste your efforts trying to remember everything at once.\r\nLearn the blueprint, then youll always be able to figure the rest out\r\n\r\n";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(200, 195, 189);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe Print", 15.75F);
            textBox4.Location = new Point(12, 284);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(747, 182);
            textBox4.TabIndex = 3;
            textBox4.TabStop = false;
            textBox4.Text = "Whole step, whole step, half, whole whole whole half:\r\nv\r\nW W H W W W H\r\nv\r\n2 2 1 2 2 2 1\r\n\r\n";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(200, 195, 189);
            ClientSize = new Size(1063, 573);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}