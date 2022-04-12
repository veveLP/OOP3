using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    /* Vlastnost Jméno pro čtení i zápis
 Vlastnost Příjmení pro čtení i zápis.
 Vlastnost Hmotnost (kg) pro čtení i zápis. Vlastnost naprogramujte tak, aby se při
údaji mimo interval (0;300> vypsalo upozornění „Hmotnost mimo rozsah!“ a
hodnota se neuložila
 Vlastnost Výška (v metrech, např. 1,85) pro čtení i zápis. Vlastnost naprogramujte
tak, aby se hodnota uložila vždy v metrech, i když ji uživatel zadá v cm (poznáte
podle velikosti).
Třída bude mít jediný konstruktor, který nastaví jméno, příjmení, hmotnost a výšku.
Napište metodu BMI, která zjistí BMI dané osoby dle vzorce
Přepište metodu ToString – vrátí text se všemi údaji včetně BMI.
Vytvořte instanci třídy Osoba a vyzkoušejte v programu.
Vytvořte třídu Pacient odvozenou od třídy Osoba.
Třída zdědí všechny atributy, vlastnosti a metody od třídy Osoba a navíc bude obsahovat:
 Vlastnost ObvodPasu (v metrech, např. 0,68) pro čtení i zápis
 Metodu ABSI, která vypočítá ABSI (A Body Shape Index – index tvaru těla)
podle vzorce (Vychází reálné číslo okolo 0,060 – 0,090).
Konstruktor nastaví stejné údaje jako předek a navíc nastaví ObvodPasu. Využijte
konstruktor předka.
Přepište metodu ToString – vrátí text se všemi údaji včetně ABSI. Využijte metodu
předka.
Vytvořte instanci třídy Pacient a vyzkoušejte v programu.*/
    class Osoba
    {
        protected String jmeno { get; set; }
        protected String prijmeni { get; set; }
        protected int hmotnost;
        protected double vyska;

        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            setVyska(vyska);
        }

        public void setHmotnost(int hmotnost) { if (!(hmotnost > 0 && hmotnost < 300)) { MessageBox.Show("Neplatná hodnota!");return; } this.hmotnost = hmotnost; }
        
        public int getHmotnost() { return this.hmotnost; }

        public void setVyska(double vyska) { if (vyska > 5) { vyska /= 100; } this.vyska = vyska; }

        public double getVyska() { return this.vyska; }

        public double BMI() { return ((hmotnost) / (vyska * vyska)); }

        public override string ToString()
        {
            double bmi = BMI();
            if(Double.IsNaN(bmi)) { bmi = 0; }
            return String.Format("Jmeno: {0}, Příjmení: {1}, Výška: {2}, Hmotnost: {3}, BMI: {4}", jmeno, prijmeni, vyska, hmotnost, bmi);
        }


    }
}
