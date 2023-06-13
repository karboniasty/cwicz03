namespace _5_funkcja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float wynik = 0;
            Console.Write("Podaj argument funkcji: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj dokładność funkcji: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <=n; i++)
            {
                wynik += (float)Math.Pow(x,i) / silnia(i);
            }
            Console.Write("Wynik funkcji wynosi: " + wynik);
        }
        static int silnia(int liczba)
        {
            int wynik = 1;
            for(int i=1; i <= liczba; i++)
            {
                wynik = wynik * i;
            }
            return wynik;
        }

    }
}