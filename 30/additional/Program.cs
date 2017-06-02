using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additional
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c = s[0];
            byte b = (byte)c;
            int n = 43;
            Console.WriteLine("b-48 = {0}", b-48);
            Console.WriteLine("n/10 = {0}", n/10);
            Console.ReadLine();
        }
    }
}
