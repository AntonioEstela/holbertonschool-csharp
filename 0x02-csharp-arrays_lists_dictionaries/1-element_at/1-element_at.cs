using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        int i;
        if (index > array.Length || index < 0)
        {
            Console.WriteLine("Index out of range");
            return (-1);
        }

        for (i = 0; i < array.Length; i++)
        {
            if (i == index)
                break;
        }

        return (array[i]);
    }
}