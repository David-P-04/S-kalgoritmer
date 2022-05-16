using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sökalgoritmer
{
    class Program
    {
        static void Main(string[] args)
        {

            /*List<int> numbers = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int randomnumber = r.Next(1, 100);
                // Console.Write($"{randomnumber} ,");
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
                    Thread.Sleep(25);
                }

                return -1;

            }*/
            /*
            int[] numb = new int[100];
            
            for (int i = 0; i < 100; i++)
            {
                numb[i] = i;
            }

            Console.WriteLine("Vilket tal söker du?");
            int sökttal = int.Parse(Console.ReadLine());

            BinärSök(numb, sökttal);

            static int BinärSök(int[] tal, int värde)
            {
                if (tal == null)
                    return -1;

                int start = 0;
                int stop = tal.Length - 1;

                while (start <= stop)
                {
                    int mitt = (start + stop) / 2;
                    if (tal[mitt] < värde)
                        start = mitt + 1;
                    else if (tal[mitt] > värde)
                        stop = mitt - 1;
                    else
                        return mitt;
                }

                return -1;
            }
            */

            List<int> numbers = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 100000; i++)
            {
                int randomnumber = r.Next(1, 100);
                numbers.Add(randomnumber);
            }

            Console.WriteLine("Sorterar de slumpvalda talen");
            DateTime starttid = DateTime.Now;
            BubbleSort(numbers);
            TimeSpan deltatid = DateTime.Now - starttid;
            Console.WriteLine("Det tog {0:0.00} ms sortera dessa tal. \n", deltatid.TotalMilliseconds);

            static void BubbleSort(List<int> numbers)
            {
                bool needToSortNumbers = true;

                for (int i = 0; i < numbers.Count - 1 && needToSortNumbers; i++)
                {
                    needToSortNumbers = false;

                    for (int j = 0; j < numbers.Count - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            needToSortNumbers = true;
                            int tempNumber = numbers[j + 1];
                            numbers[j + 1] = numbers[j];
                            numbers[j] = tempNumber;
                        }
                    }
                }
            }
        }
    }
}