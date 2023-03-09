using Newtonsoft.Json;
using SkillTestApp;
using System;
using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine($"/***************************************************/");
        Console.WriteLine($"Random Number Program");
        Console.WriteLine();
        Console.WriteLine($"/*** Calling RandomNumberBetweenOneAndHundred() ***/");
        RandomNumberBetweenOneAndHundred();
        Console.WriteLine($"/*** Calling DifferenceBeweenTwoRandomNumbers() ***/");
        DifferenceBeweenTwoRandomNumbers();
        Console.WriteLine($"/*** Calling GenerateAndPrintRandomNumbersList() ***/");
        GenerateAndPrintRandomNumbersList();
        Console.WriteLine($"/*** Calling TenantJsonOperations() ***/");
        TenantJsonOperations();
        Console.WriteLine($"/***************************************************/");
        Console.ReadLine();
    }
 
    static void RandomNumberBetweenOneAndHundred()
    {
        Random rand = new Random();
        Console.WriteLine($"Random Number between 0-100 is : {rand.Next(0, 100)}");
        Console.WriteLine();
    }

    static void DifferenceBeweenTwoRandomNumbers()
    {
        Random rand = new Random();
        int randomNumber1 = rand.Next(0, 300);
        int randomNumber2 = rand.Next(0, 300);
        Console.WriteLine($"Random Number one is : {randomNumber1}");
        Console.WriteLine($"Random Number Two is : {randomNumber2}");
        Console.WriteLine($"Difference Between Random Numbers is : {randomNumber2 - randomNumber1}");
        Console.WriteLine();
    }

    public static void GenerateAndPrintRandomNumbersList()
    {
        Console.WriteLine("List between 0 & 100 of 15 random numbers is");
        Console.WriteLine();

        int count = 15;
        Random random = new Random();
        List<int> values = new List<int>();

        for (int i = 0; i < count; ++i)
            values.Add(random.Next(0, 100));

        foreach (var value in values.OfType<int>().Select((x, i) => new { x, i }))
        {
            Console.WriteLine("Random Number {0} is {1}", value.i + 1, value.x);
        }
        Console.WriteLine();
        Console.WriteLine($"List Average is : {values.Average()}");
        Console.WriteLine();
    }

    static void TenantJsonOperations()
    {
        Console.WriteLine("************ Tenant Operations **************");
        Console.WriteLine();
        Tenants tenants = new();

        Console.WriteLine($"The names of the tenants are :{string.Join(", ", tenants.GetTenantNames())}");
        Console.WriteLine();

        Console.WriteLine($"The Name of Tenant who's Job is writer  :{string.Join(", ", tenants.GetWriterJobTenantNames())}");
        Console.WriteLine();

        Console.WriteLine($"The Pet Names of Tenants  :{string.Join(", ", tenants.GetPets())}");
        Console.WriteLine();
    }
}