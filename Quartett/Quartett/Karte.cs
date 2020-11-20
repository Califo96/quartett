using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    class Karte
    {
        private int ps;
        private double beschleunigung;
        private int maxV;
        private int gewicht;
        private int hubraum;
        private int zylinder;
        private int index;
        private string name;
        private string herLand;

        public Karte(int pps, double pbeschleunigung, int pmaxV, int pgewicht, int phubraum, int pzylinder, string pname, string pherLand)
        {
            ps = pps;
            beschleunigung = pbeschleunigung;
            maxV = pmaxV;
            gewicht = pgewicht;
            hubraum = phubraum;
            zylinder = pzylinder;
            name = pname;
            herLand = pherLand;
        }
    }
}
