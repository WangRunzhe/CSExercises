using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            string name;
            System.Console.WriteLine("May I have your name?");
            name = System.Console.ReadLine();
            System.Console.WriteLine("Good morning {0}!",name);
        }
    }
}
