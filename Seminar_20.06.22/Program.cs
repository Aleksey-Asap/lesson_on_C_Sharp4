// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28 
// 4 -> 10 
// 8 -> 36
// Console.WriteLine("Введите число: ");
// int A = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= A; i++)
// {
//     sum += i;
// }
// Console.WriteLine(sum);

// Задача 26. Напишите программу, которая принимает на вход 
// число и выдает кол-во цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Решение задачи 26 способ 1:
// Console.WriteLine("Enter number: ");
// int A = int.Parse(Console.ReadLine());
// if (A == 0)
// {
//     Console.WriteLine("1");
// }
// else
// {
//     int count = 0;
//     for (; A > 0; A = A / 10)
//     {
//         count++;
//     }
//     Console.WriteLine("Number:" + count);
// }
// Решение задачи 26 при помощи Функции
//
// int Fuct(int A)
// {
//     int count = 0;
//     for ( ; A > 0; A = A / 10)
//     {
//         count ++;
//     }
//     return count;
// }
// Console.WriteLine("Enter number: ");
// int A = int.Parse(Console.ReadLine());
// int n = Fuct (A);
// if (A == 0)
// {
//     Console.WriteLine("Введите цифру не О");
// }
// else
// {
//     Console.WriteLine(n);
// }
// Solution of problem 26 method 2

// int CountDigit( int num)
// {
//     int result = 0;
//     if (num != 0)
//     {
//         for ( ; num != 0; num /= 10)
//         {
//             result++;
//         }
//     }
//     else result = 1;
//     return result;
// }

// double number = 0.28;
// while (number % 1 != 0 & number != 0)
// {
//     Console.WriteLine("Please, enter an integer number or zero");
//     number = double.Parse(Console.ReadLine());
// }
// Console.WriteLine(CountDigit((int)number));

// Задача: Найти длину числа.
// int N = 12345;
// Console.WriteLine(N.ToString().Length);
// 

// Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N. 
// 4 -> 24; 
// 5 -> 120.
// 
// int Factorial(int N)
// {
//     int result = 1;
//     for (int i = 1; i <= N; i += 1)
//     {
//         result *= i;
//     }
//     return result;
// }
// int N = 0;
// while (N < 1)
// {
//     Console.WriteLine("Please, enter an integer positive number more than 0");
//     N = int.Parse(Console.ReadLine());
// }
// Console.WriteLine(Factorial(N));

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке. 
// [1,0,1,1,0,1,0,0]

// int[] array = new int[4];


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);

// }

// void PrintArray (int[] collection)
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         Console.Write(collection[i] + " ");
//     }
// }
// PrintArray(array);