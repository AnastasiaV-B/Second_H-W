﻿// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 99)
{
    Console.WriteLine((n % 10));
}
else
{
if(n > 99) 
   n = n / 10;
Console.Write("третьей цифры нет");
}
