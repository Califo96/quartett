using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        private int Spieler;

        public void setSpieler(int i)
        {
            Spieler = i;
        }
        
        private void startmenu()
        {
            Console.WriteLine(" _____________________________________________________________________________________________________________________");
            Console.WriteLine("|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hallo! Willkommen beim Quartettspiel!");
        }

        static void Main(string[] args)
        {
            Controller HelpObject = new Controller();
            HelpObject.setSpieler(3);
            Spiel LetsGo = new Spiel(HelpObject.Spieler);
            HelpObject.startmenu();
        }
    }
}
