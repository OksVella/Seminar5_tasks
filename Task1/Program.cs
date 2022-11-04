// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[5];
fillArray(array);
printArray(array);
countEvenNumbers(array);


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
        array[i] = new Random().Next(100, 999);
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

void countEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine(" -> " + count);
}