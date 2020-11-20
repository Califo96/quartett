using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        static void Main(string[] args)
        {
            
            Karte k1 = new Karte(300, 4.9, 230, 2000, 3000, 6, "BMW 3er", "GER" );
            Karte k2 = new Karte(100, 10.5, 180, 1800, 1000, 3, "Mini Clubman", "GBR");
            List<Karte> list = new List<Karte>();
            list.Add(k1);
            list.Add(k2);

            Karte temp = list.Find(i => i.getGewicht() == 2000);
            Console.WriteLine(temp.getName());
            Console.WriteLine("Basti ist doof!");
            //Spiel spiel = new Spiel(2);
        }
    }
