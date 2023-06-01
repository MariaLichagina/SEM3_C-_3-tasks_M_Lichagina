// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num / 1000 == num % 100)
{

    Console.WriteLine("да");

}
else
{

    Console.WriteLine("нет");

}