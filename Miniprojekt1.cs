using System;

class ArrayMin
{
    public int Min(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array eshte i zbrazet ose 0");
        }

        int minValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Vendos se sa elemente deshiron te permbaj Array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Sheno Elementin {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        ArrayMin arrayMin = new ArrayMin();
        int min = arrayMin.Min(array);

        Console.WriteLine($"Elementi me i vogel ne Array eshte: {min}");
    }
}
