﻿/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

(double x, double y) FindCrossPoint(LineFunction factor1, LineFunction factor2)
{
    double x = (factor2.b - factor1.b) / (factor1.k - factor2.k);
    double y = (factor1.k * x) + factor1.b;
    return (x, y);
}

LineFunction GetFactors(string equationNumber)
{
    LineFunction factorToFill;
    Console.Write("Введите значение k{0}:", equationNumber);
    factorToFill.k = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение b{0}:", equationNumber);
    factorToFill.b = Convert.ToDouble(Console.ReadLine());
    return factorToFill;
}

LineFunction equation1, equation2;
double pointX, pointY;

Console.Clear();
Console.WriteLine("Найдём точку пересечения двух прямых,");
Console.Write("заданных уравнениями ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("y = k1 * x + b1");
Console.ForegroundColor = ConsoleColor.White;
Console.Write(",");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" y = k2 * x + b2");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

equation1 = GetFactors("1");
equation2 = GetFactors("2");

(pointX, pointY) = FindCrossPoint(equation1, equation2);
Console.WriteLine();

Console.WriteLine("Координаты точки пересечения = ({0} , {1}).", Math.Round(pointX, 1), Math.Round(pointY, 1));


public record struct LineFunction // y = k * x + b
{
    public double k;
    public double b;
}