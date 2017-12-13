using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> liczby = new Stack<int>();
            liczby.Push(87677);
            liczby.Push(-2);
            liczby.Push(14);
            Console.WriteLine(liczby.Contains(143));
            //byte z = 5;
            //liczby.Push(z);
            
            Stack<Osoba> osoby = new Stack<Osoba>();
            osoby.Push(new Osoba("Jan"));
            osoby.Push(new Osoba("Anna"));
            osoby.Push(new Osoba("Zofia"));
            osoby.Push(new Student("Krzysztof"));
            //foreach (var element in osoby)
            //{
            //    Console.WriteLine(element);
            //}
            Console.WriteLine(osoby.Contains(new Osoba("Jan")));
            
        }
    }

    class Osoba 
    {
        string imie;

        public Osoba(string imie)
        {
            this.imie = imie;
        }

        public override string ToString()
        {
            return imie;
        }

    }

    class Student:Osoba
    {
        

        public Student(string imie)
            :base(imie)
        {
            
        }

    }
}
