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
                for (int j = 0; i < anzahlSpieler; i++)
                {
                    kartenSchlangen[i].Enqueue(kartenStapel.getRandom());
                }
            }

        }



        private int vergleiche()
        {

            int besterWert = 0;
            double besterWertD = 0;
            int indexVonBestemWert = 0;
            char vergleichsoperator;
            String vergleich;
            bool gleicherWertVorhanden = false;


            for (int i = 0; i < anzahlSpieler - 1; i++)
            {
                switch (vergleichsWert)
                {
                    case 0:                                                        //Fall PS Zahl vergleichen
                        if (kartenSchlangen[i].Dequeue.getPs() > besterWert)
                        {
                            besterWert = kartenSchlangen[i].Dequeue.getPs();
                            indexVonBestemWert = i;
                        }
                        else if (kartenSchlangen[i].Dequeue.getPs() == besterWert)
                        {
                            gleicherWertVorhanden = true;
                            tempStapel.Push(kartenSchlangen[i].Dequeue);
                            tempStapel.Push(kartenSchlangen[besterWert].Dequeue);
                        }
                        break;

                    case 1:
                        if (kartenSchlangen[i].Dequeue.getBeschleunigung() < besterWertD)
                        {
                            besterWertD = kartenSchlangen[i].Dequeue.getBeschleunigung();
                            indexVonBestemWert = i;
                        }
                        else if (kartenSchlangen[i].Dequeue.getBeschleunigung() == besterWertD)
                        {
                            gleicherWertVorhanden = true;
                            tempStapel.Push(kartenSchlangen[i].Dequeue);
                            tempStapel.Push(kartenSchlangen[besterWert].Dequeue);
                        }
                        break;
                    case 2:
                        if (kartenSchlangen[i].Dequeue.getMaxV() > besterWert)
                        {
                            besterWert = kartenSchlangen[i].Dequeue.getMaxV();
                            indexVonBestemWert = i;
                        }
                        else if (kartenSchlangen[i].Dequeue.getMaxV() == besterWert)
                        {
                            gleicherWertVorhanden = true;
                            tempStapel.Push(kartenSchlangen[i].Dequeue);
                            tempStapel.Push(kartenSchlangen[besterWert].Dequeue);
                        }
                        break;
                    case 3:
                        if (kartenSchlangen[i].Dequeue.getGewicht() < besterWert)
                        {
                            besterWert = kartenSchlangen[i].Dequeue.getGewicht();
                            indexVonBestemWert = i;
                        }
                        else if (kartenSchlangen[i].Dequeue.getGewicht() == besterWert)
                        {
                            gleicherWertVorhanden = true;
                            tempStapel.Push(kartenSchlangen[i].Dequeue);
                            tempStapel.Push(kartenSchlangen[besterWert].Dequeue);
                        }
                        break;
                    case 4:
                        if (kartenSchlangen[i].Dequeue.getHubraum() > besterWert)
                        {
                            besterWert = kartenSchlangen[i].Dequeue.Hubraum();
                            indexVonBestemWert = i;
                        }
                        else if (kartenSchlangen[i].Dequeue.getHubraum() == besterWert)
                        {
                            gleicherWertVorhanden = true;
                            tempStapel.Push(kartenSchlangen[i].Dequeue);
                            tempStapel.Push(kartenSchlangen[besterWert].Dequeue);
                        }
                        break;
                    case 5:
                        if (kartenSchlangen[i].Dequeue.getZylinder() > besterWert)
                        {
                            besterWert = kartenSchlangen[i].Dequeue.getZylinder();
                            indexVonBestemWert = i;
                        }
                        else if (kartenSchlangen[i].Dequeue.getZylinder() == besterWert)
                        {
                            gleicherWertVorhanden = true;
                            tempStapel.Push(kartenSchlangen[i].Dequeue);
                            tempStapel.Push(kartenSchlangen[besterWert].Dequeue);
                        }
                        break;
                }
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
}
