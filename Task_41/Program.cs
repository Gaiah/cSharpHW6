// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void ShowArrayAndCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"You've entered {count} positive number(s)");
}

Console.WriteLine("How many numbers do You want to input? ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] NumArray = new int[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Input {i + 1} number: ");
    NumArray[i] = int.Parse(Console.ReadLine() ?? "0");        
}

ShowArrayAndCount(NumArray);

