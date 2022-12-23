//Выяснить является ли число чётным

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0);
{
    Console.WriteLine("Является четным числом.");
}
else
{
    Console.WriteLine("Не являеется четным числом.");
}