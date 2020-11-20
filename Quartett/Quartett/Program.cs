using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        private int Spieler;

        private void go()
        {
            Console.WriteLine("Bevor ihr los legen könnt, sagt uns schnell wie viele Spieler ihr seid!");
            Console.Write("Anzahl Spieler ( 2 - 6 ): ");
            int m = int.Parse(Console.ReadKey().KeyChar.ToString());

            if (m > 6 || m < 2)
            {
                Console.Clear();
                Console.WriteLine("Die Anzahl der angegebenen Spieler liegt außerhalb der erlaubten Spielerzahl oder die Eingabe war nicht numerisch!");
            }
            Spieler = m;
        }

        private void regeln()
        {
            Console.WriteLine("blablablabla");
            Console.WriteLine("Willst du zurück? dann drücke Z");
            char b = Console.ReadKey().KeyChar;
            if (b.Equals('z'))
            {
                startmenu();
            }
            else if (b.Equals('s'))
            {
                go();
            }
        }
        private void startmenu()
        {

            Console.WriteLine("Hallo! Willkommen beim Quartettspiel!");
            Console.WriteLine("Willst du starten? Dann drücke S");
            Console.WriteLine("Willst du die Regeln nochmal lesen? Dann drücke R");
            char a = Console.ReadKey().KeyChar;
            if (a.Equals('s'){
                go();
            }
            else if (a.Equals('r'))
            {
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
