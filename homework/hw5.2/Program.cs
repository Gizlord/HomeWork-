//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

//Пример:
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int size = ReadInt("Введите длину массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 1; i < numbers.Length; i+=2)
{
        result += numbers[i];
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");

void FillArrayRandomNumbers(int [] array) //массив заполняется
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) //массив выводится на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  //ввод f
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}








