// Задача 0. Напишите программу, которая
// 1. на выход принимает число и 
// 2. выдает его квадрат 
// (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое числ: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа  {number} = {square}");

