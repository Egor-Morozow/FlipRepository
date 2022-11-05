
static void PrintArray(int[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write(input[i] + " ");
    }
    Console.WriteLine();
}

/*var task1Input = new int[] { 1, 5, 3, 8 };
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

var task3Input = new int[] { 1, 5, 3, 8 };
var result3 = SummingTask3(task3Input);
Console.Write("TASK 3:\nInput:\n");
PrintArray(task3Input);
Console.WriteLine("Result:");
PrintArray(result3);*/

var task4Input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
var result4 = SummingTask4(task4Input, 4);
Console.Write("TASK 4:\nInput:\n");
PrintArray(task4Input);
Console.WriteLine("Result:");
PrintArray(result4);

/*var task5Input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
var result5 = SummingTask5(task5Input, 2);
Console.Write("TASK 5:\nInput:\n");
PrintArray(task5Input);
Console.WriteLine("Result:");
PrintArray(result5);

var task6Input = new int[] { 1, 5, 3, 8};
var result6 = SummingTask6(task6Input, 2);
Console.Write("TASK 6:\nInput:\n");
PrintArray(task6Input);
Console.WriteLine("Result:");
PrintArray(result6);

var task7Input = new int[] { 1, 5, 3, 8 };
var result7 = SummingTask7(task7Input, 2);
Console.Write("TASK 7:\nInput:\n");
PrintArray(task7Input);
Console.WriteLine("Result:");
PrintArray(result7);

static int[] SummingTask1(int[] input)
{
    var result = new int[input.Length];
    int j = 0;
    for (int i = input.Length - 1; i >= 0; i--)
    {
        result[j] = input[i];
        j++;
    }
    return result;
}

static int[] SummingTask2(int[] input)
{
    int[] result = new int[input.Length * 2];
    int j = input.Length;
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
        result[j] = input[i];
        j++;
    }
    return result;
}

static int[] SummingTask3(int[] input)
{
   int[] result = new int[input.Length * 2];
   int j = result.Length - 1;
   for (int i = 0; i < input.Length; i++)
   {
       result[i] = input[i];
       result[j] = input[i];
       j--;
   }
   return result;
}*/

static int[] SummingTask4(int[] input, int blockSize)
{
    int[] result = new int[input.Length];
    int x = 0;
    for (int i = input.Length; i > 0; i--)
    {
        if (i % blockSize == 0)
        {
            int startIndex = i - blockSize;
            for (int w = x, q = 0; w < result.Length; w++) 
            {
                if (q < blockSize)
                {
                    result[w] = input[startIndex + q];
                    q++;
                }
                if (q == blockSize)
                {
                    x = w + 1;
                    break;
                }
            }
        }
    }
    return result;
}

/*static int[] SummingTask5(int[] input, int width)
{
    int[] result = new int[input.Length];
    int n = 0;
    int m = width;
    for (int i = width - 1; i >= 0; i--)
    {
        result[n] = input[i];
        n++;
    }
    for (int j = result.Length - 1; j >= width; j--)
    {
        result[m] = input[j];
        m++;
    }
    return result;
}

static int[] SummingTask6(int[] input, int width)
{
    int[] result = new int[input.Length * 2];
    int n = input.Length;
    int m = result.Length - 1;
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
    }
    for (int j = width - 1; j >= 0; j--)
    {
        result[n] = input[j];
        n++;
    }
    for (int k = width; k < input.Length; k++)
    {
        result[m] = input[k];
        m--;
    }
    return result;
}

static int[] SummingTask7(int[] input, int blockSize)
{
    int[] result = new int[input.Length * 2];
    int n = input.Length;
    int m = result.Length - 1;
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
    }
    for (int j = blockSize; j < input.Length; j++)
    {
        result[n] = input[j];
        n++;
    }
    for (int k = blockSize - 1; k >= 0; k--)
    {
        result[m] = input[k];
        m--;
    }
    return result;
}*/
