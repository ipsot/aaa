using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongInt
{
    class LongInt
    {
        private long number1, number2;

        public LongInt()
        {
            Console.WriteLine("введите первое число ");
            number1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("введите второе число ");
            number2 = Convert.ToInt64(Console.ReadLine());
            number1 = number2 = 0;
        }

        public LongInt(long number1, long number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public LongInt(LongInt program)
        {
            number1 = program.number1;
            number2 = program.number2;
        }
        public void Write()
        {
            Console.WriteLine($"number1={number1}\tnumber2={number2}");
        }
        public long GetN()
        {
            return number1;
            return number2;
        }

        public void Sum(LongInt program)
        {
            number1 += program.number1;
            number2 += program.number2;
        }
        public void Sum(long number1, long number2)
        {
            this.number1 += number1;
            this.number2 += number2;
        }
        public LongInt SumNN(LongInt program)
        {
            number1 += program.number1;
            number2 += program.number2;
            return this;
        }
        public static LongInt operator +(LongInt num1, LongInt num2)
        {
            LongInt temp = new LongInt(num1);
            temp.Sum(num2);
            return temp;
        }
        public void Substraction(LongInt program)
        {
            number1 -= program.number1;
            number2 -= program.number2;
        }
        public void Substraction(long number1, long number2)
        {
            this.number1 -= number1;
            this.number2 -= number2;
        }
        public LongInt SubstractionNN(LongInt program)
        {
            number1 -= program.number1;
            number2 -= program.number2;
            return this;
        }

        public static LongInt operator -(LongInt num1, LongInt num2)
        {
            LongInt temp = new LongInt(num1);
            temp.Substraction(num2);
            return temp;
        }


        public long CompareTo(LongInt program)
        {
            if ((number1 - number2) > 0)
            {
                return 1;
            }
            else if ((number1 - number2) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static bool operator ==(LongInt num1, LongInt num2)
        {
            return num1.CompareTo(num2) == 0;
        }
        public static bool operator !=(LongInt num1, LongInt num2)
        {
            return num1.CompareTo(num2) != 0;
        }
    }

}
