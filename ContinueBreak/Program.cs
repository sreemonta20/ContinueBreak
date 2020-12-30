using System;

namespace ContinueBreak
{
    class Program
    {
        public static void Main(string[] args)
        {
            for ( int i = 0; i <=5; i++)
            {
                if (i == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" In Break Value of i is {0}", i);
                }
                
                

            }


            for (int j = 0; j <= 5; j++)
            {
                if (j == 4)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(" In Continue Value of J is {0}", j);
                }
                
                
            }
            Console.ReadKey();

        }
    }
}
