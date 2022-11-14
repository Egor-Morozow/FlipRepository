
static void PrintArray(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i] + " ");
    }
    Console.WriteLine();
}

var task1Input = new int[] { 1, 5, 3, 8 };
var result = SummingTask1(task1Input);
Console.Write("TASK 1:\nInput:\n");
PrintArray(task1Input);
Console.WriteLine("Result:");
PrintArray(result);

var task2Input = new int[] { 1, 5, 3, 8, 9, 10 };
var result2 = SummingTask2(task2Input);
Console.Write("TASK 2:\nInput:\n");
PrintArray(task2Input);
Console.WriteLine("Result:");
PrintArray(result2);

var task3Input = new int[] { 1, 5, 3, 8, 7, 6, 4 };
var result3 = SummingTask3(task3Input);
Console.Write("TASK 3:\nInput:\n");
PrintArray(task3Input);
Console.WriteLine("Result:");
PrintArray(result3);

var task4Input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
var result4 = SummingTask4(task4Input, 3);
Console.Write("TASK 4:\nInput:\n");
PrintArray(task4Input);
Console.WriteLine("Result:");
PrintArray(result4);

var task5Input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
var result5 = SummingTask5(task5Input, 3);
Console.Write("TASK 5:\nInput:\n");
PrintArray(task5Input);
Console.WriteLine("Result:");
PrintArray(result5);

var task6Input = new int[] { 1, 5, 3, 8, 9, 10};
var result6 = SummingTask6(task6Input, 3);
Console.Write("TASK 6:\nInput:\n");
PrintArray(task6Input);
Console.WriteLine("Result:");
PrintArray(result6);

var task7Input = new int[] { 1, 2, 3, 4, 5, 6};
var result7 = SummingTask7(task7Input, 3);
Console.Write("TASK 7:\nInput:\n");
PrintArray(task7Input);
Console.WriteLine("Result:");
PrintArray(result7);

static int[] SummingTask1(int[] input)
{
    var result = new int[input.Length];
    for (int i = input.Length - 1; i >= 0; i--)
    {
        result[input.Length - i - 1] = input[i];
    }
    return result;
}

static int[] SummingTask2(int[] input)
{
    int[] result = new int[input.Length * 2];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
        result[i + input.Length] = input[i];
    }
    return result;
}

static int[] SummingTask3(int[] input)
{
    int[] result = new int[input.Length * 2];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
        for (int j = input.Length - 1; j >= 0; j--)
        {
            result[input.Length + j] = input [input.Length - j - 1];
        }
    }
    return result;
}

static int[] SummingTask4(int[] input, int blockSize)
{
    int[] result = new int[input.Length];
    int blockCount = input.Length / blockSize;
    for (int nb = 0; nb < blockCount; nb++)
    {
        for (int i = 0; i < blockSize; i++)
        {
            result[input.Length - (nb + 1) * blockSize + i] = input[nb * blockSize + i];
        }
    }
    return result;
}

static int[] SummingTask5(int[] input, int width)
{
    int[] result = new int[input.Length];
    for (int i = result.Length; i > 0; i -= width)
    {
        for (int j = width - 1; j >= 0; j--)
        {
            result[j + i - width] = input[i - 1 - j];
        }
    }
    return result;
}

static int[] SummingTask6(int[] input, int width)
{
    int[] result = new int[input.Length * 2];
    for (int k = 0; k < input.Length; k++)
    {
        result[k] = input[k];
        for (int i = result.Length; i > input.Length; i -= width)
        {
            for (int j = input.Length + width - 1; j >= input.Length; j--)
            {
                result[i - width + j - input.Length ] = input[i - j - 1];
            }
        }
    }
    return result;
}

static int[] SummingTask7(int[] input, int blockSize)
{
    int[] result = new int[input.Length * 2];
    int blockCount = input.Length / blockSize;
    for (int k = 0; k < input.Length; k++)
    {
        result[k] = input[k];
        for (int nb = 0; nb < blockCount; nb++)
        {
            for (int i = input.Length; i < input.Length + blockSize; i++)
            {
                result[result.Length - (nb + 1) * blockSize + i - input.Length] = input[nb * blockSize + i - input.Length];
            }
        }
    }
    return result;
}
