using System;

namespace exercise1_task1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int number1;

        l1:
            Console.Write("4reqemli eded: ");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                goto l1;
            }

            if (!(number1 >= 1000 && number1 < 10000))
            {
                Console.WriteLine("4reqemli eded daxil edin:");
                goto l1;
            }
           

            
                number1= 7*10000 + number1;
                number1 = number1 * 10 + 8;
            Console.WriteLine($"Result:{number1}");
        }

            
            }
        }
    

