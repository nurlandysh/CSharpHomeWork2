// Напишите программу которая выводит третью цифру заданного числа 
// или сообщает что третьей цифры нет

Console.Clear();
Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine()!);
int result = 0;
if (num < 1000 && num >=100)
{
    result = num%10;
    Console.WriteLine($"Третья цифра числа {num} -> {result}");
}
else 
{
    Console.WriteLine($"Число не трехзначное!");
}