using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, y1,x2,y2,distance;
            Console.WriteLine("Please input the value of x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the value of y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the value of x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the value of y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The value of distance is {0}", distance);
        }
    }
}
