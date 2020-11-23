using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        private int Spieler;
        
        private void startmenu()
        {
            
            Console.WriteLine("Hallo! Willkommen beim Quartettspiel!");
            Console.WriteLine("Wenn ihr loslegen wollt, sagt uns schnell wie viele Spieler ihr seid!");
            Console.Write("Anzahl Spieler ( > 2 ): ");
            int m = int.Parse(Console.ReadKey().KeyChar.ToString());
            Spieler = m;
            Console.Clear();
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
