using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name;
            char gender;
            int age;
            Console.WriteLine("Please input your name.");
            name = Console.ReadLine();
            Console.WriteLine("Please input your gender(M for male, F for female).");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please input your age.");
            age = Convert.ToInt32(Console.ReadLine());
            if (gender == 'M')
            {
                if (age >= 40)
                    Console.WriteLine("Good morning {0} {1}.", "Uncle", name);
                else
                    Console.WriteLine("Good morning {0} {1}.", "Mr.", name);
            }
            if (gender == 'F')
            {
                if (age >= 40)
                    Console.WriteLine("Good morning {0} {1}.", "Aunty", name);
                else
                    Console.WriteLine("Good morning {0} {1}.", "Mrs.", name);
            }
        }
    }
}