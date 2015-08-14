using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Please a number of x");
            x = Convert.ToDouble(Console.ReadLine());
            x=Math.Sqrt(x);
            Console.WriteLine("The square root of x ={0}", x);
        }
    }
}
