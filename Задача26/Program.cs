// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// принять на вход число
// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int ReadNumber (string msgToUser)
// {
//     Console.WriteLine(msgToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int DigitCount (int a)
// {
//     int count = 0;
//     for (count i = 0; a != 0; count++)
//     {
//             a = a / 10;
//     }
    
// }
// {
//     int index = 0;
//     for(int i = 1; i <= a; i++)
//     {
//         index = index + 1;
    
//     }
//     return index;
    
// }
// int number = ReadNumber("Введите число: ");
// int a = DigitCount (msgToUser);
// Console.WriteLine(index);

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int CountOfDigits(int number)
{
    int count;
    for(count = 0; number != 0; count++)
    {
        number /= 10; //number = number / 10
    }
    return count;
}

int userNumber = ReadNumber("Введите значение");
int result = CountOfDigits(userNumber);
Console.WriteLine(result);