// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[7];
fillArray(array);
printArray(array);
sumOddNumbers(array);


void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        printFirstBracket(i);
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
        printLastBracket(i, array.Length);
    }
}

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void printFirstBracket(int index)
{
    if (index == 0)
    {
        Console.Write("[");
    }
}

void printLastBracket(int index, int arrayLength)
{
    if (index == arrayLength - 1)
    {
        Console.Write("]");
    }
}

void sumOddNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            count = count + array[i];
        }
    }
    Console.WriteLine(" -> " + count);
}