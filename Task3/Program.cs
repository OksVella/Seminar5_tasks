// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Start here...
double[] array = new double[8];
fillArray(array);
printArray(array);
printDifference(array);

    


//--- Methods ---

void fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        printFirstBracket(i);
        Console.Write(array[i] + " ");
        printLastBracket(i, array.Length);
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

void printDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.Write(max - min);
}
