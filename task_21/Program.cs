// Задача 21. Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите первое значение координаты X1: ");
double X1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты X2: ");
double X2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты Y1: ");
double Y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое значение координаты Y2: ");
double Y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты Z1: ");
double Z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение координаты Z2: ");
double Z2=Convert.ToInt32(Console.ReadLine());
double S=Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
Console.WriteLine(S);