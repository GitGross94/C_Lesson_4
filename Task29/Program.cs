//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


    void arr()
    {
        int[] massiv = new int[8];
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"Введите элемент массива под номером {i}.");
            massiv[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("Введеный массив: ");
        for (int j = 0; j < massiv.Length; j++)
        {
            Console.Write($"{massiv[j]} ");
        }
    }
    arr();