// Подсчитать сумму цифр в числе

Console.Clear();
Console.Write("Ввведите число: ");
int number = int.Parse(Console.ReadLine());

int summ = 0;
while (number >0)
{
    summ += number%10;
    number = number/10;
}

Console.WriteLine($"Сумма цифр - {summ}");