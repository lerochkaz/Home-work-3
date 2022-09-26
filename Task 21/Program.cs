// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координаты точки A через запятую (X, Y, Z): ");
string[] dataPointA = ((Console.ReadLine() ?? "0").Split(","));
int[] arrayForA = new int[dataPointA.Length];

for (int i = 0; i < arrayForA.Length; i++) arrayForA[i] = Convert.ToInt32(dataPointA[i]);


Console.Write("Введите координаты точки B через запятую (X, Y, Z): ");
string[] dataPointB = ((Console.ReadLine() ?? "0").Split(","));
int[] arrayForB = new int[dataPointB.Length];

for (int i = 0; i < arrayForB.Length; i++) arrayForB[i] = Convert.ToInt32(dataPointB[i]);


double result = Math.Round(Math.Sqrt((Math.Pow(arrayForA[0] - arrayForB[0], 2)) + (Math.Pow(arrayForA[1] - arrayForB[1], 2)) + (Math.Pow(arrayForA[2] - arrayForB[2], 2))), 2);
Console.WriteLine(result);


