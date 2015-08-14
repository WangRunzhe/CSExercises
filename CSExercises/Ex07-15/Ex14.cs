using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s,Area;
            Console.WriteLine("Please input the value of a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the value of b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the value of c");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            if((a>=b+c)||(b>=a+c)||(c>=a+b))
            {
                Console.WriteLine("It is not a triangle.");
            }
            else
            {
                Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("Area = {0}", Area);
            }
        }
    }
}