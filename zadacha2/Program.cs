﻿/* Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */


void NumReplace(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=array[i]*(-1)
    }
}

void PrintArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[]array = new int [4]; 
Random rnd = new Random();
for(int i=0; i<array.Length; i++)

{
    array[i]=rnd.Next(-10;10);
}