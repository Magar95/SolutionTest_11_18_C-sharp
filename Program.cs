using System;

// Задача №1
class CopyArray
{

    static int[] CopyArr(int[] array1, int[] array2, int num_items)
    {

        for (int i = 0; i < num_items; i++)
        {
            array2[i] = array1[i];
        }
        return array2;
    }

    static void Main()
    {
        int num_items = 0;

        int[] array1 = {};
        int[] array2 = new int[num_items];

        CopyArr(array1, array2, array1.Length);

        array_test();

    }


    static void array_test()
    {
        int[] array1 = { 4, 8, 15, 16, 23, 42, 't' };
        int[] array2 = new int[7];

        CopyArr(array1, array2, array1.Length);

        if (array1.Length == array2.Length)
        {
            System.Console.WriteLine("Тест пройден)");
        }
         else
        {
            System.Console.WriteLine("Тест не пройден(");
        }

        if (array1[0] == 4 && array2[0] == 4)
        {
            System.Console.WriteLine("Тест пройден)");
        }
        else
        {
            System.Console.WriteLine("Тест не пройден(");
        }

        if (array1[3] == 16 && array2[3] == 16)
        {
            System.Console.WriteLine("Тест пройден)");
        }
        else
        {
            System.Console.WriteLine("Тест не пройден(");
        }

        if (array1[6] == 't' && array2[6] == 't')
        {
            System.Console.WriteLine("Тест пройден)");
        }
        else
        {
            System.Console.WriteLine("Тест не пройден(");
        }

    }

}
