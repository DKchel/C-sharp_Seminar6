// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.



int[] array =  { 51, 42, 13, 9 };
int[] array2 = new int [array.Length];

void CopyArray()
{
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[i];
    }
}

void PrintArray()
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i] + " ");
    }
}

CopyArray();
PrintArray();