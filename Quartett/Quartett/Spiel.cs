﻿using System;
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

        private void erstelleKarten()
        {
            Karte k1 = new Karte(300, 4.9, 230, 2000, 3000, 6, "BMW 3er", "GER");
            Karte k2 = new Karte(100, 10.5, 180, 1800, 1000, 3, "Mini Clubman", "GBR");
            Karte k3 = new karte(245, 5.8, 250, 1620, 1984, 4, "Audi A4 TFSI quattro", "GER");
            Karte k4 = new Karte(230, 7.4, 237, 1595, 1998, 4, "Opel Insignia B Grand Sport", "GER");
            Karte k5 = new Karte(350, 4.7, 266, 1560, 2261, 4, "Ford Focus RS", "USA");
            Karte k6 = new Karte(450, 4.6, 250. 1850, 4951, 8, "Ford Mustang V8", "USA");
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
            Karte k32 = new Karte(465, 3.7, 200, 2118, 0. 0, "Ford Mustang Mach E", "USA");
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
                return 0;
            }
        }
    }


