using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Please input an integer.");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 88);
            Console.WriteLine("Lucky you...");
        }
    }
}
