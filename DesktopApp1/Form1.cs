using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("Auto.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Administrator -d -e cmd.exe /c \\TempFilesRemoval\batrun\Auto.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/Auto.bat");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
