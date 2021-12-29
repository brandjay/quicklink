using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace quicklink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Google/Chrome/Application/Chrome.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("Thank you for calling if you run into any issues please call 1800-000-0000");
        }
    }
}
