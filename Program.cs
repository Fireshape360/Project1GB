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

