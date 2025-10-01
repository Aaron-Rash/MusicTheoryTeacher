using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ScalesForm : Form
    {
        public ScalesForm()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.CategoryClick(sender);
        }
        private void CheckedChange(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.ParentForm;
            mainForm.CategoryCheckedChanged(sender);
        }

    }
}
