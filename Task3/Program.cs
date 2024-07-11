// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{
    int size = InputSize("Введите размер массива: ");
    int[] ints = CreatArray(size, 1, 99);
    System.Console.WriteLine("Задан произвольный массив: ");
    PrintInitionArray(ints);
    System.Console.WriteLine("\nВывод эллементов массива, начиная с конца: ");
    PrintMirrorAray(ints, size);

}

void PrintMirrorAray(int[] arr, int size)
{
    if (size == 0) return;
    System.Console.Write(arr[size - 1] + " ");
    PrintMirrorAray(arr, size -1);
}

void PrintInitionArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }   
}

int[] CreatArray (int size, int valueMin, int valueMax)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(valueMin, valueMax + 1);
    }
    return array;
}

int InputSize(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();