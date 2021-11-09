using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully for Test!", "Completed for Test!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("explorer.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe");
            {
                Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe");
                Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe");
                Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe"); Process.Start("Notepad.exe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 Support = new Form2();
            Support.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AboutBox1 About = new AboutBox1();
            About.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("www.google.com/");
            Process.Start("www.bing.com/");
        }
    }
}
