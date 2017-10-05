using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformantSystem.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Please confirm closing the system";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "Please confirm closing the system";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
              Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            textBox8.Enabled = true;

            string s = Environment.MachineName;
            textBox1.Text = s;

            int process = Environment.ProcessorCount;
            textBox6.Text = process.ToString();

            string vers = Environment.OSVersion.ToString();
            textBox3.Text = vers;

            string user = Environment.UserName;
            textBox2.Text = user;

            string opVersion = Environment.OSVersion.Platform.ToString();
            textBox5.Text = opVersion;

            bool is64Bit = Environment.Is64BitOperatingSystem;
            textBox7.Text = is64Bit.ToString();

            bool is64Process = Environment.Is64BitProcess;
            textBox8.Text = is64Process.ToString();

            string op = Environment.OSVersion.VersionString;
            textBox4.Text = op;


        }
    }
}
