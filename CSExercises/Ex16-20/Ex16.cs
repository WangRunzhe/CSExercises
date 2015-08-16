using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name;
            char gender;
            Console.WriteLine("Please input your name.");
            name=Console.ReadLine();
            Console.WriteLine("Please input your gender(M for male, F for female).");
            gender = Convert.ToChar(Console.ReadLine());
            if(gender=='M')
            {
                Console.WriteLine("Good morning {0} {1}.", "Mr.", name);
            }
            if(gender=='F')
            {
                Console.WriteLine("Good morning {0} {1}.", "Mrs.", name);
            }
        }
    }
}