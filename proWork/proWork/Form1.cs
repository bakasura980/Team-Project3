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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SuccLabel.Visible = false;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            try
            {
                Budjet datatoadd = new Budjet();
                datatoadd.Data = date.Value.ToString();
                datatoadd.Costs = Txtboxcost.Text;
                datatoadd.Prize = int.Parse(Txtboxprize.Text);

                using (StreamWriter writer = new StreamWriter("Data.txt", true))
                {
                    writer.WriteLine(datatoadd);
                }
                SuccLabel.Text = "You have successfully added";
                SuccLabel.Visible = true;
                
            }
            catch (Exception)
            {
                SuccLabel.Visible = true;
                SuccLabel.Text = "Something went wrong!";

            }
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Calculate calc = new Calculate();
            calc.Show();
        }
    }
}
