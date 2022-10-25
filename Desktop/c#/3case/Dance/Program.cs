using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string danserNavn1;
            string danserNavn2;
            int danserPoint1;
            int danserPoint2;


            Console.WriteLine("Angiv den første danserens Navn:");
            danserNavn1 = Console.ReadLine();
            Class name1 = new Class(danserNavn1);

            Console.WriteLine("Angiv Point:");
            danserPoint1 = Convert.ToInt32(Console.ReadLine());
            Class point1 = new Class(danserPoint1);

            Console.WriteLine("Angiv den anden danserens Navn:");
            danserNavn2 = Console.ReadLine();
            Class name2 = new Class(danserNavn2);

            Console.WriteLine("Angiv Point:");
            danserPoint2 = Convert.ToInt32(Console.ReadLine());
            Class point2 = new Class(danserPoint2);

            int samletPoint = danserPoint1 + danserPoint2;

            Console.Write("{0} & {1} {2}",danserNavn1, danserNavn2, samletPoint);

            Console.ReadLine();
        }
    }
}
