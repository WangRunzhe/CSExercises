using System;

namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            int i,j,Count=0;
            string Tran=""; 
            char[] StringS = new char[s.Length];
            for (i = 0; i < s.Length; i++)
                StringS[i] = s[i];
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == c1)
                        Count++;
            }
            if (Count == 0)
                return s;
           
            int[] Pos = new int[Count];
            
            for (i = 0,j=0; i < s.Length;i++ )
            {
                if (s[i] == c1)
                {
                    Pos[j] = i;
                    j++;
                }
            }
            for (j = 0; j < Count;j++ )
            {
                StringS[Pos[j]] = c2;
            }
            for (i = 0; i < s.Length; i++)
                Tran = Tran + StringS[i];
           
            return Tran;
        }
        public static void Main()
        {
            char C1, C2;
            string S;
            Console.WriteLine("Please input the string S.");
            S=Console.ReadLine();
            Console.WriteLine("Please input what letter you want to change.");
            C1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please input the letter you want to change into.");
            C2 = Convert.ToChar(Console.ReadLine());
            S = Substitute(S, C1, C2);
            Console.WriteLine("The S becomes to:\n{0}", S);
        }
    }
}
