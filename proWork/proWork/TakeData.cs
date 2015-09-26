using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work;

namespace proWork
{
    class TakeData
    {
        public static List<Budjet> GetBudget()
        {
            List<Budjet> bdjs = new List<Budjet>();
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] currentbdj = line.Split('|');
                    bdjs.Add(new Budjet()
                    {
                        Data = currentbdj[0],
                        Costs = currentbdj[1],
                        Prize = int.Parse(currentbdj[2]),
                    });
                    line = reader.ReadLine();
                } while (line != null);
            }
            return bdjs;
        }
    }
}
