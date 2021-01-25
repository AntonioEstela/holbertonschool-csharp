using System;

/// <summary>Cross</summary>
class VectorMath
{
    /// <summary>Cross</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector2.Length != 3 || vector1.Length != 3)
            return new double[] {-1};

        double[] newVec = new double[3];

        NVec[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        NVec[1] = (vector1[0] * vector2[2]) - (vector1[2] * vector2[0]);
        NVec[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return NVec;
    }
}
