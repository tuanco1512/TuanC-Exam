
using GeometryExample;

public class Program
{
    public static void Main(string[] args)
    {
        Cylinder c = new Cylinder();
        Console.WriteLine("Enter the dimenstions of the cylinder");
        Console.Write("Radius: ");
        c.Radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height: ");
        c.Height = Convert.ToDouble(Console.ReadLine());

        c.Process();
        c.Result();
    }
}
