// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.


/*int x1, x2, x4, x5, y;
Console.WriteLine("Введите пятизначное число");
y = Convert.ToInt32(Console.ReadLine());
y = Math.Abs(y);
if (y<100000 && y>9999) {
 x5 = y % 10;
x4 = y / 10 % 10;
x2 = y / 1000 % 10;
x1 = y / 10000 % 10;
if  (x1 == x5 && x2 == x4) {
Console.WriteLine("Вы ввели полиндром"); }
else
Console.WriteLine("Вы ввели не полиндром");}
else
Console.WriteLine("Вы ввели не пятизначное число");
*/


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int x1, x2, y1, y2, z1, z2;
Console.WriteLine("Введите первую координату первой точки");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату первой точки");
z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату второй точки");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки");
y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату второй точки");
z2 = Convert.ToInt32(Console.ReadLine());
double y = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
Console.WriteLine("Расстояние между точками равно " + y);
*/

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


/*int n, i;
Console.WriteLine("Введите число");
n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
for (i = 1; i <= n; i++)
{
    double x = Math.Pow(i, 3);
    Console.Write(x + " ");
}
*/