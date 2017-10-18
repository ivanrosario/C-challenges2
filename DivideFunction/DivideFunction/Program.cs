using System;

namespace DivideFunction
{
    class Program
    {
        public static int DivideTwoNumbers(int number1, int number2)
		{
            return number1 / number2;
		}

        static void Main(string[] args)
        {
            Console.WriteLine(DivideTwoNumbers(6, 2));
        }
    }
}
