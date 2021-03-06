using System;

namespace CSExercises
{
    public class Ex42
    {
        public static int InString(string s1, string s2)
        {
            int position, j, Count = 0;
            if (s2.Length > s1.Length)
                return -1;
            else
            {
                for (position = 0; position < s1.Length-s2.Length; position++)
                {
                    if (s1[position] == s2[0])
                    {
                        for (j = 0; j < s2.Length; j++)
                        {
                            if (position + s2.Length >= s1.Length)//prevent from overflowing
                                break;
                            if (s1[position + j] == s2[j])
                                Count++;
                            else
                                break;
                        }
                        if (Count == s2.Length)
                            return position;
                    }
                }
                return -1;
            }
        }
        public static void Main()
        {
            string S1, S2;
            int PositionOfS1;
            Console.WriteLine("Please input string S1:");
            S1 = Console.ReadLine();
            Console.WriteLine("Please input string S2:");
            S2 = Console.ReadLine();
            PositionOfS1 = InString(S1, S2);
            if (PositionOfS1 !=-1)
                Console.WriteLine("S2 occurs in the position {0} of S1!",PositionOfS1+1);
            else
                Console.WriteLine("S2 doesn't occurs in S2!");
        }

    }
}
