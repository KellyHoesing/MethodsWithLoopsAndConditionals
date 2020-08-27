using System;
using System.ComponentModel;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Print1000Range();
            PrintIncreaseByThrees();
            CheckIfEqual(1, 3);
            CheckEvenOrOdd(2);
            CheckPositiveOrNegative(-2);
            CheckAgeForVoting();
            Check10Range();
            MultiplicationTable();
            CreateRandomArray(5);
        }
        public static void Print1000Range() 
        {
            for(int i=-1000; i<=1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintIncreaseByThrees()
        {
            for(int i=3; i<1000; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static bool CheckIfEqual(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine("These numbers are equal!");
                return true;
            }
            else
            {
                Console.WriteLine("These numbers are not equal.");
                return false;
            }
        }
        public static bool CheckEvenOrOdd(int num1)
        {
            if(num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is Even");
                return true;
            }
            else
            {
                Console.WriteLine($"{num1} is Odd");
                return false;
            }
        }
        public static bool CheckPositiveOrNegative(int num1)
        {
            if(num1<0)
            {
                Console.WriteLine($"{num1} is Negative");
                return true;
            }
            else
            {
                Console.WriteLine($"{num1} is Positive");
                return false;
            }
        }
        public static void CheckAgeForVoting()
        {
            Console.WriteLine("What age is your candidate?");
            var num1 =int.Parse(Console.ReadLine());
            if(num1 >= 18)
            {
                Console.WriteLine($"Your candidate can vote!");
            }
            else
            {
                Console.WriteLine($"Your candidate is too young!");
            }
        }
        public static void Check10Range()
        {
            Console.WriteLine("What is your Number?");
            var num1 = int.Parse(Console.ReadLine());
            if(-10<num1 && num1<10)
            {
                Console.WriteLine($"{num1} is between -10 and 10!");
            }
            else
            {
                Console.WriteLine($"{num1} isn't between -10 and 10!");
            }
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("What number would you like a multiplication table for?");
            var num1 = int.Parse(Console.ReadLine());
            for(int i=1; i<=12; i++)
            {
                var prod = num1 * i;
                Console.WriteLine($"{prod}");
            }
        }
        public static Array CreateRandomArray(int num1)
        {
            int[] randArra;
            for (int i = 0; i < num1; i++)
            {
                randArra[i] =int new.Random(1, 20);
            }
            return randArra;
        }
    }
}
