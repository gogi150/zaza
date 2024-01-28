using System;

public class Program
{
    public static void Main()
    {
        int x = 3; // promjenjiva vrijednost stranice
        int y = 4; // promjenjiva vrijednost stranice
        int z = 5; // promjenjiva vrijednost stranice

        if (x > 0 && y > 0 && z > 0)
        {
            if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
            {
                Console.WriteLine("Unesene vrijednosti predstavljaju stranice pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Unesene vrijednosti ne predstavljaju stranice pravokutnog trokuta.");
            }
        }
        else
        {
            Console.WriteLine("Unesene vrijednosti nisu smislene. Stranice moraju imati iznose veće od 0.");
        }
    }
}
