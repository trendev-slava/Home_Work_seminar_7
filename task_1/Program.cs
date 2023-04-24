int line = GetNumber("Введите количество строк: ");
int collumn = GetNumber("Введите количество столбцов: ");

double[,] matrix = GetFillMatrix(line, collumn);
PrintMatrix(matrix);



int GetNumber(string message = "")
{
    Console.Write($"{message}: ");
    string input = Console.ReadLine();
    int res = int.Parse(input);
    return res;
}

double[,] GetFillMatrix(int line, int collumn)
{
    double[,] matrix = new double[line, collumn];
    for (line = 0; line < matrix.GetLength(0); line++)
    {
        for (collumn = 0; collumn < matrix.GetLength(1); collumn++)
        {
            double temp = new Random().Next(-9, 10) + new Random().NextDouble();
            matrix[line, collumn] = Math.Round(temp, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

