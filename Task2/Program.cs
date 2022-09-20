// Напишите программу, которая на вход принимает число N
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

int result = Factorial(num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");