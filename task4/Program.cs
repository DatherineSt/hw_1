/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int userNumber = new int();
int userNumber1 = new int();
int userNumber2 = new int();
Console.WriteLine("Введите три числа");
userNumber = Convert.ToInt32(Console.ReadLine());
userNumber1 = Convert.ToInt32(Console.ReadLine());
userNumber2 = Convert.ToInt32(Console.ReadLine());
int max = userNumber;
if(userNumber1 > max) max = userNumber1;
if(userNumber2 > max) max = userNumber2;
Console.WriteLine(max);