using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Test
{
    internal class TEST
    {

        static void Main(string[] args)
        {
            string s = "";

            if (Regex.IsMatch(s, @"^\d+$"))
            {
                Console.WriteLine("Given string is numeric");
            }
            else
            {
                Console.WriteLine("Given string is non-numeric");
            }

            Console.ReadKey();
        }
    }
}
