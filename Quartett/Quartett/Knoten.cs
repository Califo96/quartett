using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    class Knoten
    {
        private Karte karte;
        private Knoten next;

        public Knoten(Karte pKarte)
        {
            karte = pKarte;
        }

        public void addNext(Knoten pKnoten)
        {
            next = pKnoten;
        }

        public Karte getKarte()
        {
            return karte;
        }

        public Knoten getNext()
        {
            if (next != null)
            {
                return next;
            }
            else
            {
                return null;
            }

        }
    }
}

