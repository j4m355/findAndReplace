using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindAndReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            var findAndReplace = new FindAndReplace();
            var result = findAndReplace.ProcessDirectory(txtWorkingDirectory.Text, txtFind.Text, txtReplace.Text);

            label3.Text = result ? "Success" : "Fail";

            label3.Visible = true;
        }
    }
}
