using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Please input the Centigrade degree.");
            C = Convert.ToDouble(Console.ReadLine());
            F = 1.8 * C + 32;
            Console.WriteLine("The Fahrenheit is {0:0.00}", F);
        }
    }
}
