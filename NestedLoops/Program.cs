using System;

namespace NestedCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1) Пользователь вводит положительное число(A).
            //Вывести сумму всех цифр у чисел из диапазона от 0 до A.
            Console.WriteLine("Задание 1");
            int value = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < value; i++)
            {
                int tmp = i;
                while (tmp != 0)
                {
                    sum += tmp % 10;
                    tmp /= 10;
                }
            }
            Console.WriteLine(sum);


            //Задание 2) Пользователь вводит 2 числа(A и B).
            //Вывести количество простых чисел(которые делятся только на 1 и самих себя) в диапазоне от A до B.
            Console.WriteLine("Задание 2");
            int userA = int.Parse(Console.ReadLine());
            int userB = int.Parse(Console.ReadLine());
            int summary = 0;

            for (int i = userA; i <= userB; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= (int)Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    summary++;
                }
            }
            Console.WriteLine(summary);

            //Задание 3) Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.
            //Например, для пары 123 и 345, ответом будет являться “ДА”, а, для пары 500 и 999 - “НЕТ”.
            Console.WriteLine("Задание 3");
            string userEnterAString = Console.ReadLine();
            string userEnterBString = Console.ReadLine();
            bool sameness = false;

            int userEnterA = int.Parse(userEnterAString);
            int userEnterB = int.Parse(userEnterBString);
            int currentA = 0;
            int currentB = 0;

            for (int i = 0; i <= userEnterAString.Length; i++)
            {
                currentA = userEnterA % 10;
                userEnterA /= 10;
                for (int j = 0; j <= userEnterBString.Length; j++)
                {
                    currentB = userEnterB % 10;
                    userEnterB /= 10;
                    if (currentA == currentB)
                    {
                        sameness = true;
                        break;
                    }
                }
                if (sameness == true)
                {
                    break;
                }
            }
            if (sameness == true)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");

            }
            Console.ReadLine();
        }
    }
}
