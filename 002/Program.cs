// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100); ;
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

int sum = 0;

for (int i = 0; i < myArray.Length; i += 2)
{
    sum = sum + myArray[i];
}
Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

