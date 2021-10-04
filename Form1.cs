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

namespace Armandt_sieberhagen_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\arman\source\repos\Armandt_sieberhagen_Quiz\bin\Debug\MemberNames.txt";

            FileStream MyStream = new FileStream(path, FileMode.OpenOrCreate);

            StreamReader reader = new StreamReader(MyStream);

            String Line;

            while((Line = reader.ReadLine()) != null)
            {
                listBox1.Items.Add(Line);
            }
            reader.Close();
            MyStream.Close();
            
        }
    }
}
