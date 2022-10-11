// Напишите программу которая принимает на вход число обознач день недели 
// и проверяет явл ли этот день выходным

Console.Clear();
Console.WriteLine("Чтобы узнать выходной ли день,");
Console.WriteLine("Введите цифру дня недели; ");
Console.WriteLine("Понедельник -> 1");
Console.WriteLine("Вторник -> 2");
Console.WriteLine("Среда -> 3");
Console.WriteLine("Четверг -> 4");
Console.WriteLine("Пятница -> 5");
Console.WriteLine("Суббота -> 6");
Console.WriteLine("Воскресенье -> 7");

int N = int.Parse(Console.ReadLine()!);
if (N > 0 && N < 6)
{
    Console.WriteLine("Нет!");
}
else 
{
    Console.WriteLine("Да, это выходной!");
}