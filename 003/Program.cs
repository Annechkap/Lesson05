// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int len) 
{     
    int[] array = new int[len];     
    Random rnd = new Random();     
    for (int i = 0; i < array.Length; i++)     
    {         
        array[i] = new Random().Next(10,100);  
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
int[] myArray = CreateArray(10);  
PrintArray(myArray); 

int max = myArray[0];
int min = myArray[0];

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] > max)
       {
           max = myArray[i];
        }
    if (myArray[i] < min)
        {
            min = myArray[i];
        }
}

Console.WriteLine($"Максимальное значение = {max:F2}, минимальное значение = {min:F2}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min:F2}");

