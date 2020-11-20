using System;
using System.Collections.Generic;
using System.Text;

namespace Quartett
{
    class Liste
    {
        private Knoten first;
        private int laenge;
        private Knoten current;
        private int index;

        private void add(Karte pKarte)
        {
            if (first != null)
            {
                while (current.getNext() != null)
                {
                    next();
                }

                current.addNext(new Knoten(pKarte));
            } 
            else
            {
                first = new Knoten(pKarte);
            }

            laenge++;
        }

        private void remove()
        {
            
            if (laenge < 2)
            {
                if(current != first)
                {
                    Knoten temp = first;
                    while (temp.getNext() != current)
                    {
                        temp = temp.getNext();
                    }

                    temp.addNext(current.getNext());
                }
                else
                {
                    first = current.getNext();
                }

                laenge--;
            } 
            else
            {
                first = null;

                laenge = 0;
            }

            index = 0;
            
        }

        private int getIndex()
        {
            return index;
        }

        private void toFirst()
        {
            current = first;
            index = 0;
        }

        private void next()
        {
            current = current.getNext();
            index++;
        }

        public int getLaenge()
        {
            return laenge;
        }

        public Karte getCurrent()
        {
            return current.getKarte();
        }


    }
}
