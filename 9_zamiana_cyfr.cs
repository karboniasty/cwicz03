using System.ComponentModel.DataAnnotations;

namespace _9_zamiana_cyfr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nowa_liczba=0, cyfra;
            Console.WriteLine("Podaj liczbę:");
            string slowo = Console.ReadLine();                  
            int ilosc = slowo.Length - 1;
            int liczba=int.Parse(slowo);
            while(ilosc >= 0)
            {
                cyfra = liczba % 10;
                nowa_liczba += cyfra * (int)Math.Pow(10, ilosc);
                ilosc--;
                liczba /= 10;
            }
            Console.WriteLine("Po zamianie kolejności cyfr liczba wynosi: " + nowa_liczba);


        }
    }
}