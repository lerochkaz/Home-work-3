// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int requestNumber()
{
    Console.Write("Ввведите число: ");
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;

}

void cube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 3);
        if (i < number) Console.Write((result) + ", ");
        else Console.Write(result);
    }
}

void printingNumberInCube()
{
    cube(requestNumber());
}

printingNumberInCube();