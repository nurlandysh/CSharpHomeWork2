// Напишите программу которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру числа 

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());
int num1 = num/10;
int result = num1 % 10;

Console.WriteLine($"Вторая цифра числа {num} -> {result}");

