Console.WriteLine("Enter Fibonacci number: ");
int FibonacciNum = int.Parse(Console.ReadLine()?? "0");
int[] FiboArray = new int[FibonacciNum];
Console.Write($"Here are first {FibonacciNum} elements of Fibonacci series: 0   1   ");

for (int i = 2; i < FibonacciNum; i++)
{
    FiboArray[0] = 0;
    FiboArray[1] = 1;
    FiboArray[i] = FiboArray[i - 1] + FiboArray[i - 2];
    Console.Write($"{FiboArray[i]}   ");
}