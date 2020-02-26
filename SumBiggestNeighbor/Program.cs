using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBiggestNeighbor
{
    class Program
    {
        //complexity is O(n)
        static int Challenge(int[] input)
        {

            List<int> resultList = new List<int>();
            for (int i = 0; i < input.Length - 1; i++)
            {
                resultList.Add(input[i] + input[i + 1]);
            }

            Console.WriteLine($"[{string.Join(",", input)}] \n");

            if (resultList.Count < 1)
                return input[0];

            return resultList.Max();
        }

        static void mainScreen()
        {
            Console.WriteLine("Please enter the numbers count");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            if (arraySize > 0)
            {
                int[] array = new int[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine($"Elemnt {i + 1} -> ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Sum Biggest Neighbor is : {Program.Challenge(array)} \n");
                Console.WriteLine("Would you try again ? Y/N");
                bool tryAgina = Console.ReadLine().ToLower() == "y";
                if (tryAgina)
                    mainScreen();
                else
                {
                    Console.WriteLine("Bye Bye");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("*Error : numbers count must be greater than 0 \n");
                mainScreen();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("****** Sum of Biggest Neighbor ****** \n");
            mainScreen();
        }
    }
}
