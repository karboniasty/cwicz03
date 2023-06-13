using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n, k;
        double m;

        Console.WriteLine("Podaj n: ");
        n = Silnia(Podajliczbe());
        Console.WriteLine("Podaj k: ");
        k = Silnia(Podajliczbe());
        m = (double)(n - k) / k;
        Console.WriteLine("Wynik wynosi: " + m);
    }

    public static int Podajliczbe()
    {
        int liczba;

        liczba = (int)inputValue();
        while (liczba < 5)
        {
            Console.WriteLine("Podana liczba musi być nie mniejsza od 5" + "Podaj liczbę:");
            liczba = (int)inputValue();
        }

        return liczba;
    }

    public static int Silnia(int liczba)
    {
        int wynik, n;

        wynik = 1;
        n = 1;
        while (n != liczba)
        {
            n = n + 1;
            wynik = wynik * n;
        }

        return wynik;
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
