﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"max = {max} ");


// if (num1>num2)
//     Console.WriteLine($"max = {num1} ");
//     else if (num1<num2)
//     Console.WriteLine($"max = {num2} ");
//     else Console.WriteLine("Числа равны ");


// else Console.WriteLine("Число не известно ");
// if (num1>num2)
//     Console.WriteLine($"max = {num1} ");
//     else if (num1<num2)
//     Console.WriteLine($"max = {num2} ");
//     else Console.WriteLine($"max = {num3} ");




