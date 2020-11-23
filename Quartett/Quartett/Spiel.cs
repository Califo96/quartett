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
            starteSpiel();
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



        private int vergleiche(int vergleichsWert)
        {
            Karte[] vergleichsArray = new Karte[anzahlSpieler];
            int besterWert = 0;
            double besterWertD = 0;
            int indexVonBestemWert = 0;
            int gleicherWertAnzahl = 0;

            for (int i = 0; i < anzahlSpieler - 1; i++)              //Array zum Vergleichen der einzelnen Karten
            {
                vergleichsArray[i] = kartenSchlangen[i].Dequeue();
            }


            for (int i = 0; i < anzahlSpieler - 1; i++)
            {
                switch (vergleichsWert)
                {
                    case 0:                                                        //Fall PS Zahl vergleichen
                        if (vergleichsArray[i].getPs() > besterWert)
                        {
                            besterWert = vergleichsArray[i].getPs();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getPs() == besterWert)
                        {

                            
                            if (gleicherWertAnzahl > 0)
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;

                    case 1:                                                             //Fall Beschleunigung 0-100 vergleichen
                        if (vergleichsArray[i].getBeschleinigung() < besterWertD)
                        {
                            besterWert = vergleichsArray[i].getBeschleunigung();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getBeschleunigung() == besterWertD)
                        {

                            gleicherWertVorhanden = true;
                            if (gleicherWertAnzahl > 0)
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;
                    case 2:                                                         //Fall Max Geschwindigkeit vergleichen
                        if (vergleichsArray[i].getMaxV() > besterWert)
                        {
                            besterWert = vergleichsArray[i].getMaxV();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getMaxV() == besterWert)
                        {

                            gleicherWertVorhanden = true;
                            if (gleicherWertAnzahl > 0)
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;
                    case 3:                                                        //Fall Gewicht vergleichen
                        if (vergleichsArray[i].getGewicht() < besterWert)
                        {
                            besterWert = vergleichsArray[i].getGewicht();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getGewicht() == besterWert)
                        {

                            gleicherWertVorhanden = true;
                            if (gleicherWertAnzahl > 0)
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;
                    case 4:                                                     //Fall Hubraum vergleichen
                        if (vergleichsArray[i].getHubraum() > besterWert)
                        {
                            besterWert = vergleichsArray[i].getHubraum();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getHubraum() == besterWert)
                        {

                            gleicherWertVorhanden = true;
                            if (gleicherWertAnzahl > 0)
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;
                    case 5:                                                     //Fall Zylinderanzahl vergleichen
                        if (vergleichsArray[i].getZylinder() > besterWert)
                        {
                            besterWert = vergleichsArray[i].getZylinder();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getZylinder() == besterWert)
                        {

                            gleicherWertVorhanden = true;
                            if (gleicherWertAnzahl > 0)
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;
                }
            }
            if (gleicherWertAnzahl == anzahlSpieler)                            
            {
                Console.WriteLine("Alle Spieler hatten den selben Wert!");
                Console.WriteLine("Der nächste Wert in der selben Kategorie entscheidet wer die Karten bekommt.");
                for(int i = 0; i < anzahlSpieler-1; i++)
                {
                    tempStapel.Push(vergleichsArray[i]);

                }
            }
            else
            {
                Console.WriteLine("Der Gewinner dieser Runde ist Spieler:" + indexVonBestemWert + 1);
                for(int i = 0; i < anzahlSpieler - 1; i++)
                {
                    kartenSchlangen[indexVonBestemWert].Enqueue(vergleichsArray[i]);
                }
                
            }
        }

            private void printcard()
            {

            }

            private int hatGewonnen()
            {
            int maxIndex;
            for (int i = kartenSchlangen.Length; i > 1; i--)
            {
                if (kartenSchlangen[i].Count == 0)
                {
                    int maxWert = 0;
                    maxIndex = 0;

                    for (int n = kartenSchlangen.Length; n > 1; n--)
                    {
                        if (kartenSchlangen[n].Count > maxWert)
                        {
                            maxWert = kartenSchlangen[n].Count;
                            maxIndex = n;
                        }
                        
                    }
                    return maxIndex;
                }
            }
            return -1;  
            }
        }
    }


