//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("введите число");
int num =Convert.ToInt32(Console.ReadLine());

void show3 (int num1)
{
  if (num>99)
{
    Console.WriteLine("Третья цифра в сумме "+num.ToString()+" = "+num.ToString()[2]);
}
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}
show3(num);