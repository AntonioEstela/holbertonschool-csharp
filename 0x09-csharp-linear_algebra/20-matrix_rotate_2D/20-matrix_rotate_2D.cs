using System;

/// <summary>Matrix</summary>
class MatrixMath
{
    /// <summary>Multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = {{-1}};
    
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return err;

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] NMatrix = new double[rows1, cols2];

        for (int x = 0; x < rows1; x++)
        {
            for (int y = 0; y < cols2; y++)
            {
                double n = 0; 
                for (int z = 0; z < cols1; z++)
                    n = n + matrix1[x, z] * matrix2[z, y];
                NMatrix[x, y] = n;
            }
        }
        return NMatrix;
    }

    
    /// <summary>Rotate</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double ACos = Math.Cos(angle);
        double ASin = Math.Sin(angle);
        double[,] cosSin = {
            {ACos, -ASin}, 
            {ASin, ACos}
            };

        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] notPossible = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return notPossible;
        }
        newMatrix = Multiply(cosSin, matrix);
        return newMatrix;
    }
}
