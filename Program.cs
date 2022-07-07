Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("X:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("X:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());



double rasstoyanie(int x1c, int y1c, int x2c, int y2c, int z1c, int z2c)
{
   
    int k1 = x1c - x2c;
    int k2 = y1c - y2c;
    int k3 = z1c - z2c;
    double range = Math.Sqrt(k1 * k1 + k2 * k2 + k3 * k3);
    return Math.Round(range,2);
}

double Range = rasstoyanie(x1,y1,x2,y2,z1,z2);
Console.WriteLine($"{Range} - расстояние между точками");
