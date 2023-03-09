// 

double[,] CreateMatrix(int Row, int Column, double leftRange, double rightRange)
{
    double[,] matrix = new double[Row, Column];
    Random rand = new Random();

    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Column; j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 1);
        }
    }

    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int EnterSize(string text)
{
    System.Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int m = EnterSize("Input rows - ");
int n = EnterSize("Input columns - ");
double[,] myMatrix = CreateMatrix(m, n, -10, 10);
PrintArray(myMatrix);