// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); ;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] myArray = CreateArray(5);
PrintArray(myArray);

int count = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"{count} из них чётные");

