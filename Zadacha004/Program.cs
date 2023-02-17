/*с

456 -> 6

782 -> 2

918 -> 8*/

Console.Clear();

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("третья цифра этого числа -> "+stringNumber[2]);
