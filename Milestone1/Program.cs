using System;

namespace Milestone1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to dice throwing Simulator!");
            Console.WriteLine("How many dice rolls do you want?");
            int NumRolls = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[11];
            for (int x = 1; x <= NumRolls; x++) 
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int total = roll1 + roll2;
                //when you have a total it is 2 greater than the actual 
                //index so you have to minus two to put it into the righ
                //place
                array[total- 2] ++;
                
            }
            double[] perc = new double[11];
            for(int i=0; i<11; i++)
            {
                perc[i] = Math.Round((double)array[i] / NumRolls * 100);

            }
            

            for (int z=0; z< perc.Length;z++)
            {
                Console.Write((z + 2) + ": ");
                for( int inZ=0; inZ< perc[z];inZ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
