using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi_i_objekti
{
    internal class Neboder
    {

        double visina, brojKatova;



        public void SetVisina(int visina)
        {
            this.visina = visina;
        }
        public void SetBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }



        public double GetVisina()
        {
            return this.visina;
        }
        public double GetBrojKatova()
        {
            return this.brojKatova;
        }



        public Neboder()
        {

        }

        public Neboder(double visina, double brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;

        }

        public override string ToString()
        {
            visina += 10;
            brojKatova += 1;
            double average = visina / brojKatova;
            string ispis = "Visina: " + visina + ""
                    + "\r\nBroj Katova: " + brojKatova
                    + "\nProsjek: " + average;
            return ispis;
        }
    }
}