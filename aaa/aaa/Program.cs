using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongInt
{
    class Program
    {
        static void Main(string[] args)
        {
            LongInt num1 = new LongInt(number1: 1, number2: 1);
            LongInt num2 = new LongInt(number1: 1, number2: 2);

            if (num1 == num2)
            {
                Console.WriteLine($"{num1}={num2}");
            }
            else if ((num1 - num2) > 0)
            {
                Console.WriteLine($"{num1}>{num2}");
            }
            else
            {
                Console.WriteLine($"{num1}<{num2}");
            }

            Console.ReadKey();
        }

    }
}
