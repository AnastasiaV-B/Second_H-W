// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5

Console.WriteLine("Введите число...");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals(""))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
