//Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 100 | num >999)
{
    Console.WriteLine("введите трехзначное число");
    num = Convert.ToInt32(Console.ReadLine());
}

int showNum2 (int num1)
{
    int secondSymbol = (num1 / 10) % 10;
    return (secondSymbol);
}

Console.WriteLine(showNum2(num));