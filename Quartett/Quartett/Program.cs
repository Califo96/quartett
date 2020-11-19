using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        static void Main(string[] args)
        {

        }
    }

    class Karte
    {
        private int ps;
        private float beschleunigung;
        private int maxV;
        private int gewicht;
        private int hubraum;
        private int zylinder;
        private int index;
        private string name;
        private string herLand;
    }

    class Spiel
    {
        private int anzahlSpieler;
        private List<Karte> kartenStapel = new List<Karte>();
        private Queue<Karte>[] kartenSchlangen ;
        private Stack<Karte> tempStapel = new Stack<Karte>();

        public Spiel()
        {
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
