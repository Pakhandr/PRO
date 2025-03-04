using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n; double sum=0,a;
        Console.WriteLine("Enter number of iterations:");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            Console.WriteLine("Введіть будь-ласка коректне число");
        }
        var watch = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < n; i++)
        {
            a = Math.Pow(10, -12) * (cotangent(i - 5)) + 0.8 * Math.Cos(5 * i + 2);
            sum += a;
        }
        watch.Stop();
        var elapsedMs = watch.Elapsed;
        Console.WriteLine($"Sum = {Math.Round(sum,2)}");
        Console.WriteLine($"Time = {elapsedMs}");
    }
    public static double cotangent(int x)
    {
        if (Math.Tan(x) == 0){
            return 0;
        }
        return 1 / Math.Tan(x);
    }
}
