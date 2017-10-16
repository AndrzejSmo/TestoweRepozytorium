using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    class Osoba
    {
        internal string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;
        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
        public string Przedrostek()
        {
            if(plec == "M")
                return "Pan";
            else
                return "Pani";

        }
        public string Bmi(double a)
        {
            a = waga / (wzrost * wzrost);
            if (a < 18.5)
                return "niedowaga";
            else if (a < 25)
                return "otyłość";
            else
                return "wartość prawidłowa";
        }
    }
    }

