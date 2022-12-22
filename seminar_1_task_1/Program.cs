//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);

int result = b = b * 2;

if (a == b)
{
    Console.WriteLine("Является квадратом второго числа");
}
else
{
    Console.WriteLine("Не является квадратом второго числа");
}