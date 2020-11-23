using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        private int Spieler;

        private void go()
        {
            Console.WriteLine("\nBevor ihr los legen könnt, sagt uns schnell wie viele Spieler ihr seid!");
            Console.Write("\nAnzahl Spieler ( 2 - 6 ): ");

            int m = int.Parse(Console.ReadKey().KeyChar.ToString());

            if (m > 6 || m < 2)
            {
                Console.Clear();
                Console.WriteLine("\nDie Anzahl der angegebenen Spieler liegt außerhalb der erlaubten Spielerzahl oder die Eingabe war nicht numerisch!");
            }

            Spieler = m;
        }

        private void regeln()
        {
            Console.WriteLine("\n1. Die 32 Karten werden auf die 2 bis 6 Spieler verteilt. Überschüssige Karten werden beiseitegelegt.");
            Console.WriteLine("\n2. Jeder Spieler nimmt seine Karten als Stapel zu sich gewandt auf.");
            Console.WriteLine("\n3. Der Spieler, welcher an der Reihe ist, wählt ein Attribut seines Autos aus, welches er zu vergleichen wünscht.");
            Console.WriteLine("\n4. Der Spieler, dessen Wert am besten ist, gewinnt alle Karten und darf sie hinter seinen Stapel stecken.");
            Console.WriteLine("\n5. Sollten alle Werte gleich sein, so findet ein Stechen statt und die Karten der vorherigen Runde verweilen in der Mitte.");
            Console.WriteLine("\n6. Das Stechen geschieht mit der nächsten Karte im Stapel jedes Spielers, wobei das zu vergleichende Attribut unverändert bleibt.");
            Console.WriteLine("\n7. Der Spieler, welcher das Stechen gewinnt, bekommt alle Karten, sowohl die aus der aktuellen Runde als auch die Karten aus der Mitte.");
            Console.WriteLine("\n8. Sollte ein Spieler keine Karten in seinem Stapel mehr besitzen, wird ein Sieger gekührt. Dies ist der Spieler, welcher dann die meisten Karten besitzt.");

            Console.WriteLine("\nWillst du zurück? dann drücke Z");

            char b = Console.ReadKey().KeyChar;
            if (b.Equals('z'))
            {
                Console.Clear();
                startmenu();
            }
            else if (b.Equals('s'))
            {
                Console.Clear();
                go();
            }
        }
        private void startmenu()
        {

            Console.WriteLine("\nHallo! Willkommen beim Quartettspiel!");
            Console.WriteLine("\nWillst du starten? Dann drücke S");
            Console.WriteLine("\nWillst du die Regeln nochmal lesen? Dann drücke R");
            char a = Console.ReadKey().KeyChar;
            if (a.Equals('s'))
            {
                Console.Clear();
                go();
            }
            else if (a.Equals('r'))
            {
                Console.Clear();
                regeln();
            }

            //Console.WriteLine(m);
            //Console.Clear();
        }

        static void Main(string[] args)
        {
            Controller HelpObject = new Controller();
            HelpObject.startmenu();
            //Console.WriteLine("Eingegeben: " + HelpObject.Spieler); <-- Nur zum Testen des Spieler-Felds
            Spiel LetsGo = new Spiel(HelpObject.Spieler);

        }
    }
}
