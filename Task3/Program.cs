// Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("номер дня ");
int day = Convert.ToInt32(Console.ReadLine());
string[] dayOfweek = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
Console.WriteLine(day % 7);
if (day % 7 >= 5)
Console.WriteLine(true);
else
Console.WriteLine(false);
