﻿//Seminar_1_task_4
//

Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int x3 = Convert.ToInt32(Console.ReadLine());

int max = x1;

if (x2 > x1)
{
    if (x2 > x3)
    {
        max = x2;
    }
}

if (x3 > x1)
{
    if (x3 > x2)
    {
        max = x3;
    }
}

Console.Write("Максимальное из трех чисел: " + max);