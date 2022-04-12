using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Vytvořte třídu Osoba, která bude obsahovat:
             Vlastnost Jméno pro čtení i zápis
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
Vytvořte instanci třídy Pacient a vyzkoušejte v programu.

Odevzdejte repozitář na GitHubu s možností tvorbu.*/
        }

        Osoba osoba;
        Pacient pacient;
        private void button2_Click(object sender, EventArgs e)
        {
            osoba = new Osoba(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (double)numericUpDown2.Value);
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(osoba.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pacient = new Pacient(textBox3.Text, textBox4.Text, (int)numericUpDown4.Value, (double)numericUpDown3.Value, (double)numericUpDown5.Value);
            button4.Enabled = true;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pacient.ToString());
            
        }
    }
}
