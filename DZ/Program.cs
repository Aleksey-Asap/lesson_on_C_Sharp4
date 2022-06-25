// Домашнее задание: 
// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 
// 2, 4 -> 16

// Console.WriteLine("Введите два числа: ");
// int Factorial(int A, int B)
// {
//     int sum = 1;
//     for (int i = 0; i < B; i++)
//     {
//         sum *= A;
//     }
//     return sum;
// }
// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// Console.WriteLine(Factorial(A,B));

// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12
// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int sum = 0;
// int i = 0;
// while (N > 0)
// {
//     i = N % 10;
//     sum += i;
//     N = N / 10;
// }
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]
// int[] array = new int[8];


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);

// }

// void PrintArray (int[] collection)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         Console.Write(collection[i] + " ");
//     }
// }
// PrintArray(array);