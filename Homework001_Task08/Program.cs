﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите какое-нибудь число ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= num)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i + "");
    }  
i = i + 1;    
}
if(num <= 1)
Console.WriteLine("Введите другое число");
