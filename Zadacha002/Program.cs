//Напишите программу,которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// Например:
//a = 25; b = 5 -> да
//a = 2; b = 5 -> нет
Console.Clear();
Console.Write("Введите число a: "); 
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: "); 
int b = int.Parse(Console.ReadLine());


Console.WriteLine($"{Math.Pow(b, 2) == a}");
if(Math.Pow(b, 2) == a)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("a не квадрат b");
}