using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string TheString;
            int i,Count=0;
            Console.WriteLine("Please input a string.");
            TheString = Console.ReadLine();
            char[] WordOfString = new char[TheString.Length];
            for(i=0;i<TheString.Length;i++)
            {
                if (TheString[i] == ' ')
                    Count++;
                WordOfString[i] = TheString[i];
            }
            if (WordOfString[0] >= 'a' && WordOfString[0] <= 'z')
                WordOfString[0] = Convert.ToChar(WordOfString[0] - 32);
            for(i=0;i<TheString.Length;i++)
            {
                if (WordOfString[i] == ' ' && WordOfString[i + 1] >= 'a' && WordOfString[i + 1] <= 'z')
                    WordOfString[i + 1] = Convert.ToChar(WordOfString[i + 1] - 32);
            }
            for (i = 0; i < TheString.Length; i++)
                Console.Write("{0}", WordOfString[i]);
            Console.Write("\n");
            
        }
    }
}
