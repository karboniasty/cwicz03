namespace _7_pary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int liczba= int.Parse(Console.ReadLine());
            int a=0, b=liczba;
            if (liczba == 0)
                Console.WriteLine("0 nie jest sumą 2 liczb naturalnych");
            else
            {
                Console.WriteLine("Pary liczb, których suma jest równa podanej liczbie to:");
                do
                {
                    Console.WriteLine(a + " i " + b);
                    a++;
                    b--;
                } while (a <= b);
            }
        }
    }
}