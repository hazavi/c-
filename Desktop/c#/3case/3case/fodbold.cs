using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3case
{
    internal class fodbold
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many passes?");
            int pass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(EmoteMessage(pass));

            Console.WriteLine("Is there a goal?");
            string mål = (Console.ReadLine());

            Console.WriteLine(IsThereAGoal(mål));


            Console.ReadLine();

        }

    
        static string EmoteMessage(int passes)
        {
         if (passes >= 10)
           return "High Five!!!";

         if (passes > 1 && passes < 10)
            return "Huh";

         if (passes < 1)
            return "Shh";

         return " ";

        }


        static string IsThereAGoal(string goal)
        {
            if (goal == "yes")
            return "Ole Ole Ole";

            if (goal == "no")
            return "Øv";

            return " ";
        }

    }

}
