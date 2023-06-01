// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.WriteLine("Введите координату X точки A: ");
double x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки A: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z точки A: ");
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X точки B: ");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки B: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z точки B: ");
double z2 = double.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1-z2,2));

Console.WriteLine($"dist = {dist:f2}");
