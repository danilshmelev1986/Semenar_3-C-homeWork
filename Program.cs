// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine ("give me a number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 9999 && num <100000)
// {
// int num1 = num/10000;
// int num2 = (num/1000)%10;
// int num3 = (num/100)%10;
// int num4 = (num/10)%10;
// int num5 = num%10;

// if (num1==num5 && num2==num4)
// {
//     Console.WriteLine ("polindrom");
// }
// else
// {
//     Console.WriteLine ("NE polindrom");
// }
// }
// else
// {
//     Console.WriteLine ("неверное число");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine ("give me a X");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("give me a X2");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("give me a Y");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("give me a Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("give me a Z");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("give me a Z2");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double dx = X2 - X1;
// double dy = Y2 - Y1;
// double dz = Z2 - Z1;

// double num = Math.Sqrt(dx * dx + dy * dy + dz * dz);
// Console.WriteLine (num);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("give me a N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<=N; i++)
{
    int cube = i*i*i;
    Console.WriteLine($"{i}^3 = {cube}");
}