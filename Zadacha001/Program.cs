//Напишите программу,которая на вход принимает число и выдает его квадрат (число умноженное на число)
// например:
//4 -> 16
//-3 -> 9


Console.Clear();
Console.Write("Введите число: ");
int number =int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} -> {sqr}({number * number})");

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} -> {sqr1}");
