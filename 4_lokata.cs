using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double czas, procent, kwota, kwotapocz, belka, zysk;

        belka = 19;
        Console.Write("Podaj kwotę początkową: ");
        kwotapocz = inputValue();
        kwota = kwotapocz;
        Console.Write("Podaj oprocentowanie (w skali roku): ");
        procent = inputValue();
        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        czas = inputValue();
        for (int i = 1; i <= czas; i++)
        {
            zysk = kwota * ((double)1 / 12 * procent / 100);
            kwota = kwota + zysk;
        }
        zysk = (kwota - kwotapocz) * (1 - belka / 100);
        kwota = kwotapocz + zysk;
        Console.WriteLine("Zarobiona kwota wynosi: " + kwota);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
