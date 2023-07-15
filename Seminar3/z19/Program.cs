// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите число");
string num = Console.ReadLine();

int len = num.Length;

if(len==5)
{
    if(num[0]==num[4] && num[1]==num[3])
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}

