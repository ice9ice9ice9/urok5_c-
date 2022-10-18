﻿/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */

//инициализация массива рандомные числами от -9 до 9 длиной length
int[] InitArray(int length)
{
    int [] resultArray = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(-9,10);
    }

    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получение числа с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

//получение суммы положительных чисел в массиве
int GetSummOfPositive(int [] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i];
    }
    return summ;
}
