﻿// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear ();
Console.WriteLine("Введите число");

int N = Math.Abs(int.Parse(Console.ReadLine()!));
int k = -N;
while(k<=N)
{
Console.Write($"{k} ");
k++;
}
