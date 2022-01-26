using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_Tests
{
    public class Program
    {
        static void Main(string[] args)
        {




        }

        public static string FlipCoin()
        {
            
            Random rand = new Random();

            if (rand.Next(1, 3) == 1)
            {
                return "heads";
            }
            else return "tails";

        }
    }
}
