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

            List<int> numbers = new List<int>();
            Random r = new Random();
            Console.WriteLine("Skapar slumpad längd av 1000");
            int datalängd = 1000;
            for (int i = 0; i < datalängd; i++)
            {
                int randomnumber = r.Next(1, datalängd);
                numbers.Add(randomnumber);
            }

            Console.WriteLine("Sorterar slumpad data");
            DateTime starttid = DateTime.Now;
            BubbleSort(numbers);
            TimeSpan deltatid = DateTime.Now - starttid;
            Console.WriteLine("Det tog {0:0.00} ms sortera.", deltatid.TotalMilliseconds);

            Console.WriteLine("Sorterar redan sorterad data");
            DateTime starttid1 = DateTime.Now;
            BubbleSort(numbers);
            TimeSpan deltatid1 = DateTime.Now - starttid1;
            Console.WriteLine("Det tog {0:0.00} ms sortera. \n", deltatid1.TotalMilliseconds);

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

            Console.WriteLine("Vilket tal söker du?");
            int sökttal = int.Parse(Console.ReadLine());

            DateTime starttid2 = DateTime.Now;
            BinärSök(numbers, sökttal);
            TimeSpan deltatid2 = DateTime.Now - starttid2;
            Console.WriteLine("Det tog {0:0.00} ms att Binärsöka.", deltatid2.TotalMilliseconds);

            static int BinärSök(List<int> tal, int värde)
            {
                if (tal == null)
                    return -1;

                int start = 0;
                int stop = tal.Count - 1;

                while (start <= stop)
                {
                    int mitt = (start + stop) / 2;
                    if (tal[mitt] < värde)
                        start = mitt + 1;
                    else if (tal[mitt] > värde)
                        stop = mitt - 1;
                    else
                    {
                        if (tal[mitt] == värde)
                        {
                            Console.WriteLine($"Ditt tal fanns på indexposition {mitt}");
                        }
                        return mitt;
                    }
                }

                return -1;
            }

            Console.WriteLine("Vilket tal söker du efter?");
            int tal = int.Parse(Console.ReadLine());

            DateTime starttid3 = DateTime.Now;
            SekventiellSök(numbers, tal);
            TimeSpan deltatid3 = DateTime.Now - starttid3;
            Console.WriteLine("Det tog {0:0.00} ms att Sekventiellsöka.", deltatid3.TotalMilliseconds);
            
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