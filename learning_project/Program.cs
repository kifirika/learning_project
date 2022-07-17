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
            Console.WriteLine("Factorial A is: " + result);
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
        private int [] defaultArray = new int[] { -1, -10, 5, 10, 20, -5};
        private int[] negativeArray;
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
        public void SearchPerfectNumber(int start, int end)
        {
            if (start <= end && start >= 0 && end >= 0)
            {
                for (int i = start; i <= end; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            sum += j;
                            if (sum == i) Console.WriteLine(i + " - perfect number");
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("низ диапазона должен быть меньше верха.");
            }
        }
        public void NegativeSort()
        {
            negativeArray = new int[defaultArray.Length];
            for (int i = 0; i < defaultArray.Length; i++)
            {
                if (defaultArray[i] < 0)
                {
                    negativeArray[i] = defaultArray[i];
                }
            }
            Array.Sort(negativeArray);
            foreach (int i in negativeArray) Console.WriteLine(i);
        }
    }
    class ArrayEvenMunberSummator
    {
        private int [] arr;
        private int sum = 0;
        Random random = new Random();
        public void Summator (int value)
        {
            arr = new int[value];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 11);
                if (i % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Сумма четных элементов массива: " + sum);
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

            //fourth task - Получить сумму первых 10 чисел
            NumerSummator numerSummator = new NumerSummator();
            numerSummator.Summator();

            //fifth task - Реализовать метод, который получает число и возвращает все четные числа в диапазоне 
            NumberReturner numberReturner = new NumberReturner();
            numberReturner.SearchEvenNumbers(0, 10);

            //sixth task - Реализовать метод, который получает число и возвращает все соверщенные числа в диапазоне
            numberReturner.SearchPerfectNumber(6, 35);

            //seventh task - Получить сумму четных чисел в массиве
            ArrayEvenMunberSummator arrayEvenMunberSummator = new ArrayEvenMunberSummator();
            arrayEvenMunberSummator.Summator(15);

            //eighth task - Отсортировать только отрицательные числа в массиве
            numberReturner.NegativeSort();
        }
    }
}
