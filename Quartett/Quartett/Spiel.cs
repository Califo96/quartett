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

        private void erstelleKarten()
        {
            Karte k1 = new Karte(300, 4.9, 230, 2000, 3000, 6, "BMW 3er", "GER");
            Karte k2 = new Karte(100, 10.5, 180, 1800, 1000, 3, "Mini Clubman", "GBR");
            Karte k3 = new Karte(245, 5.8, 250, 1620, 1984, 4, "Audi A4 TFSI quattro", "GER");
            Karte k4 = new Karte(230, 7.4, 237, 1595, 1998, 4, "Opel Insignia B Grand Sport", "GER");
            Karte k5 = new Karte(350, 4.7, 266, 1560, 2261, 4, "Ford Focus RS", "USA");
            Karte k6 = new Karte(450, 4.6, 250, 1850, 4951, 8, "Ford Mustang V8", "USA");
            Karte k7 = new Karte(200, 8.2, 210, 1328, 1998, 4, "Toyota GT86", "JPN");
            Karte k8 = new Karte(245, 6.6, 250, 1445, 1984, 4, "Skoda Octavia 2.0 TSI", "CZE");
            Karte k9 = new Karte(367, 4.7, 250, 1751, 1969, 4, "Volvo S60 AWD Polestar", "SWE");
            Karte k10 = new Karte(238, 7.4, 245, 1597, 3498, 6, "Renault Laguna Coupe 3.5 V6", "FRA");
            Karte k11 = new Karte(262, 6.0, 250, 1390, 1598, 4, "Peugeot 308 GTi", "FRA");
            Karte k12 = new Karte(200, 6.5, 232, 1283, 1498, 3, "Ford Fiesta ST MK8", "USA");
            Karte k13 = new Karte(275, 5.6, 265, 1360, 2706, 6, "Porsche Cayman", "GER");
            Karte k14 = new Karte(290, 5.6, 250, 1410, 1984, 4, "VW Golf 7 GTI", "GER");
            Karte k15 = new Karte(211, 6.6, 240, 1465, 1991, 4, "Mercedes B-Klasse 250", "GER");
            Karte k16 = new Karte(300, 5.2, 255, 1566, 2457, 4, "Subaru WRX STI", "JPN");
            Karte k17 = new Karte(184, 6.5, 219, 1025, 1998, 4, "Mazda MX5", "JPN");
            Karte k18 = new Karte(562, 3.8, 250, 2108, 0, 0, "Tesla Model S", "USA");
            Karte k19 = new Karte(275, 6.4, 250, 1400, 1998, 4, "Hyundai i30N", "KOR");
            Karte k20 = new Karte(347, 6.1, 240, 1623, 378, 6, "Hyundai Genesis Coupe", "KOR");
            Karte k21 = new Karte(300, 5.7, 250, 1690, 1997, 4, "Jaguar XE", "GBR");
            Karte k22 = new Karte(245, 7.3, 230, 1640, 2500, 6, "Lexus GS", "JPN");
            Karte k23 = new Karte(453, 4.4, 290, 1659, 6162, 8, "Chevrolet Camaro", "USA");
            Karte k24 = new Karte(280, 5.2, 240, 1605, 1995, 4, "Alfa Romeo Giulia", "ITA");
            Karte k25 = new Karte(211, 7.2, 235, 1562, 1991, 4, "Infiniti Q30", "JPN");
            Karte k26 = new Karte(109, 10.5, 180, 1095, 898, 3, "Smart ForFour", "GER");
            Karte k27 = new Karte(208, 6.7, 230, 1250, 1598, 4, "Citroen DS3", "FRA");
            Karte k28 = new Karte(400, 4.1, 250, 1605, 2480, 5, "Audi A3 Sportback", "GER");
            Karte k29 = new Karte(200, 8.9, 235, 1733, 1598, 4, "Opel Cascada", "GER");
            Karte k30 = new Karte(344, 5.2, 250, 1571, 3696, 6, "Nissan 370Z", "JPN");
            Karte k31 = new Karte(246, 4.3, 248, 931, 1798, 4, "Lotus Elise", "GBR");
            Karte k32 = new Karte(465, 3.7, 200, 2118, 0, 0, "Ford Mustang Mach E", "USA");
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
            int besterWert = 0;                                     //Temporärer bester Wert zum Vergleichend der Werte als Integer
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
                        if (vergleichsArray[i].getBeschleunigung() < besterWertD)
                        {
                            Console.WriteLine("Spieler" + i + "gewinnt mit seiner Karte gegen die von Spieler " + indexVonBestemWert);
                            besterWertD = vergleichsArray[i].getBeschleunigung();
                            indexVonBestemWert = i;
                        }
                        else if (vergleichsArray[i].getBeschleunigung() == besterWertD)
                        {
                            Console.WriteLine("Spieler" + i + "und Spieler " + indexVonBestemWert + " haben den selben Wert");
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
                return vergleiche(vergleichsWert);     //Es wird erneut verglichen, mit der selben Vergleichskategorie -> Rekursiv wird der Gewinner zurückgegeben
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
            
        private void starteSpiel()
        {
            int aktSpieler=0;
            int aktAuswahl;
            while (hatGewonnen() == -1)
            {
                Console.WriteLine("Spieler {0} ist an der Reihe:", aktSpieler) ;
                printcard(aktSpieler);
                Console.WriteLine("Bitte geben Sie eine Ganzzahl ein welche Kategorie sie spielen möchten:");
                Console.WriteLine("(0:PS,1:0-100, etc.)");
                do
                {
                    Console.WriteLine("Die Zahl muss zwischen 0 und 5 liegen!");
                    aktAuswahl = (int)Console.ReadKey().KeyChar;
                } while (aktAuswahl > 0 && aktAuswahl < 6);
                aktSpieler=vergleiche(aktAuswahl);

             
            }
        }


        }
    }


