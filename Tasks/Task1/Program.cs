// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] array = new int [] { 1, 2, 3, 4, 5};

int[] array = { 1, 3, 5, 8, 9, 7, 4, 6, 2 };

void ReversArray()
{
    for (int i = 0; i < array.Length / 2; i++)   // потому, что меняем половину массива, иначе вернёт всё на место.
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

PrintArray();
Console.WriteLine();
ReversArray();
PrintArray();