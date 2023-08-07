// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string result = "";

while (num > 0)
{
    result = num % 2 + result;
    num /= 2;
}

Console.WriteLine(result);