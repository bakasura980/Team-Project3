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
using System.Configuration;

namespace Work
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter add = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                add.WriteLine("The date: " + textBox1.Text);
                add.WriteLine("The product is: " + textBox2.Text);
                add.WriteLine("The price is: " + textBox3.Text);
                add.WriteLine();
            }
        }

     
    }
}
