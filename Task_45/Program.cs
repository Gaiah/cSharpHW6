// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

void NewRandomArray (int[] array)
{
    Console.Write("First array: ");
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(1, 50);
        Console.Write($"[{array[i]}]");
    }    
}

void CopyExistingArray (int[] array1, int[] arrayCopy)
{
    Console.WriteLine();
    Console.Write("Second Array: ");
    for (int i = 0; i < array1.Length; i++)
    {
        arrayCopy[i] = array1[i];
        Console.Write($"[{arrayCopy[i]}]");
    }
}

int[] FirstArray = new int[8];
int[] SecondArray = new int[8];

NewRandomArray(FirstArray);
CopyExistingArray(FirstArray, SecondArray);