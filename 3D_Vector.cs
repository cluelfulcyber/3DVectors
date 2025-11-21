using System;
namespace NaiKusataDulzhina;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double minLength = double.MaxValue;

        for (int i = 0; i < N; i++)
        {
            string[] parts = Console.ReadLine().Split();
            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);
            double z = double.Parse(parts[2]);

            double length = Math.Sqrt(x * x + y * y + z * z);

            if (length < minLength)
                minLength = length;
        }

        Console.WriteLine($"nai-kusata dulzhina e: {minLength}");
    }

}
