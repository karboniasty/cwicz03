using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        // Przyjmuję, że pierwszy wyraz ciągu to 0
        int n, pop1, pop2, wyraz;

        Console.Write("Podaj ile kolejnych wyrazów ciągu Fibonacciego chcesz wypisać: ");
        n = (int)inputValue();
        if (n != 0)
        {
            pop2 = 0;
            Console.Write(pop2);
            if (n != 1)
            {
                pop1 = 1;
                Console.Write(" " + pop1);
                if (n != 2)
                {
                    while (n > 2)
                    {
                        wyraz = pop1 + pop2;
                        Console.Write(" " + wyraz);
                        pop2 = pop1;
                        pop1 = wyraz;
                        n = n - 1;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Nie chcesz wypisać żadnych wyrazów");
        }
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
