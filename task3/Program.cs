// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];
arrayFill(array);
printArray();

void arrayFill(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printArray ()
{

    Console.WriteLine($"[{String.Join("-",array)}]");
}