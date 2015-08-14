using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int x;
            System.Console.WriteLine("Please input a integer.");
            x = System.Convert.ToInt32(Console.ReadLine());
            x = x * x;
            System.Console.WriteLine("x^2={0}", x);
        }
    }
}
