using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work;

namespace proWork
{
    public partial class Calculate : Form
    {
        List<Budjet> bdjs = new List<Budjet>();
        public Calculate()
        {
            InitializeComponent();
            CalcBtn.Enabled = false;
            CalcLM.Enabled = false;
            CalcLY.Enabled = false;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string[] linedata;
            int sum = 0;
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line = reader.ReadLine();
               
                do
                {
                    linedata = line.Split('|');
                    if (time.AddDays(-7) <= DateTime.Parse(linedata[0]))
                    {
                        sum += int.Parse(linedata[2]);
                    }
                    line = reader.ReadLine();
                   
                } while (line != null);
            }
            TxtBoxLW.Text = sum.ToString();

        }

        private void CalcLM_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string[] linedata;
            int sum = 0;
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line = reader.ReadLine();

                do
                {
                    linedata = line.Split('|');
                    if (time.AddDays(-30) <= DateTime.Parse(linedata[0]))
                    {
                        sum += int.Parse(linedata[2]);
                    }
                    line = reader.ReadLine();

                } while (line != null);
            }
            TxtBoxLM.Text = sum.ToString();
        }

        private void CalcLY_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string[] linedata;
            int sum = 0;
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line = reader.ReadLine();

                do
                {
                    linedata = line.Split('|');
                    if (time.AddDays(-365) <= DateTime.Parse(linedata[0]))
                    {
                        sum += int.Parse(linedata[2]);
                    }
                    line = reader.ReadLine();

                } while (line != null);
            }
            TxtBoxLY.Text = sum.ToString();
        }

        private void ImpBtn_Click(object sender, EventArgs e)
        {
            List<Budjet> bdjs = TakeData.GetBudget();
            SuccLabel.Visible = true;
            CalcBtn.Enabled = true;
            CalcLM.Enabled = true;
            CalcLY.Enabled = true;
        }
    }
}
