// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string num = Convert.ToString(Math.Abs(number));


if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine("Это число является палиндромом");
}

// if (num.Length ! = 5)
// {
//     Console.WriteLine("Это не пятизначное число");
// }

else
    Console.WriteLine("Это число не является палиндромом");