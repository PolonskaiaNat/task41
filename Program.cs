// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Random randM = new Random();
int M =  randM.Next(1, 10); 
int [] array = new int [M];
int result = 0;
Console.WriteLine($"Введдите числа в количестве {M}");
for (int i=0; i < M; i++)
    {
        Console.WriteLine("Введите число ");
        array[i] = Convert.ToInt32(Console.ReadLine());

            if (array[i]>0)
            {
                result++;
            }
    }
Console.WriteLine($"Чисел больше '0' - {result}");
