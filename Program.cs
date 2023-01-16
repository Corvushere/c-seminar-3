// See https://aka.ms/new-console-template for more information
int x, y;
Console.WriteLine("Введите число трёхзначное");
y = Convert.ToInt32(Console.ReadLine());
y = Math.Abs(y);
if (y>99 && y<1000) {x = y / 10 % 10;
Console.WriteLine("Вторая цифра справа: " + x); }
else {Console.WriteLine("Вы ввели не трёхзначное число");}