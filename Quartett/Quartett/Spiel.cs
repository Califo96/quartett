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



        private int vergleiche(int vergleichsWert)
        {
            Karte[] vergleichsArray = new Karte[anzahlSpieler];    //Array zum Vergleichen der einzelnen Karten, da aus Queue nur gelesenw werden kann wenn die Karten entfermt werden
            int besterWert ;                                     //Temporärer bester Wert zum Vergleichend der Werte als Integer
            double besterWertD = 0;                              // Temporärer bester Wert zum Vergleichend der Werte als Double
            int indexVonBestemWert = 0;                           //Index an welcher Stelle der beste Wert zu finden ist
            int gleicherWertAnzahl = 0;                            //Anzahl an gleichen Werten 

            for (int i = 0; i < anzahlSpieler - 1; i++)                 //Befüllen des Arrays             
            {
                vergleichsArray[i] = kartenSchlangen[i].Dequeue();      //Karte des jeweiligen PSielers wird an entsprechende Array Stelle gespeichert
            }
            switch (vergleichsWert)                                         //Anfangswert wird auf den entsprechenden Wert der 1. Karte gesetzt
            {
                case 0: besterWert = vergleichsArray[0].getPs();               //PS Zahl der 1. Karte wird als Anfangswert definiert
                    break;
                case 1:
                    besterWertD = vergleichsArray[0].getBeschleunigung();       //0-100 Zeit der 1. Karte wird als Anfangswert definiert
                    break;
                case 2:
                    besterWert = vergleichsArray[0].getMaxV();                  //Maximale Geschwindigkeit der 1. Karte wird als Anfangswert definiert
                    break;
                case 3:
                    besterWert = vergleichsArray[0].getGewicht();         //Gewicht der 1. Karte wird als Anfangswert definiert
                    break;
                case 4:
                    besterWert = vergleichsArray[0].getHubraum();        //Hubraum der 1. Karte wird als Anfangswert definiert
                    break;
                case 5:
                    besterWert = vergleichsArray[0].getZylinder();     //Zylinderanzahl der 1. Karte wird als Anfangswert definiert
                    break;

            }

            
            for (int i = 1; i < anzahlSpieler - 1; i++)             //Schleife die die einzelnen Werte der Spieler vergleicht
            {
                switch (vergleichsWert)                             
                {
                    case 0:                                             //Fall PS Zahl vergleichen
                        printcard(i);                                     //Karte des Spielers mit dem verglichen wird, wird ausgegeben -> Aufruf der Methode printcard                        
                        if (vergleichsArray[i].getPs() > besterWert)       //Wenn PS Zahl>als die des temporären besten Wertes
                        {
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert); //Ausgabe
                            besterWert = vergleichsArray[i].getPs(); // Bester Wert wird neu gesetzt
                            indexVonBestemWert = i;                  //Index vom besten Wert wird auf aktuellen Spieler gesetzt

                        }
                        else if (vergleichsArray[i].getPs() == besterWert)      //Fall 2 Werte sind gleich
                        {

                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert+" haben den selben Wert"); //Ausgabe
                            if (gleicherWertAnzahl > 0) //Wenn die Anzahl an gleichen Werten >0 ist muss die Anzahl um 1 erhöht werden ansonsten um 2
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 1;
                            }
                            else
                            {
                                gleicherWertAnzahl = gleicherWertAnzahl + 2;
                            }
                        }
                        break;

                    case 1:
                        printcard(i);                                                           //Fall Beschleunigung 0-100 vergleichen
                                                                                                //Bedingungen sind identisch mit denen aus case 0!
                        if (vergleichsArray[i].getBeschleinigung() < besterWertD)
                        {
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert);
                            besterWert = vergleichsArray[i].getBeschleunigung();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getBeschleunigung() == besterWertD)
                        {
                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert + " haben den selben Wert");
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
                    case 2:
                        printcard(i);                                                       //Fall Max Geschwindigkeit vergleichen
                                                                                            //Bedingungen sind identisch mit denen aus Fall 0!
                        if (vergleichsArray[i].getMaxV() > besterWert)
                        {
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert);
                            besterWert = vergleichsArray[i].getMaxV();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getMaxV() == besterWert)
                        {
                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert + " haben den selben Wert");
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
                    case 3:
                        printcard(i);                                               //Fall Gewicht vergleichen
                        if (vergleichsArray[i].getGewicht() < besterWert)           //Bedingungen sind identisch mit denen aus Fall 0!
                        {
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert);
                            besterWert = vergleichsArray[i].getGewicht();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getGewicht() == besterWert)
                        {
                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert + " haben den selben Wert");
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
                    case 4:
                        printcard(i);                                                           //Fall Hubraum vergleichen
                        if (vergleichsArray[i].getHubraum() > besterWert)                       //Bedingungen sind identisch mit denen aus Fall 0!
                        {                                                                   
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert);
                            besterWert = vergleichsArray[i].getHubraum();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getHubraum() == besterWert)
                        {
                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert + " haben den selben Wert");
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
                    case 5:
                        printcard(i);                                                   //Fall Zylinderanzahl vergleichen
                        if (vergleichsArray[i].getZylinder() > besterWert)             //Bedingungen sind identisch mit denen aus Fall 0!
                        {
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert);
                            besterWert = vergleichsArray[i].getZylinder();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getZylinder() == besterWert)
                        {
                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert + " haben den selben Wert");
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
            if (gleicherWertAnzahl == anzahlSpieler)      //Wenn die Anzahl der gleichen Karten = der Anzahl an Spielern ist werden die Karten "in die Mitte gelegt" und unter dem
                                                           //Gewinner der nächsten Runde aufgeteilt
                                                           //!!Hier müsste noch nachgebessert werden für den Fall, dass z.B. 2 Karten den selben Wert haben und eine Karte niedriger ist
                                                           //Aus Zeitgründen nicht implementiert!
            {
                Console.WriteLine("Alle Spieler hatten den selben Wert!");
                Console.WriteLine("Der nächste Wert in der selben Kategorie entscheidet wer die Karten bekommt.");
                for(int i = 0; i < anzahlSpieler-1; i++)
                {
                    tempStapel.Push(vergleichsArray[i]); //"Karten werden in die Mitte gelegt" -> auf tempStapel zwischengespreichert

                }
                vergleiche(vergleichsWert);     //Es wird erneut verglichen, mit der selben Vergleichskategorie
            }
            else
            {
                Console.WriteLine("Der Gewinner dieser Runde ist Spieler:" + indexVonBestemWert + 1);
                for(int i = 0; i < anzahlSpieler - 1; i++)
                {
                    kartenSchlangen[indexVonBestemWert].Enqueue(vergleichsArray[i]); //Karten werden dem Gewinner der Runde an seine Kartenschlange angehangen
                }
                return indexVonBestemWert; //Gewinner der Runde wird zurückgegeben
                
            }
        }

            private void printcard(int aktSpieler) {              //Methode, die die oberste Karte des übergebenen Spielers ausgibt
             Karte aktKarte = kartenSchlangen[aktSpieler].Peek(); //Oberste Karte wird gelesen, ohne entfernt zu werden


            Console.WriteLine("Spieler: " + aktSpieler);                              //Ausgabe der Karte 
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("| "+ aktKarte.getName()+                   "| ");
            Console.WriteLine("| "+ aktKarte.getHerLand()+                "| ");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("| PS:" + aktKarte.getPs() +                "| ");
            Console.WriteLine("| 0-100:" + aktKarte.getBeschleunigung() + "| ");
            Console.WriteLine("| Vmax:" + aktKarte.getMaxV() +            "| ");
            Console.WriteLine("| Gewicht:" + aktKarte.getGewicht() +      "| ");
            Console.WriteLine("| Hubraum:" + aktKarte.getHubraum() +      "| ");
            Console.WriteLine("| Zylinderanzahl:"+ aktKarte.getZylinder()+"| ");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
             }

            private int hatGewonnen()
            {
                return 0;
            }
            
        private void starteSpiel()
        {
            int aktSpieler=0;
            int aktAuswahl;
            while (hatGewonnen == -1)
            {
                Console.WriteLine("Spieler aktSpieler ist an der Reihe:");
                printcard(aktSpieler);
                Console.WriteLine("Bitte geben Sie eine Ganzzahl ein welche Kategorie sie spielen möchten:");
                Console.WriteLine("(0:PS,1:0-100, etc.)");
                do
                {
                    Console.WriteLine("Die Zahl muss zwischen 0 und 5 liegen!");
                    aktAusahl = (int)Console.ReadKey().KeyChar;
                } while (aktAuswahl > 0 && aktAuswahl < 6);
                aktSpieler=vergleiche(aktAuswahl);

             
            }
        }

        }
    }


