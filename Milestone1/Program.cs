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
            //Roll dice and get total, put into array
            for (int x = 1; x <= NumRolls; x++) 
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1, 7);
                int total = roll1 + roll2;
                // add 1 to the location of th roll the total to the correct location in the array, 
                //(-2 because cant roll the number one and array starts at 0)
                array[total- 2] ++;
                
            }
            //initialize new array for storing %
            double[] perc = new double[11];
            for(int i=0; i<11; i++)
            {
                // get the percent rolled for each number in roll array
                perc[i] = Math.Round((double)array[i] / NumRolls * 100);

            }
            
            //print out results
            for (int z=0; z< perc.Length;z++)
            {
                Console.Write((z + 2) + ": ");
                //write a star for the every percent in the perc array
                for( int inZ=0; inZ< perc[z];inZ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
