// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void checkingNumber()
{
    Console.Write("Введите пятизначное число: ");
    int data = int.Parse(Console.ReadLine() ?? "0");

    if (data > 9999 && data < 100000)
    {
        if (data / 10000 == data % 10 && data / 1000 % 10 == data / 10 % 10)
        {
            Console.Write("Число палиндром");
        }
        else
        {
            Console.Write("Число не палиндром");
        }
    }
    else
    {
        Console.Write("Ошибка. Введите другое число");
    }
}

checkingNumber();
