using System;
namespace SzyfrCezara
{
    public class Cezar
    {
        public string Szyfruj(string tekstJawny, int klucz)
        {
            int przesuniencie = ((klucz % 26) + 26) % 26;

            char[] tablicaZnakow = tekstJawny.ToCharArray();

            for (int i = 0; i < tablicaZnakow.Length; i++)
            {
                char znak = tablicaZnakow[i];

                if (znak == ' ')
                {
                    continue;
                }

                if (znak >= 'a' && znak <= 'z')
                {
                    int pozycja = znak - 'a';
                    int nowaPozycja = (pozycja + przesuniencie) % 26;
                    tablicaZnakow[i] = (char)('a' + nowaPozycja);
                }
            }
            return new string(tablicaZnakow);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst do zaszyfrowania: ");
            string tekst = Console.ReadLine();

            Console.Write("Podaj klucz szyfrowania: ");
            int klucz = int.Parse(Console.ReadLine());

            Cezar algorytm = new Cezar();
            string tekstZaszyfrowany = algorytm.Szyfruj(tekst, klucz);

            Console.WriteLine("Tekst zaszyfrowany: " +  tekstZaszyfrowany);

            Console.ReadKey();
        }
    } s
}

/*
Console.WriteLine() — wypisuje tekst i przechodzi do nowej linii
Console.Write() — wypisuje bez przejścia do nowej linii
Console.ReadLine() — pobiera tekst od użytkownika

int       // liczby całkowites
double    // liczby zmiennoprzecinkowe
decimal   // dokładniejsze wartości, np. pieniądze
char      // pojedynczy znak
string    // tekst
bool      // true / false

int[] liczby = new int[5]; tablica

Random random = new Random();
int liczba = random.Next(1, 11);
random.Next(1, 11)
*/