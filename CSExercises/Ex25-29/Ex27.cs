using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x, y;
            int i;
            string Stars="";
            Console.WriteLine("Programme a:\n");
            Console.WriteLine("X\tY\n");
            Console.WriteLine("----------------------");
            for(i=-5;i<=5;i++)
            {
                x = i;
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0:0.0}\t{1:0.0}", x, y);
            }
            Console.WriteLine("Programme b:\n");
            for(x=1;x<=20;x++)
            {
                y = 2 * x * x - 4 * x + 3;
                for (i = 1,Stars=""; i <= y; i++)
                    Stars = "*" + Stars;
                Console.WriteLine("{0:0.0}\t{1}",x,Stars);
            }
        }
    }
}
