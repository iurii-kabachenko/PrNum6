// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Random rand = new Random();
        List<int> numbers = new List<int>();
        List<int> primes = new List<int>();
        List<int> nonPrimes = new List<int>();
        int N = 15;

        // Генерація випадкових чисел
        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(1, 51)); // [1; 50]
        }

        Console.WriteLine("Початкова колекція:");
        Console.WriteLine(string.Join(", ", numbers));

        // Розділення
        foreach (int num in numbers)
        {
            if (IsPrime(num))
                primes.Add(num);
            else
                nonPrimes.Add(num);
        }

        Console.WriteLine("\nПрості числа:");
        Console.WriteLine(string.Join(", ", primes));

        Console.WriteLine("\nІнші числа:");
        Console.WriteLine(string.Join(", ", nonPrimes));
    }
}











//Random rand = new Random();
//List<int> numbers = new List<int>();
//List<int> result = new List<int>();
//int N = 10;
//int X = 999; 


//for (int i = 0; i < N; i++)
//{
//    numbers.Add(rand.Next(1, 101)); 
//}

//Console.WriteLine("Початкова колекція:");
//Console.WriteLine(string.Join(", ", numbers));


//foreach (int num in numbers)
//{
//    int firstDigit = int.Parse(num.ToString()[0].ToString());
//    if (firstDigit % 2 == 0)
//    {
//        result.Add(X);
//    }
//    result.Add(num);
//}

//Console.WriteLine("\nКолекція після вставки X:");
//Console.WriteLine(string.Join(", ", result));


//Random rand = new Random();

//Console.WriteLine("Vvedit' rozmir kolekcii N: ");
//int N = Convert.ToInt32(Console.ReadLine());
//List<int> collection = new List<int>();


//for (int i = 0; i < N; i++)
//{
//    collection.Add(rand.Next(1, 51)); 
//}

//Console.WriteLine("pochatkova collection: " + string.Join(", ", collection));


//int minValue = collection.Min();
//collection.Remove(minValue);


//int maxValue = collection.Max();
//collection.Remove(maxValue);

//Console.WriteLine("collection after remove first min and max value:");
//Console.WriteLine(string.Join(", ", collection));

