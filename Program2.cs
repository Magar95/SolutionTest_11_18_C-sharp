using System;

class ArrayPoly
{

    static int[] array_poly(int[] poly1, int[] poly2, int[] array)
    {

        for (int i = 0; i < poly1.Length; i++)
        {
            for (int n = 0; n < poly2.Length; n++)
            {
                array[i + n] += poly1[i] * poly2[n];

            }

        }
        return array;
    }


    static void Main()
    {

        int[] poly1 = { 0 };
        int[] poly2 = { 0 };

        int num_items = poly1.Length + poly2.Length - 1; // Cумма элементов конечного массива всегда будет на единицу меньше общего количества элементов двух массивов-полиномов
        int[] array = new int[num_items];

        array_poly(poly1, poly2, array);

        array_tests();

    }

    static void array_tests()
    {
        int[] poly1 = { -1, 1 };
        int[] poly2 = { 2, 1 };

        int num_items = poly1.Length + poly2.Length - 1;
        int[] array = new int[num_items];

        array_poly(poly1, poly2, array);

        if (array.Length == 3 )
        {
            System.Console.WriteLine("Тест пройден)");
        }
        else
        {
            System.Console.WriteLine("Тест не пройден(");
        }


        if (array[0] == -2 && array[1] == 1 && array[2] == 1)
        {
            System.Console.WriteLine("Тест пройден)");
        }
        else
        {
            System.Console.WriteLine("Тест не пройден(");
        }
    }
}
