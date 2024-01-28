using System;

public class Program
 {
        public static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a:");
            double cijenaBezPDVa = Convert.ToDouble(Console.ReadLine());

            double pdv = cijenaBezPDVa * 0.25;
            double cijenaSaPDVom = cijenaBezPDVa + pdv;

            Console.WriteLine("Cijena sa PDV-om: " + cijenaSaPDVom);
        }
 }