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
    class NumerSummator
    {
        private int result = 0;
        public void Summator()
        {
            for(int i = 0; i < 11; i++) result += i;
            Console.WriteLine("The sum of first 10 numbers is: " + result);
        }
    }
    class NumberReturner
    {
        private int sum;
        public void SearchEvenNumbers(int start, int end)
        {
            if (start <= end && start >= 0 && end >= 0)
            {
                while (start != end)
                {
                    if (start % 2 == 0)
                    {
                        Console.WriteLine(start);
                    }
                    start++;
                }
            }
        }
        //public void SearchPerfectNumber(int start, int end)
        //{
        //    if (start <= end && start >= 0 && end >= 0)
        //    {
        //        for (int i = start; i <= end; i++)
        //        {
        //            for (int j = 1; j <= i; j++)
        //            {
        //                if (j % i == 0)
        //                {
        //                    sum += i;
        //                }
        //                if (sum == i) Console.WriteLine(i + " - совершенное число");
        //            }
        //        }
                
        //    } else
        //    {
        //        Console.WriteLine("Низ диапазона должен быть меньше верха.");
        //    }
        //}
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

            //fourth task - Получить сумму первых 10 чисел
            NumerSummator numerSummator = new NumerSummator();
            numerSummator.Summator();

            //fifth task - Реализовать метод, который получает число и возвращает все четные числа в диапазоне 
            NumberReturner numberReturner = new NumberReturner();
            numberReturner.SearchEvenNumbers(0, 10);

            //sixth task - Реализовать метод, который получает число и возвращает все соверщенные числа в диапазоне
            //numberReturner.SearchPerfectNumber(6, 30);
        }
    }
}
