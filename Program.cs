// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Сколько чисел будет в массиве(число М)?:");

int m = Convert.ToInt32(Console.ReadLine());

int [] array = new int [m];

for(int i = 1; i <= m; i++)
{
    Console.WriteLine(i + " число задайте:");
    array[i - 1] = Convert.ToInt32(Console.ReadLine());
}

int counter = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        counter++;
    }
}

Console.WriteLine("Количество чисел больше нуля: " + counter);


// Задача 43:  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Расчет пересечения двух прямых.");

Console.WriteLine("Введите угловой коэффициент k1:");

double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите действительное число b1");

double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите угловой коэффициент k2:");

double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите действительное число b2");

double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2) ;

double y = (k1 * x) + b1;

Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");




















