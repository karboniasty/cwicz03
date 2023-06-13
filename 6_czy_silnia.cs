namespace _6_czy_silnia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=0, silnia=1;
            Console.Write("Podaj liczbę: ");
            int x= int.Parse(Console.ReadLine());
            while(silnia<x)
            {
                n++;
                silnia = silnia * n;
            }
            if (silnia == x)
                Console.WriteLine("Podana liczba jest silnią liczby: " + n);
            else
                Console.WriteLine("Podana liczba nie jest silnią");
        }
    }
}