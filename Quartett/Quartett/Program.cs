using System;
using System.Collections.Generic;

namespace Quartett
{

    class Controller
    {
        static void Main(string[] args)
        {
            List<Karte> list = new List<Karte>();
            list.Add(k1);
            list.Add(k2);

            Karte temp = list.Find(i => i.getGewicht() == 2000);
            Console.WriteLine(temp.getName());
            Console.WriteLine("Basti ist doof!");
            //Spiel spiel = new Spiel(2);
        }
    }
