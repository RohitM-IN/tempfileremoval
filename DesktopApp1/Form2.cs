using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DesktopApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("Tempremoval.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Admin -d -e cmd.exe /c \\TempFilesRemoval\batrun\Tempremoval.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/Tempremoval.bat");
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("Prefetch.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Admin -d -e cmd.exe /c \\TempFilesRemoval\batrun\Prefetch.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/Prefetch.bat");
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("LogRemoval.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Admin -d -e cmd.exe /c \\TempFilesRemoval\batrun\LogRemoval.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/LogRemoval.bat");
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("Tempnetfiles.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Admin -d -e cmd.exe /c \\TempFilesRemoval\batrun\Tempnetfiles.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/Tempnetfiles.bat");
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("test.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Admin -d -e cmd.exe /c \\TempFilesRemoval\batrun\Cleanmgr.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/Cleanmgr.bat");
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("test.bat");
            SW.WriteLine(@"\\server-name\directory\PsExec.exe -u Admin -d -e cmd.exe /c \\TempFilesRemoval\batrun\SoftwareDistribution.bat");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("C:/TempFilesRemoval/batrun/SoftwareDistribution.bat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }
    }
}

