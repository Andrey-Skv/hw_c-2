// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

void showWeekend()
{

int num = 0;
Console.WriteLine("введите число от 1 до 7");
num = Convert.ToInt32(Console.ReadLine());

while (num < 1 | num > 7)
{
    Console.WriteLine("введите число от 1 до 7");
    num = Convert.ToInt32(Console.ReadLine());
}
if (num == 1)
 {
    Console.WriteLine("сегодня будний день");
 }
if (num == 2)
  {
    Console.WriteLine("сегодня будний день");
  }
  if (num == 3)
  {
    Console.WriteLine("сегодня будний день");
  }
  if (num == 4)
  {
    Console.WriteLine("сегодня будний день");
  }
  if (num == 5)
  {
    Console.WriteLine("сегодня будний день");
  }
  if (num == 6)
  {
    Console.WriteLine("сегодня выходной");
  }
  if (num == 7)
  {
    Console.WriteLine("сегодня выходной");
  }
}

showWeekend();