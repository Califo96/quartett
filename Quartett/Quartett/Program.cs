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
            Console.WriteLine("\nblablablabla");
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
