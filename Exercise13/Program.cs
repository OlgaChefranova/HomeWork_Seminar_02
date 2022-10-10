// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
if  (num <= 99)
{
   Console.WriteLine("третьей цифры нет");
}
else if (num <= 999)
{
   Console.WriteLine($"третья цифра {num} -> {num % 10}"); 
}
else if (num <= 9999)
{
    Console.WriteLine($"третья цифра {num} -> {num / 10 % 10}");
}
else if (num <= 99999)
{
    Console.WriteLine($"третья цифра {num} -> {num / 100 % 10}");
}