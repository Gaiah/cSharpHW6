// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101; 3 -> 11; 2 -> 10

void MakeItBinary (int[] array, int num, int count)
{
    for (int i = 0; i <= array.Length; i++)
    {
        if (num > 1)
        {
            array[i] = num % 2;
            Console.Write($"{array[i]}");
            num = num / 2;
        }
        else
        {
            Console.Write("1");
            num -= num;
            break;
        }
        count++;
    } 
    Console.Write($" count is: {count} num is {num} L = {array.Length}");
    Console.WriteLine();
}
// чего только не перепробовала, не получается отзеркалить полученное число
void mirror (int[] arr1, int[] arr2copy)
{
    for (int i = 0; i <= arr1.Length; i++)
    {
        arr2copy[i] = arr1[3];
        Console.Write(arr2copy[i]);
    }
}

Console.WriteLine("Your number: ");
int usnum = int.Parse(Console.ReadLine() ?? "0");
usnum = Math.Abs(usnum);
int count = 0;
int[] BinaryArray = new int[usnum];
MakeItBinary(BinaryArray, usnum, count);
int[] coparr = new int[BinaryArray.Length];
mirror(BinaryArray, coparr);