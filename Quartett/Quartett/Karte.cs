using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    public class Karte
    {
        private int ps;
        private double beschleunigung;
        private int maxV;
        private int gewicht;
        private int hubraum;
        private int zylinder;
        private int index;
        private string Name;
        private string herLand;

        public int getPs()
        {
            return ps;
        }

        public double getBeschleunigung()
        {
            return beschleunigung;
        }
        public int getMaxV()
        {
            return maxV;
        }
        public int getGewicht()
        {
            return gewicht;
        }
        public int getHubraum()
        {
            return hubraum;
        }
        public int getZylinder()
        {
            return zylinder;
        }
        public int getIndex()
        {
            return index;
        }
        public string getName()
        {
            return Name;
        }
        public string getHerLand()
        {
            return herLand;
        }

        public Karte(int pps, double pbeschleunigung, int pmaxV, int pgewicht, int phubraum, int pzylinder, string pname, string pherLand)
        {
            ps = pps;
            beschleunigung = pbeschleunigung;
            maxV = pmaxV;
            gewicht = pgewicht;
            hubraum = phubraum;
            zylinder = pzylinder;
            Name = pname;
            herLand = pherLand;
        } 
    }
}
