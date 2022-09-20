// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
int NumberofDigit(int num)
{
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

Console.WriteLine($"Количество чисел: {NumberofDigit(number)}");