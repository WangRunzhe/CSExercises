using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int x;
            double y;
            Console.WriteLine("Please input an integer number of x");
            x = Convert.ToInt32(Console.ReadLine());
            y = Math.Sqrt(x);
            x = Convert.ToInt32((Math.Sqrt(x)));
            Console.WriteLine("The interger square root of x is {0}", x);
            Console.WriteLine("The square root of x is {0}", y);


        }
    }
}
