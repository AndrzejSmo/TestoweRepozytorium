using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2
{
    class car

    {
        public string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public void UstawRokProdukcji(int rok)
        {
            this.rokProdukcji = rok;
        }
        public string Info()
        {
            return marka + " " + rokProdukcji;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }
        public double ObliczKosztSpalania(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
    }
}
