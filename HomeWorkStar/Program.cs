Console.Clear();

Console.WriteLine("Алгоритм задает одномерный массив, заполненный случайными числами. \nнаходит ср. арифметическое из четных и нечетных значений \nэлементов массивов и выводит сравнение");
int[] array = FillArray(4, 0, 9);
Console.WriteLine("[" + String.Join(",", array) + "]");


int summ1arr = 0;
int summ2arr = 0;
int count1 = 0;
int count2 = 0;

int lenArray = array.Length;
for (int i = 0; i < lenArray; i++)
{
    if (array[i] % 2 == 1)
    {   summ1arr += array[i];
        count1 += 1;
    }
    else
    {   summ2arr += array[i]; 
        count2 += 1;
    }
}
int srArChet = summ2arr / count2;
Console.WriteLine($"средн. арифм. массива значений элементов с чётными числами = {srArChet}");
int srArNoChet = summ1arr / count1;
Console.WriteLine($"средн. арифм. массива значений элементов с нечётными числами = {srArNoChet}");
if (srArChet > srArNoChet)
Console.WriteLine("ОТВЕТ: средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами");
else if (srArNoChet > srArChet)
Console.WriteLine("ОТВЕТ: средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами");
else 
Console.WriteLine("ОТВЕТ: средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами");

int[] FillArray(int size, int min, int max) // создаем массив с нужнымы параметрами
{
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

