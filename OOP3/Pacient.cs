using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Pacient : Osoba
    {
        private double obvodPasu;

        public Pacient(string jmeno, string prijmeni, int hmotnost, double vyska, double obvodPasu) : base(jmeno, prijmeni, hmotnost, vyska)
        {
            this.obvodPasu = obvodPasu;
        }

        public double getObvodPasu() { return obvodPasu; }

        public double ABSI() { return ((obvodPasu) / (Math.Pow(BMI(),(2/3))*(Math.Pow(vyska,0.5)))); }

        public override string ToString()
        {
            double bmi = BMI();
            if (Double.IsNaN(bmi)) { bmi = 0; }
            double absi = ABSI();
            if (Double.IsNaN(absi)) { absi = 0; }
            return String.Format("Jmeno: {0}, Příjmení: {1}, Výška: {2}, Hmotnost: {3}, BMI: {4}, ABSI: {5}", jmeno, prijmeni, vyska, hmotnost, bmi,absi);
        }
    }
}
