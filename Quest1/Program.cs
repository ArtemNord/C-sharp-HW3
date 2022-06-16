// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 10000) Console.WriteLine("Введите пятизначное число");
else {
    int n0 = number / 10000;
    //Console.WriteLine(n0);
    int n1 = (number % 10000) / 1000;
    //Console.WriteLine(n1);
    int n3 = (number % 100) / 10;
    //Console.WriteLine(n3);
    int n4 = number % 10;
    //Console.WriteLine(n4);
    if (n0 == n4 && n1 == n3) Console.WriteLine($"Число {number} - Полиндром");
    else Console.WriteLine($"Число {number} не является полиндромом");
}