using System;

namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            int i,j,Count=0;
            if(s2.Length>s1.Length)
                return false;
            else
            {
                for(i=0;i<s1.Length-s2.Length;i++)
                {
                    if (s1[i] == s2[0])
                    {
                        for (j = 0; j < s2.Length; j++)
                        {
                            if (i + s2.Length >= s1.Length)//prevent from overflowing
                                break;
                            if (s1[i + j] == s2[j])
                                Count++;
                            else
                                break;
                        }
                        if (Count == s2.Length)
                            return true;
                    }
                }
                return false;
            }
        }
        public static void Main()
        {
            string S1, S2;
            bool Occur;
            Console.WriteLine("Please input string S1:");
            S1=Console.ReadLine();
            Console.WriteLine("Please input string S2:");
            S2 = Console.ReadLine();
            Occur=InString(S1, S2);
            if (Occur == true)
                Console.WriteLine("S2 occurs in S1!");
            else
                Console.WriteLine("S2 doesn't occurs in S2!");
        }
    }

}
