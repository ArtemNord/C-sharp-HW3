// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

void Cube(int number)
{
    int cubeI = 1;
    for(int i = 1; i <= number; i++)
    {
        cubeI = i*i*i;
        Console.WriteLine($"Числа в кубе до {number}: {cubeI}");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);