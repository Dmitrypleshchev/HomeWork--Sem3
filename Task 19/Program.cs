// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine("Это число палиндром");
    }

    else
    {
        Console.WriteLine("Это число не палиндром");
    }
}
else
{
    Console.WriteLine ("Это число не пятизначное");
}
