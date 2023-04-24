int line = GetNumber("Введите количество строк: ");
int collumn = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetFillMatrix(line,collumn);
PrintMatrix(matrix);

int[] result = MidSumCollumn(matrix);
PrintArray(result);




void PrintMatrix(int[,] matrix)
{
    for (line = 0; line < matrix.GetLength(0); line++)
    {
        for (collumn = 0; collumn < matrix.GetLength(1); collumn++)
        {
            Console.Write($"|{matrix[line,collumn]}| ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetNumber(string message = "")
{
    Console.Write($"{message}: ");
    string input = Console.ReadLine();
    int res = int.Parse(input);
    return res;
}

int[,] GetFillMatrix(int line, int collumn)
{
    int[,] matrix = new int[line, collumn];
    for (line = 0; line < matrix.GetLength(0); line++)
    {
        for (collumn = 0; collumn < matrix.GetLength(1); collumn++)
        {
            int temp = new Random().Next(-9, 10);
            matrix[line, collumn] = temp;
        }
    }
    return matrix;
}

int[] MidSumCollumn(int[,] matrix)
{
    int[] res = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            res[i] += matrix[j,i];
        }
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"|{array[i]}| ");
    }
}