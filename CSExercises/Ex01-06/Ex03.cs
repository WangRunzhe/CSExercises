using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Please input the number of x");
            x=Convert.ToDouble(Console.ReadLine());
            x = Math.Pow(x, 2);
            Console.WriteLine("x^2={0}", x);
        }
    }
}
