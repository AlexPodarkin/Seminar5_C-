
Console.Clear();

Console.Write("Введите номер задачи(1-3):");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Aлгоритм считает количество четных элементов \nв рандомном трехзначном массиве и выводит их в консоль");
        int[] array = FillArray(5, 100, 999);
        Console.WriteLine("[" + String.Join(",", array) + "]");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count = count + 1;
            }
        }


        int[] FillArray(int size, int min, int max) // создаем массив с нужнымы параметрами
        {
            int[] filledArray = new int[size];

            for (int i = 0; i < filledArray.Length; i++)
            {
                filledArray[i] = new Random().Next(min, max + 1);
            }
            return filledArray;
        }

        System.Console.WriteLine($"количество положительных элементов массива = {count}");
        break;

    case 2:
        Console.WriteLine("Алгоритм считает сумму элементов \nмассива стоящих на нечетных позициях");
        int[] arrayOr = FillArray(5, 0, 9);
        Console.WriteLine("[" + String.Join(",", arrayOr) + "]");


        int summ = 0;
        int lenArray = arrayOr.Length;
        for (int i = 0; i < lenArray; i++)
        {
            if (i % 2 == 1)
            {
                summ += arrayOr[i];
            }
        }
        Console.WriteLine("Сумма элементов нa нечетных позициях = " + summ);
        break;

    case 3:
        Console.WriteLine("Алгоритм по поиску разницы между максимальным \nи минимальным элементом вещественного массива:");
        void ArrayDouble(double[] num)
        {
            Random random = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.NextDouble() * 100;
                num[i] = Math.Round(num[i], 2);
            }
        }

        double[] array2 = new double[5];
        ArrayDouble(array2);
        Console.WriteLine("[ " + String.Join(" ; ", array2) + "] ");

        int lenArray2 = array2.Length;
        double max = array2[0];
        double min = array2[0];
        for (int i = 1; i < lenArray2; i++)
        {
            if (array2[i] > max) { max = array2[i]; }
            if (array2[i] < min) { min = array2[i]; }
        }
        Console.WriteLine($"Разница между минимальным и максимальным элементом массива = {Math.Round(max - min, 2)} ");
        break;
}






/* */



/* */


/* */


