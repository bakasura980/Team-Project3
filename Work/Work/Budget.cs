using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Budget
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

        private string prize;

        public string Prize
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
