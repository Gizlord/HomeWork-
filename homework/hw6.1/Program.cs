// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Пример:
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write($"message");
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int[] FillArray(int numbers)//ввод с клавиатуры
{
    int[] array = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        array[i] = Prompt("Введите число");
    }
    return array;
}
int CountPositiveNumbers(int[] array) // кол-во полож чисел
{
    int count = 0;
    foreach(int part in array){
        if(part > 0) count++;
    }
    return count;
}
int numbers = Prompt("Задайте, сколько чисел будет введено: ");
if (numbers < 1)
{
    System.Console.WriteLine($"Введено некорректное число {numbers}");
}
else
{
    int[] array = FillArray(numbers);
    System.Console.Write($"Введены числа: ");
    PrintArray(array);
    System.Console.WriteLine($"Чисел больше нуля: {CountPositiveNumbers(array)}");
}














