using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number: 31337");
            Console.WriteLine("Output Number: " + DigitalRoot("31337"));
            Console.WriteLine("Input Number: 45734");
            Console.WriteLine("Output Number: " + DigitalRoot("45734"));
            Console.ReadKey();
        }

        static int DigitalRoot(string rootThis)
        {
            if (int.Parse(rootThis) < 10)
            {
                return int.Parse(rootThis);
            }
            else
            {
                return DigitalRoot(rootThis.Sum(x => int.Parse(x.ToString())).ToString());
            }
        }
    }
}
