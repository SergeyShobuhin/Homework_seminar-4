// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вызов функции
int GetSumNumbers(int num)
    {
        int rezult = 0;
        int remnant;
        while (num > 0)
            {
                remnant = num % 10; // определяем последнее число
                rezult = rezult + remnant; // складываем отделённые числа
                num = num / 10; // отсекаем последнее число            
            }
        return rezult;    
    }

// Определяем число для операции
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = GetSumNumbers(num);
Console.WriteLine($"Сумма чисел {num} равняется {sum}.");
