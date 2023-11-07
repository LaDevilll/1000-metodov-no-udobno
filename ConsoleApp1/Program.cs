using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N: ");
        int N = int.Parse(Console.ReadLine());
        if (N <= 0)
        {
            Console.WriteLine("Число N должно быть больше 0");
        }
        else
        {
            int[] current = PologNechet(N);
            Console.WriteLine("Массив, содержащий первые N положительных нечетных чисел:");
            for (int i = 0; i < current.Length; i++)
            {
                Console.Write(current[i] + " ");
            }

            Console.WriteLine();

            int[] two = StepenDva(N);
            Console.WriteLine("Массив, содержащий степени двойки до N:");
            for (int i = 0; i < two.Length; i++)
            {
                Console.Write(two[i] + " ");
            }
            Console.WriteLine();


            Console.Write("Введите первый член арифметической прогрессии: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите разность арифметической прогрессии: ");
            int dif = int.Parse(Console.ReadLine());
            int[] arithmPr = ArProgres(N, first, dif);
            Console.WriteLine("Массив, содержащий первые N членов арифметической прогрессии:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(arithmPr[i] + " ");
            }
        }
    }

    static int[] PologNechet(int N)
    {
        int[] numbers = new int[N];
        int current = 1;

        for (int i = 0; i < N; i++)
        {
            numbers[i] = current;
            current += 2;
        }

        return numbers;
    }

    static int[] StepenDva(int N)
    {
        int[] two = new int[N];
        for (int i = 0; i < N; i++)
        {
            two[i] = (int)Math.Pow(2, i + 1);
        }
        return two;
    }

    static int[] ArProgres(int N, int first, int dif)
    {
        int[] arithmPr = new int[N];
        arithmPr[0] = first;
        for (int i = 1; i < N; i++)
        {
            arithmPr[i] = arithmPr[i - 1] + dif;
        }
        return arithmPr;
    }
}








































//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Введите целое число N: "); // вводим массив
//        int N = int.Parse(Console.ReadLine());
//        int[] numbers = InputNumbers(N);
//        int minIndex = FindMinIndex(numbers); // метод принимает в себя массив
//        Print(numbers);
//        Console.WriteLine($"Номер минимального элемента: {minIndex}"); // индекс

//        int minimum = FindMinimumElement(numbers);
//        Console.WriteLine($"Минимальный элемент: {minimum}"); // мин элемент 

//        int maxIndex = FindMaxIndex(numbers);
//        Console.WriteLine($"Номер первого минимального элемента: {minIndex}");
//        Console.WriteLine($"Номер последнего максимального элемента: {maxIndex}");
//    }

//    static int[] InputNumbers(int N) // рандомайзер
//    {
//        Random rnd = new Random();
//        int[] numbers = new int[N];
//        for (int i = 0; i < N; i++)
//        {
//            numbers[i] = rnd.Next(-100, 100);
//        }
//        return numbers;
//    }

//    static void Print(int[] numbers) // вывод массива
//    {
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine($"Число {i + 1}: {numbers[i]}"); // в консоль все числа
//        }
//    }

//    static int FindMinIndex(int[] array) // поиск мин значения 
//    {
//        int min = array[0];
//        int minIndex = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < min)
//            {
//                min = array[i];
//                minIndex = i;
//            }
//        }
//        return minIndex;
//    }

//    static int FindMinimumElement(int[] array) // метод для вычисления мин
//    {
//        int minimum = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < minimum)
//            {
//                minimum = array[i];
//            }
//        }
//        return minimum;
//    }

//    static int FindMaxIndex(int[] array) //  последнего максимального 
//    {
//        int max = array[0];
//        int maxIndex = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//                maxIndex = i;
//            }
//        }
//        return maxIndex;
//    }
//}



