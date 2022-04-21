using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace ResourceConverter
{

    //"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6 Tools"
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6 Tools\ResGen.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                // Part 2: set arguments.
                startInfo.Arguments = "ResGen " + openFileDialog1.FileName + " [" + Path.GetDirectoryName(openFileDialog1.FileName) + @"\" + Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + ".resx]";

                //Console.WriteLine("ResGen " + openFileDialog1.FileName + " [" + Path.GetDirectoryName(openFileDialog1.FileName) + @"\" +  Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + ".resx]");

                Process.Start(startInfo);
            }
        }
    }
}
