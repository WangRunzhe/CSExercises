using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string Phrase,UpPhrase;
            int i,Total,NumA=0,NumE=0,NumI=0,NumO=0,NumU=0;
            Console.Write("Please enter a phrase:");
            Phrase = Console.ReadLine();
            UpPhrase = Phrase.ToUpper();
            for(i=0;i<Phrase.Length;i++)
            {
                if (UpPhrase[i] == 'A')
                    NumA++;
                else if (UpPhrase[i] == 'E')
                    NumE++;
                else if (UpPhrase[i] == 'I')
                    NumI++;
                else if (UpPhrase[i] == 'O')
                    NumO++;
                else if (UpPhrase[i] == 'U')
                    NumU++;               
            }
            Total = NumA + NumE + NumI + NumO + NumU;
            Console.WriteLine("Total number of vowels: {0}", Total);
            Console.WriteLine("Number of a: {0}", NumA);
            Console.WriteLine("Number of e: {0}", NumE);
            Console.WriteLine("Number of i: {0}", NumI);
            Console.WriteLine("Number of o: {0}", NumO);
            Console.WriteLine("Number of u: {0}", NumU);
        }
    }
}
