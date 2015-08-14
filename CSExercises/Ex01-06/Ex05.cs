using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Please input number of x");
            x = Convert.ToDouble(Console.ReadLine());
            x = Math.Sqrt(x);
            Console.WriteLine("The square root of x = {0:0.000}", x);
            
        }
    }
}
