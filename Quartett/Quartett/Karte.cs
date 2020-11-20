using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    public class Karte
    {
        private int ps { get; set; }
        private double beschleunigung { get; set; }
        private int maxV { get; set; }
        private int gewicht { get; set; }
        private int hubraum { get; set; }
        private int zylinder { get; set; }
        private int index { get; set; }
        private string name { get; set; }
        private string herLand { get; set; }

        /*public Karte(int pps, double pbeschleunigung, int pmaxV, int pgewicht, int phubraum, int pzylinder, string pname, string pherLand)
        {
            ps = pps;
            beschleunigung = pbeschleunigung;
            maxV = pmaxV;
            gewicht = pgewicht;
            hubraum = phubraum;
            zylinder = pzylinder;
            name = pname;
            herLand = pherLand;
        } */

        Karte Number1 = new Karte();
        Number1.name = "Lamborghini Avantador";
    }
}
