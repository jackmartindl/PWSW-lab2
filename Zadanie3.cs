namespace lab_2;

public static class Zadanie3
{
    private static int[,] firstMatrix;
    private static int[,] secondMatrix;
    private static int matrixSize;

    public static void Run()
    {
        Console.Write("Podaj rozmiar macierzy: ");
        matrixSize = Int32.Parse(Console.ReadLine()!);
        firstMatrix = new int[matrixSize, matrixSize];
        secondMatrix = new int[matrixSize, matrixSize];

        for (var i = 0; i < matrixSize; i++)
        {
            for (var j = 0; j < matrixSize; j++)
            {
                firstMatrix[i, j] = new Random().Next(-10, 10);
                secondMatrix[i, j] = new Random().Next(-10, 10);
            }
        }

        Console.WriteLine("Pierwsza macierz: ");
        GetMatrixElements(firstMatrix);
        Console.WriteLine("Druga macierz: ");
        GetMatrixElements(secondMatrix);
        Console.WriteLine("Suma macierzy:");
        GetMatrixElements(MatrixSum());
        Console.WriteLine("Różnica macierzy:");
        GetMatrixElements(MatrixSubtraction());
        Console.WriteLine("Mnożenie macierzy:");
        GetMatrixElements(MatrixMultiply());

    }

    private static void GetMatrixElements(int[,] matrix)
    {
        for (var i = 0; i < matrixSize; i++)
        {
            for (var j = 0; j < matrixSize; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    private static int[,] MatrixSum()
    {
        int[,] returnMatrix = new int[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                returnMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
            }
        }

        return returnMatrix;
    }

    private static int[,] MatrixSubtraction()
    {
        int[,] returnMatrix = new int[matrixSize, matrixSize];
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                returnMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
            }
        }

        return returnMatrix;
    }

    private static int[,] MatrixMultiply()
    {
        int[,] returnMatrix = new int[matrixSize, matrixSize];

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                var temp = 0;
                for (int k = 0; k < matrixSize; k++)
                {
                    temp += firstMatrix[i, k] * secondMatrix[k, j];
                }
                returnMatrix[i, j] = temp;
            }
        }
        
        return returnMatrix;
    }
}