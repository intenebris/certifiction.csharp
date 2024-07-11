// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// Пример
// m = 2, n = 3 -> A(m,n) = 29

void Main()
{
    int m = InputNumber("Введите первое число (m): ");
    int n = InputNumber("Введите второе число (n): ");
    System.Console.WriteLine(CalculateAckermanFunction(m, n));
    //В задаче неверно указан получаемый ответ. A(m,n) = 29 при m = 3, n = 2, а не наоборот.
}

int CalculateAckermanFunction(int num1, int num2)
{
    if (num1 == 0)
        return num2 + 1;
    else if (num2 == 0)
        return CalculateAckermanFunction(num1 - 1, 1);
    else
        return CalculateAckermanFunction(num1 - 1, CalculateAckermanFunction(num1, num2 - 1));
}

int InputNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();