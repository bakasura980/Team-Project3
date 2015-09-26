using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class Budjet
    {
        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string costs;

        public string Costs
        {
            get { return costs; }
            set { costs = value; }
        }

        private int prize;

        public int Prize
        {
            get { return prize; }
            set { prize = value; }
        }


        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.data, this.costs, this.prize);
        }
    }
}

