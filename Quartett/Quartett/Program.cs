using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        static void Main(string[] args)
        {
            Karte k1 = new Karte(300, 4.9, 230, 2000, 3000, 6, "BMW 3er", "GER" );
            Karte k2 = new Karte(100, 10.5, 180, 1800, 1000, 3, "Mini Clubman", "GBR");
            List<Karte> list = new List<Karte>();
            list.Add(k1);
            list.Add(k2);

            Karte temp = list.Find(i => i.getGewicht() == 2000);
            Console.WriteLine(temp.getName());
            Console.WriteLine("Basti ist doof!");
            //Spiel spiel = new Spiel(2);
        }
    }

    class Karte
    {
        private int ps;
        private double beschleunigung;
        private int maxV;
        private int gewicht;
        private int hubraum;
        private int zylinder;
        private int index;
        private string name;
        private string herLand;

        public Karte(int pps, double pbeschleunigung, int pmaxV, int pgewicht, int phubraum, int pzylinder, string pname, string pherLand)
        {
            ps = pps;
            beschleunigung = pbeschleunigung;
            maxV = pmaxV;
            gewicht = pgewicht;
            hubraum = phubraum;
            zylinder = pzylinder;
            name = pname;
            herLand = pherLand;
        }

        
    }

    class Spiel
    {
        private int anzahlSpieler;
        private List<Karte> kartenStapel = new List<Karte>();
        private Queue<Karte>[] kartenSchlangen ;
        private Stack<Karte> tempStapel = new Stack<Karte>();

        public Spiel(int anzahl)
        {
            anzahlSpieler = anzahl;
            kartenSchlangen = new Queue<Karte>[anzahlSpieler];
        }

        private void austeilen()
        {

        }

        private void startmenu()
        {

        }

        private int vergleiche()
        {
            return 0;
        }

        private void printcard()
        {

        }

        private int hatGewonnen()
        {
            return 0;
        }


    }
}
