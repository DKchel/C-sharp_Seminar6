// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int num = 0;
int posCount = 0;
WriteNum();

void ColectNeg()
{  
    if (num > 0)
    {
        posCount++;
    }
    Console.WriteLine($"Количество введённых положительных значений: {posCount}");
}

int WriteNum()
{
    Console.WriteLine("Введите число");
    num = Convert.ToInt32(Console.ReadLine());
    ColectNeg();
    return WriteNum();
}

