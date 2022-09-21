/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длинна которых <= 3 символа. Первоначальный массив можно 
ввести с клавиатуры или задать со старта*/

Console.WriteLine("Задайте размер массива в виде числа");

bool isNumber = int.TryParse(Console.ReadLine(), out int m);
if (isNumber == false)
{
    Console.WriteLine("Неверные данные");
    return;
}

string[] array = new string[m];

string[] secondArray = new string[m];

CreateArray(array);

WriteArray(array);

CreateSecondArray(array, secondArray);

WriteArray(secondArray);


void CreateArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Введите элемент массива {i + 1}");

        array[i] = Console.ReadLine();
    }
}

void WriteArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);

        Console.WriteLine();
    }
}

string[] CreateSecondArray(string[] array, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            secondArray[count] = array[i];
            count++;
        }
    }
    Console.WriteLine();
    return secondArray;
}