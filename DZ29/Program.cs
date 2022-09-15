// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray()
{
    int[] array = new int[8];
        for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите элемент {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

        return array;
    }

void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // Console.WriteLine(array[i]);        
    }
    Console.WriteLine($"Ваш массив [{string.Join(",", array)}] ");
}

Console.WriteLine("Введите элементы массива по одному!");

int[] array = GetArray(); // функция через которую заносим элементы в массив
PrintArrayToConsole(array); // функция которая показывает итоговый массив