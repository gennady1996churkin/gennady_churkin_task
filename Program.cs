public class RectangleArea
{
    public static void Main()
    
    {
        Console.Write("Длина: ");
        int sideA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ширина: ");
         int sideB = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Высота: ");
        int sideC = Convert.ToInt32(Console.ReadLine());
        int area1= sideA * sideB;
        int area2= sideA * sideB*sideC;

Console.WriteLine("Площадь комнаты: {0}", area1);
        Console.WriteLine("Обьем комнты: {0}", area2);
        Console.ReadLine();
    }
    }