using System.Runtime.ConstrainedExecution;

//Задание 1
// PrintLine();
// Console.WriteLine("Отчет");
// PrintLine();
// PrintHeader("Привет");
// PrintHeader("hi");
//Задание 2.1
// int a = Max(12, 32);
// Console.WriteLine(a);
// Console.WriteLine(Max(2, 0));
//Задание 2.2
// bool a = IsEven(4);
// bool b = IsEven(7);
// bool c = IsEven(0);
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
//Задание 3
int[] a = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(a));
// Console.WriteLine(CountGreater(a, 100));
//Задание 4
// Console.WriteLine(ToFahrenheit(0));
// Console.WriteLine(ToFahrenheit(100));
// Console.WriteLine(ToFahrenheit(37));
//Задание 5
// Console.WriteLine(Factorial(5));
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.WriteLine(i);
//     }
// }
//Задание 6
// int a = ReadPositive("Введите первое положительное число: ");
// int b = ReadPositive("Введите второе положительное число: ");
// Console.WriteLine(a + b);
//Иторговая задача
int n;
do
{
    Console.WriteLine("1 - Максимальное число из 2х чисел");
    Console.WriteLine("2 - Факториал");
    Console.WriteLine("3 - количество элементов, больших числа");
    Console.WriteLine("0 - Выход");
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1: Console.WriteLine(Max(1, 2));break;
        case 2: Console.WriteLine(Factorial(5));break;
        case 3: Console.WriteLine(CountGreater(a, 100));break;
        case 0: break;
        default: Console.WriteLine("Нет такого пункта");break;
    }
}while (n != 0);
//Доп задание
// Console.WriteLine(Gcd(48, 18));
// Console.WriteLine(Lcm(4, 6));

static void PrintLine()
{
    Console.WriteLine("^_^");
}
static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}
static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
static bool IsEven(int n)
{
    if (n % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
static double Average(int[] arr)
{
    double t = 0.0;
    foreach (int i in arr)
    {
        t += i;
    }
    return t / arr.Length;
}
static int CountGreater(int[] arr, int limit)
{
    int c = 0;
    foreach (int i in arr)
    {
        if (i > limit)
        {
            c += 1;
        }
    }
    return c;
}
static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}
static long Factorial(int n)
{
    int r = 1;
    for (int i = 1; i <= n; i++)
    {
        r *= i;
    }
    return r;
}
static bool IsPrime(int n)
{
    if (n <= 1) return false;
    int c = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            c += 1;
        }
    }
    if (c != 2)
    {
        return false;
    }
    else
    {
        return true;
    }
}
static int ReadPositive(string message)
{
    int n;
    do
    {
        Console.WriteLine(message);
        int.TryParse(Console.ReadLine(), out n);
        if (n <= 0)
        {
            Console.WriteLine("Ошибка");
        } 
    }while (n <= 0);
    return n;
}
static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int q = b;
        b = a % b;
        a = q;
    }
    return a;
}
static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}