using System;

internal class Program
{
    static void Main(string[] args)
    {
    meow:
        Console.WriteLine("Введите размерность массивчика >.< :");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] m = new int[n];

        if (n  < 1 || n > 100)
        {
            Console.WriteLine("Размерность должна быть 1 <= N <= 100!  Введите новвое значение..");
            goto meow;
        }
        
        Console.WriteLine("Введите элементы массивва:");

        for (int i = 0; i < n; i++)
        {
           m[i] = Convert.ToInt32(Console.ReadLine());
       
        }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (m[i] == -m[j])
                    {
                       
                        Console.WriteLine($"Противоположные числа найдены: {m[i]} (индекс {i}) и {m[j]} (индекс {j})");
                        return;
                    }
                }
            }

     }
}