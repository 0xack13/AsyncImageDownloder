using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldSample
{
    class Program
    {
        static List<int> MyList = new List<int>();

        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
        static void Main(string[] args)
        {
            FillValues();
            foreach (int i in RunningTotal())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
        }

        static IEnumerable<int> RunningTotal()
        {
            int runningtotal = 0;
            foreach (int i in MyList)
            {
                runningtotal += i;
                yield return (runningtotal);

            }
        }
    }
}
