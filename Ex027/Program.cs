/* Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.WriteLine("Введите число : ");
var number = int.Parse(Console.ReadLine());

var n = number;
var summ = 0;

while(n != 0)
{
    if(n > 0) 
    {
        summ = (n / 1000) + (n / 100 % 10) + (n % 100 / 10) + (n % 10);
        break;
    }
}

Console.WriteLine($"Сумма чисел - {summ}");

