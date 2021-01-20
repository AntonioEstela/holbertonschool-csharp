using System;

/// <summary>Multiplies a vector and a scalar and returns the resulting vector</summary>
class VectorMath
{
    /// <summary>Multiplies a vector and a scalar and returns the resulting vector</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length > 3 || vector.Length < 2)
            return new double[] {-1};

        double[] result = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
