using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    class Spiel
    {
        private int anzahlSpieler;
        private Liste kartenStapel = new Liste();
        private Queue<Karte>[] kartenSchlangen;
        private Stack<Karte> tempStapel = new Stack<Karte>();

        public Spiel(int anzahl)
        {
            anzahlSpieler = anzahl;
            kartenSchlangen = new Queue<Karte>[anzahlSpieler];
        }

        private void austeilen()
        {
            //Console.WriteLine("Ich teile die Karten aus.");

            Random r = new Random();

            int cards = 32;

            double cardspp = 32 / anzahlSpieler;
            cardspp = Math.Floor(cardspp);

            for (int i = (int)cardspp; i < 0; i--)
            {
                for(int j = 0; i < anzahlSpieler; i++)
                {
                    kartenSchlangen[i].Enqueue(kartenStapel.);
                    kartenStapel.
                }
            }

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
