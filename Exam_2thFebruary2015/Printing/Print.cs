using System;

class Print
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        long totalSheets = N * S;
        double reamsCount = totalSheets / 500d;
        double result = reamsCount * P;
        Console.WriteLine("{0:F2}", result);
    }
}
