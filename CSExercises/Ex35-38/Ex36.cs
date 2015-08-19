using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string Palindrome;
            int i,j, Count=0,Mid=0 ;
            Console.WriteLine("Please enter a string: ");
            Palindrome= Console.ReadLine();
            Palindrome = Palindrome.ToUpper();
            for (i = 0; i < Palindrome.Length; i++)
                if ((Palindrome[i] >= 'A' && Palindrome[i] <= 'Z') || (Palindrome[i] >= '0' && Palindrome[i] <= '9'))
                    Count++;
            char[] Real = new char[Count];
            for(i=0,j=0;i<Palindrome.Length;i++)
                if ((Palindrome[i] >= 'A' && Palindrome[i] <= 'Z') || (Palindrome[i] >= '0' && Palindrome[i] <= '9'))
                {
                    Real[j] = Palindrome[i];
                    j++;
                }
            for(i=0;i<Count/2;i++)
            {
                if (Real[i] != Real[Count - 1 - i])
                    break;
                Mid++;
            }
            if (Mid == Count / 2)
                Console.WriteLine("The string is Palindrome!");
            else
                Console.WriteLine("The string is not Palindrome!");
        
        }
    }
}
