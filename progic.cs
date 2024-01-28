using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Unesite string:");
        string unos = Console.ReadLine();

        string rezultat = "";

        if (unos.Length < 5)
        {
            rezultat = unos;
        }
        else
        {
            rezultat = unos.Substring(2, unos.Length - 4);
        }

        Console.WriteLine("Rezultat: " + rezultat);
    }
}