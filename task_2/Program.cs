int line = GetNumber("Введите количество строк: ");
int collumn = GetNumber("Введите количество столбцов: ");

int[,] matrix = GetFillMatrix(line, collumn);
PrintMatrix(matrix);

int searchLine = GetNumber("Введите позицию строки: ");
int searchCollumn = GetNumber("Введите позицию столбца: ");

SearchElement(searchLine,searchCollumn,matrix);




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

int GetNumber(string message = "")
{
    Console.Write($"{message}: ");
    string input = Console.ReadLine();
    int res = int.Parse(input);
    return res;
}

void SearchElement(int line, int collumn, int[,] array)
{
    if (line <= array.GetLength(0) && collumn <= array.GetLength(1))
    {
        Console.WriteLine(array[line - 1, collumn - 1]);
    }
    else Console.WriteLine("Такого элемента нет");
}