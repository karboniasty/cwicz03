namespace _8_jaka_liczba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int propozycja = 10, sprawdzanie=1, od=1, doo=20;
            Console.WriteLine("Wybierz liczbę z przedziału 1-20\nPodaj liczbę: ujemną jeśli propozycja jest mniejsza od wybranej " +
                "dodatnią jeśli jest wyższa lub 0 jeśli jest równa\n");           
            while(sprawdzanie !=0)
            {
                Console.Write("Czy twoja liczba wynosi {0}? ", propozycja);
                sprawdzanie = 0;
                sprawdzanie = int.Parse(Console.ReadLine());
                switch(sprawdzanie)
                {
                    case > 0:
                        doo=propozycja-1;
                        propozycja = (od + doo) / 2;
                        break;
                    case < 0:
                        od=propozycja+1;
                        propozycja=(od+ doo) / 2;
                        break;
                }                
            }
            Console.WriteLine("\nTwoja liczba wynosi: " + propozycja);
        }
                
    }
}