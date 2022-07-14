using System;

namespace learning_project
{
    class NumberOutputer
    {
        private int[] arr;
        public void CheckNumber (int a, int b, int c)
        {
            arr = new int[] { a, b, c };
            Array.Sort(arr);
            foreach (int i in arr) Console.WriteLine(i);
        }
    }
    class NumberReverser
    {
        public void ReverseNumber(int a)
        {
            char [] arr = a.ToString().ToCharArray();
            foreach (char i in arr) i.ToString();
            for (int i = arr.Length; i > 0; i--)
            {
                Console.WriteLine(arr[i - 1]);
            }
        }
    }
    class FactorialNumber
    {
        private int result = 1;
        public void Factorial(int a)
        {
            for (int i = 1; i <= a; i++) result *= i;
            Console.WriteLine("Factorial a is: " + result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // first task - Даны 3 числа . Вывести их в порядке возрастания 
            NumberOutputer numberOutputer = new NumberOutputer();
            numberOutputer.CheckNumber(1, 10, 2);

            // second task - Дано число вывести его обратном порядке
            NumberReverser numberReverser = new NumberReverser();
            numberReverser.ReverseNumber(123);

            // third task - Реализовать метод реализующий факториал 
            FactorialNumber factorialNumber = new FactorialNumber();
            factorialNumber.Factorial(4);
        }
    }
}
