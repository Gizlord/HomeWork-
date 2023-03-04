// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M:");
int numberN = Convert.ToInt32(Console.ReadLine());

void SumNumberMN (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}"); 
        return;
    }
    sum += numberM++;
    SumNumberMN(numberM, numberN, sum);
}

SumNumberMN(numberM, numberN, 0);




























