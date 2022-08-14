// SЗадача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A по X: ");
int Xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по Y: ");
int Ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по Z: ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по X: ");
int Xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по Y: ");
int Yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по Z: ");
int Zb = Convert.ToInt32(Console.ReadLine());

double N = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));
N = Math.Round(N, 2);
Console.WriteLine($"Расстояние между двумя точками = {N}");
