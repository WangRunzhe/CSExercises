using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            int time=1,number;
            Random ran = new Random();
            int RandomKey = ran.Next(0, 9);            
            while(flag)
            {
                Console.WriteLine("Please input the number(0-9) you guess.");
                number=Convert.ToInt32(Console.ReadLine());
                switch(time)
                {
                    case 1:
                        {
                            if(number==RandomKey)
                            {
                                Console.WriteLine("You are a Wizard!");
                                flag=false;
                            }
                            else if(number>RandomKey )
                            {
                                Console.WriteLine("Bigger!");
                                time++;
                            }
                            else
                            {
                                Console.WriteLine("Smaller!");
                                time++;
                            }
                        }
                        break;
                    case 2:
                        {
                            if(number==RandomKey)
                            {
                                Console.WriteLine("You are a Good guess!");
                                flag=false;
                            }
                            else if(number>RandomKey )
                            {
                                Console.WriteLine("Bigger!");
                                time++;
                            }
                            else
                            {
                                Console.WriteLine("Smaller!");
                                time++;
                            }
                         }
                        break;
                    case 3:
                        {
                            if(number==RandomKey)
                            {
                                Console.WriteLine("You are a Normal person...");
                                flag=false;
                            }
                            else if(number>RandomKey )
                            {
                                Console.WriteLine("Bigger!");
                                time++;
                            }
                            else
                            {
                                Console.WriteLine("Smaller!");
                                time++;
                            }
                        }
                        break;
                    case 4:
                        {
                            if(number==RandomKey)
                            {
                                Console.WriteLine("You have bad luck~");
                                flag=false;
                            }
                            else if(number>RandomKey )
                            {
                                Console.WriteLine("Bigger!");
                                time++;
                            }
                            else
                            {
                                Console.WriteLine("Smaller!");
                                time++;
                            }
                        }
                        break;
                    case 5:
                        {
                            if(number==RandomKey)
                            {
                                Console.WriteLine("You are a idiot!");
                                flag=false;
                            }
                            else if(number>RandomKey )
                            {
                                Console.WriteLine("Bigger!");
                                time++;
                            }
                            else
                            {
                                Console.WriteLine("Smaller!");
                                time++;
                            }
                        }
                    break;
                    default:
                        {
                            if(number==RandomKey)
                            {
                                Console.WriteLine("You are a idiot!");
                                flag=false;
                            }
                            else if(number>RandomKey )
                            {
                                Console.WriteLine("Bigger!");
                                time++;
                            }
                            else
                            {
                                Console.WriteLine("Smaller!");
                                time++;
                            }
                        }
                        break;
                        
                }
                if (time > 6)
                {
                    Console.WriteLine("The number is {0}.YOU IDIOT!", RandomKey);
                    flag = false;
                }
            }

        }
    }
}
