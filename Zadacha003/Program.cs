// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Например
// 3 -> среда


//Console.Clear();
//Console.Write("Введите номер дня недели: ");

//int numberDayOfWeek = int.Parse(Console.ReadLine());
//if(numberDayOfWeek<1 || numberDayOfWeek>7)
//{
    //Console.WriteLine("Введен неверный номер дня недели");
  //  return;
//}
//if (numberDayOfWeek == 1)
//{Console.Write("Понедельник");}

//if (numberDayOfWeek == 2)
//{Console.Write("Вторник");}

//if (numberDayOfWeek == 3)
//{Console.Write("Среда");}

//if (numberDayOfWeek == 4)
//{Console.Write("Четверг");}

//if (numberDayOfWeek == 5)
//{Console.Write("Пятница");}

//if (numberDayOfWeek == 6)
//{Console.Write("Суббота");}

//if (numberDayOfWeek == 7)
//{Console.Write("Воскресенье");}






//через while 
    
Console.Clear();
Console.Write("Введите номер дня недели: ");

int numberDayOfWeek = int.Parse(Console.ReadLine());
while(numberDayOfWeek<1 || numberDayOfWeek>7)
{
    Console.WriteLine("Введен неверный номер дня недели");
    Console.Write("Введите номер дня недели: ");
    numberDayOfWeek = int.Parse(Console.ReadLine());

}
if (numberDayOfWeek == 1)
{Console.Write("Понедельник");}

if (numberDayOfWeek == 2)
{Console.Write("Вторник");}

if (numberDayOfWeek == 3)
{Console.Write("Среда");}

if (numberDayOfWeek == 4)
{Console.Write("Четверг");}

if (numberDayOfWeek == 5)
{Console.Write("Пятница");}

if (numberDayOfWeek == 6)
{Console.Write("Суббота");}

if (numberDayOfWeek == 7)
{Console.Write("Воскресенье");}
