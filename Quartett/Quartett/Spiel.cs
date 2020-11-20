using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    class Spiel
    {
        private int anzahlSpieler;
        private List<Karte> kartenStapel = new List<Karte>();
        private Queue<Karte>[] kartenSchlangen;
        private Stack<Karte> tempStapel = new Stack<Karte>();

        public Spiel(int anzahl)
        {
            anzahlSpieler = anzahl;
            kartenSchlangen = new Queue<Karte>[anzahlSpieler];
        }

        private void austeilen()
        {
            Console.WriteLine("Ich teile die Karten aus.");
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
