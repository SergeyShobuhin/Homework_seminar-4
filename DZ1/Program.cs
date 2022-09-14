// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 //// 2*2*2*2 = 16

int GetDegree(int a, int b)
    {
        int degree = 1;
        for (int i = 1; i <= b; i++)
        {
            degree = degree * a;
        }

        return degree;    
    }


Console.WriteLine("Введите число которое необходимо возвести в степень: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите показатель степени числа: ");
int numberB = int.Parse(Console.ReadLine());

int degree = GetDegree(numberA, numberB);
Console.WriteLine($"Cтепень = {degree}.");
