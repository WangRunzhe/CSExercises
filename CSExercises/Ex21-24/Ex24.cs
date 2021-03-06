using System;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int N;
            double  G;
            Random ran= new Random();
            Console.WriteLine("Please input an integer value of N.");
            N = Convert.ToInt32(Console.ReadLine());
            G=ran.Next(1,N+1);
                while (G * G != N && Math.Round(G * G, 5) != N)
                {
                    G = (G + N / G) / 2;
                }
            Console.WriteLine("The root of {0} is {1:0.000000}\n", N, G);
            Console.WriteLine("{0}*{1} = {2}", G, G, G * G);
        }
    }
}
