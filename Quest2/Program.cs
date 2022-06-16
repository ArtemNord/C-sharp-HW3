// Напишите программу, которая принимает на вход координаты для двух точек 
// и находит растояние между ними в 3D пространстве.

void Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
   double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
   Console.WriteLine($"Растояние между точками {distance}");  
}

Console.WriteLine("Введите координаты X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Distance3D(x1, y1, z1, x2, y2, z2);