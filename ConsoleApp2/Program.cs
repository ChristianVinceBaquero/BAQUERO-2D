using System;

namespace Activity1
{
    public class MathArithmetic
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathArithmetic math = new MathArithmetic();

            int num1, num2;

            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ënter num2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Subration: " + (num1 - num2));
            Console.WriteLine("Multication: " + (num1 * num2));
            Console.WriteLine("Divison: " + (num1 / num2));
        }
    }
}