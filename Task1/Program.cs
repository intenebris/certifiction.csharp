// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// Пример 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void Main()
{
    int M = InputNumber("Введите первое число (M): ");
    int N = InputNumber("Введите второе число (N): ");
    DisplayNaturalNumbers(M, N);
}

void DisplayNaturalNumbers(int num1, int num2)
{
    if (num1 < num2) PrintIntNumbers(num1, num2);
    else Console.WriteLine("Вы ввели некорректные данные. M должно быть меньше N. Попробуйте еще раз.");
}

void PrintIntNumbers(int num1, int num2)
{
    if (num1 > num2) return;
    if (num1 == num2) System.Console.Write(num1);
    else System.Console.Write(num1 + ", ");
    PrintIntNumbers(num1 + 1, num2);
}

int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();