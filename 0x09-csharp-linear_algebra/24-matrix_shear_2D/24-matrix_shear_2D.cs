using System;

/// <summary>Matrix</summary>
class MatrixMath
{
    /// <summary>Shear Matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] NMatrix = new double[2,2];
        double[,] SMatrix = 
        {
            {1, factor},
            {0, 1}
        };

        double[,] err = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return err;

        if (direction != 'x' && direction != 'y')
            return err;

        NMatrix[0,0] = SMatrix[0,0] * matrix[0,0] + SMatrix[0,1] * matrix[0,1];
        NMatrix[0,1] = matrix[0,1];
        NMatrix[1,0] = SMatrix[0,0] * matrix[1,0] + SMatrix[0,1] * matrix[1,1];
        NMatrix[1,1] = matrix[1,1];
        return NMatrix;
    }
}
