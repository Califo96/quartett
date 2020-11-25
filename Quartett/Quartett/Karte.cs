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

        public int getPs() //FK001
        {
            return ps;
        }

        public double getBeschleunigung() //FK002
        {
            return beschleunigung;
        }
        public int getMaxV() //FK003
        {
            return maxV;
        }
        public int getGewicht() //FK004
        {
            return gewicht;
        }
        public int getHubraum() //FK005
        {
            return hubraum;
        }
        public int getZylinder() //FK006
        {
            return zylinder;
        }
        public int getIndex() //FK007
        {
            return index;
        }
        public string getName() //FK008
        {
            return Name;
        }
        public string getHerLand() //FK009
        {
            return herLand;
        }

        public Karte(int pps, double pbeschleunigung, int pmaxV, int pgewicht, int phubraum, int pzylinder, string pname, string pherLand)
        {
            ps = pps; //D001
            beschleunigung = pbeschleunigung; //D002
            maxV = pmaxV; //D003
            gewicht = pgewicht; //D004
            hubraum = phubraum; //D005
            zylinder = pzylinder; //006
            Name = pname; //D007
            herLand = pherLand; //D008
        } 
    }
}
