using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int podstawa, wykladnik, wynik;

        Console.WriteLine("Podaj podstawę:");
        podstawa = (int)inputValue();
        Console.WriteLine("Podaj wykładnik:");
        wykladnik = (int)inputValue();
        if (wykladnik == 0)
        {
            wynik = 1;
        }
        else
        {
            wynik = podstawa;
            for (int i = wykladnik; i > 1; i--)
            {
                wynik = wynik * podstawa;
            }
        }
        Console.WriteLine("Wynik wynosi: " + wynik);
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
