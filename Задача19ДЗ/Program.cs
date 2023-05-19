﻿// Задача c квадратами  Console.WriteLine(i * i);
// или с кубами  Console.WriteLine(i * i * i);

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while(i <= number)
// {
//     Console.WriteLine(i * i);
//     i++;
// }
for(int i = 1; i <= number; i++)
{
    Console.WriteLine(i * i * i);
}