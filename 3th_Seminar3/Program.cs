﻿
// Задача No21. Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("enter x_A");
int x_A = int.Parse(Console.ReadLine());
Console.WriteLine("enter y_A");
int y_A = int.Parse(Console.ReadLine());
Console.WriteLine("enter x_B");
int x_B = int.Parse(Console.ReadLine());
Console.WriteLine("enter y_B");
int y_B = int.Parse(Console.ReadLine());

double result = GetRange(x_A,y_A,x_B,y_B);

// if (result == 0)
// {
//     Console.WriteLine("x or y equal zero. data is wrong");
//     return;
// }

Console.WriteLine($"A ({x_A}, {y_A}); B ({x_B}, {y_B}) -> {result}");

double GetRange(int x_A, int y_A, int x_B, int y_B)
{
    result = Math. Sqrt((x_B - x_A) * (x_B - x_A) + (y_B - y_A) * (y_B - y_A)); // ab = √(xb - xa)2 + (yb - ya)2
    
    return result;
}