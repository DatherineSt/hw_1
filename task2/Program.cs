/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int userNumber = new int();
int userNumber1 = new int();
Console.WriteLine("Введите два числа");
userNumber = Convert.ToInt32(Console.ReadLine());
userNumber1 = Convert.ToInt32(Console.ReadLine());
if(userNumber>userNumber1)
{
    Console.WriteLine($"max = {userNumber}");
}
else
{
    Console.WriteLine($"max = {userNumber1}");
}
