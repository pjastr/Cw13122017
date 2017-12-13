using System;
namespace ConsoleApplication53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby; //deklaracje
            liczby = new int[6]; //inicjacja

            int[] liczby2 = new int[4];

            int[] liczby3 = { 4, 2, 3, 5 };
            Console.WriteLine("Pierwszy: {0}", liczby3[0]);
            Console.WriteLine("Ostatni: {0}", liczby3[liczby3.Length-1]);
            Array.Sort(liczby3);
            //Array.Resize<int>(ref liczby3, 6);
            //int[] liczby4 = liczby3;
            //liczby3[1] = 6;

            Osoba[] osoby = new Osoba[3];

            Osoba[] osoby2 = { new Osoba("jan"), new Osoba("Anna"), new Osoba("Zofia")};
            Array.Resize(ref osoby2,1);
        }
    }

    class Osoba:IComparable<Osoba>
    {
        string imie;

        public Osoba(string imie)
        {
            this.imie = imie;
        }

        public int CompareTo(Osoba other)
        {
            return other.imie.CompareTo(this.imie);
        }
    }
}

