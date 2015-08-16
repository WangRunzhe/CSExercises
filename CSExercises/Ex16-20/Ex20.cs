using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int ChoosePdt;
            bool Buy=true;
            char ChooseBuy;
            int TVQuantity=0, DVDQuantity=0, MP3Quantity=0;
            double AllPrice;
            while (Buy) 
            { 
            Console.WriteLine("Please choose the product your want.\n");
            Console.WriteLine("Enter 1 for TV\nEnter 2 for DVD\nEnter 3 for MP3\n");
            ChoosePdt=Convert.ToInt32(Console.ReadLine());
            switch (ChoosePdt)
            {
                case 1:
                    {
                        Console.WriteLine("Please input the quantity of TV.\n");
                        TVQuantity = Convert.ToInt32(Console.ReadLine());
                        AllPrice = TVQuantity * 900 + DVDQuantity * 500 + MP3Quantity * 700;
                        if (AllPrice < 5000)
                        {
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900, DVDQuantity * 500, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }
                        if (AllPrice >= 5000&&AllPrice<10000)
                        {
                            AllPrice = (TVQuantity * 900 + DVDQuantity * 500) * 0.9 + MP3Quantity * 700;
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900 * 0.9, DVDQuantity * 500 * 0.9, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }
                        if (AllPrice >= 10000)
                        {
                            AllPrice = (TVQuantity * 900 + DVDQuantity * 500) * 0.85 + MP3Quantity * 700;
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900 * 0.85, DVDQuantity * 500 * 0.85, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }

                        do
                        {
                            Console.WriteLine("Enter P to pay your order.\n\nEnter M to get more product or change the quantity for product.\n");
                            ChooseBuy = Convert.ToChar(Console.ReadLine());
                            switch (ChooseBuy)
                            {
                                case 'P':
                                    Console.WriteLine("Please pay ${0:0.00}.\n", AllPrice);
                                    Buy = false;
                                    break;
                                case 'M':
                                    break;
                                default:
                                    break;
                            }
                        } while (ChooseBuy != 'M' && ChooseBuy != 'P');
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Please input the quantity of DVD.\n");
                        DVDQuantity = Convert.ToInt32(Console.ReadLine());
                        AllPrice = TVQuantity * 900 + DVDQuantity * 500 + MP3Quantity * 700;
                        if (AllPrice < 5000)
                        {
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900, DVDQuantity * 500, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }
                        if (AllPrice >= 5000&&AllPrice<10000)
                        {
                            AllPrice = (TVQuantity * 900 + DVDQuantity * 500) * 0.9 + MP3Quantity * 700;
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900 * 0.9, DVDQuantity * 500 * 0.9, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }
                        if (AllPrice >= 10000)
                        {
                            AllPrice = (TVQuantity * 900 + DVDQuantity * 500) * 0.85 + MP3Quantity * 700;
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900 * 0.85, DVDQuantity * 500 * 0.85, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is  ${0:0.00}.\n", AllPrice);
                        }

                        do
                        {
                            Console.WriteLine("Enter P to pay your order.\n\nEnter M to get more product or change the quantity for product.\n");
                            ChooseBuy = Convert.ToChar(Console.ReadLine());
                            switch (ChooseBuy)
                            {
                                case 'P':
                                    Console.WriteLine("Please pay ${0:0.00}.\n", AllPrice);
                                    Buy = false;
                                    break;
                                case 'M':
                                    break;
                                default:
                                    break;
                            }
                        } while (ChooseBuy != 'M' && ChooseBuy != 'P');
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Please input the quantity of MP3.\n");
                        MP3Quantity = Convert.ToInt32(Console.ReadLine());
                        AllPrice = TVQuantity * 900 + DVDQuantity * 500 + MP3Quantity * 700;
                        if (AllPrice < 500)
                        {
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900, DVDQuantity * 500, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }
                        if (AllPrice >= 5000&&AllPrice<10000)
                        {
                            AllPrice = (TVQuantity * 900 + DVDQuantity * 500) * 0.9 + MP3Quantity * 700;
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900 * 0.9, DVDQuantity * 500 * 0.9, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }
                        if (AllPrice >= 10000)
                        {
                            AllPrice = (TVQuantity * 900 + DVDQuantity * 500) * 0.85 + MP3Quantity * 700;
                            Console.WriteLine("The products you buy:\n\t{0}  TV  {3}\n\t{1}  DVD  {4}\n\t{2}  MP3  {5}", TVQuantity, DVDQuantity, MP3Quantity, TVQuantity * 900 * 0.85, DVDQuantity * 500 * 0.85, MP3Quantity * 700);
                            Console.WriteLine("Total price for this order is ${0:0.00}.\n", AllPrice);
                        }

                        do
                        {
                            Console.WriteLine("Enter P to pay your order.\n\nEnter M to get more product or change the quantity for product.\n");
                            ChooseBuy = Convert.ToChar(Console.ReadLine());
                            switch (ChooseBuy)
                            {
                                case 'P':
                                    Console.WriteLine("Please pay ${0:0.00}.\n", AllPrice);
                                    Buy = false;
                                    break;
                                case 'M':
                                    break;
                                default:
                                    break;
                            }
                        } while (ChooseBuy != 'M'&&ChooseBuy!='P');
                    }
                    break;
                default:
                    break;
            }
            }       
            
        }
    }
}