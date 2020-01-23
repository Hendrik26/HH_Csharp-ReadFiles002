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

namespace HH_Csharp_ReadFiles002
{
    public partial class Form1 : Form
    {
            
        const string fileName = "..\\..\\..\\Beispiel.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            StreamReader streamReader = File.OpenText(fileName);
            string line = string.Empty;
            while ((line = streamReader.ReadLine()) != null)
            {
                textBox1.Text += line + Environment.NewLine;
            }
        }
    }
}
