using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Press any key to start processing...");
        Console.ReadKey();
        Console.WriteLine("Processing...");
        Task.Factory.StartNew(ProcessIntData);
        Console.ReadLine();
    }

    static void ProcessIntData()
    {
        int[] source = Enumerable.Range(1, 10_000_000).ToArray();

        int[] modThreeIsZero = (
            from num in source
            where num % 7 == 0
            orderby num descending
            select num
        ).ToArray();
        Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
    }
}