using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Nowak";
            dyrektor.rokUrodzenia = 1976;
            dyrektor.waga = 70;
            dyrektor.plec = "M";
            Osoba pacjent = new Osoba();
            pacjent.imie = "krzysztof";
            pacjent.nazwisko = "nowak";
            pacjent.wzrost = 180;
            pacjent.waga = 90;


            Console.WriteLine(dyrektor.Przedrostek() + " " +dyrektor.imie + " " + dyrektor.nazwisko + " " + dyrektor.ObliczWiek());
            Console.WriteLine(pacjent.Bmi());
            Console.ReadKey();
        }
    }
}
