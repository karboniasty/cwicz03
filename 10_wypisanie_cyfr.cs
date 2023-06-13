namespace _10_wypisanie_cyfr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba, cyfra, dlugosc;
            do
            {
                Console.Write("Podaj liczbę z minimum 3 cyframi: ");
                string a = Console.ReadLine();
                dlugosc = a.Length - 1;
                liczba = int.Parse(a);
            } while (dlugosc < 2);
                        
            Console.Write("Cyfry podanej liczby to: ");

            while(dlugosc >= 0)
            {
                cyfra = liczba / (int)Math.Pow(10, dlugosc);
                liczba = liczba % (int)Math.Pow(10, dlugosc);
                dlugosc--;
                Console.Write(cyfra + ", ");
            }
        }
    }
}