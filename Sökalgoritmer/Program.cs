using System;
using System.Collections.Generic;

namespace Sökalgoritmer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randomnumber = r.Next(1, 100);
                Console.Write($"{randomnumber} ,");
                numbers.Add(randomnumber);
            }

            Console.WriteLine("Vilket tal söker du efter?");
            int tal = int.Parse(Console.ReadLine());
            
            SekventiellSök(numbers, tal);

            static int SekventiellSök(List<int> number, int värde)
            {
                if (number == null)
                    return -1;

                for(int i = 0; i < number.Count; i++)
                {
                    if (number[i] == värde)
                    {
                        Console.WriteLine($"Ditt tal fanns på indexposition {i}");
                    }
                }

                return -1;

            }

        }
    }
}
