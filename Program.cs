// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int M = new Random().Next(1,9);
// Console.WriteLine($"Введите {M} чисел");
// int count = 0;
// int[] arr = new int[M];
// for (int i = 1; i <= M; i++)
// {
//     int temp = int.Parse(Console.ReadLine());
//     if (temp > 0) count++;
//     arr[i-1] = temp;
// }
// Console.WriteLine($"Вы ввели числа: {String.Join(" ,", arr)}");
// Console.WriteLine($"Количество введенных чисел больше ноля: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1           
// y = k2 * x + b2 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Точка пересечения (x, y) = ((b1× c2 − b2× c1)/(a1×b2 − a2×b1), (c1×a2 − c2×a1)/(a1×b2 − a2×b1))


Console.WriteLine("Введите точку b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = -1000;
bool flag = false;
for (double i = -999.9; i < 999.9; i = i + 0.1)
{
    if (k1 * Math.Round(i,2) + b1 != k2 * Math.Round(i,2) + b2)
    {
        continue;
    }
    else
    {
        x = Math.Round(i,2);
        flag = true;
        break;
    }     
}
double y = Math.Round(k1 * x + b1, 2);
if (flag) Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");
else Console.WriteLine("Прямые параллельны");