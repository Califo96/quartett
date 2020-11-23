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

        public void add(Karte pKarte)
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
                current = first;
            }

            laenge++;
        }

        public void remove()
        {

            if (laenge > 1)
            {
                if (current != first)
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

            toFirst();
        }

        public int getIndex()
        {
            return index;
        }

        public void toFirst()
        {
            if (laenge > 0)
            {
                current = first;
                index = 0;
            }
            else
            {
                current = null;
                index = 0;
            }

        }

        public void next()
        {
            if (current.getNext() != null)
            {
                current = current.getNext();
                index++;
            }
            else
            {
                current = first;
                index = 0;
            }

        }

        public int getLaenge()
        {
            return laenge;
        }

        public Karte getCurrent()
        {
            return current.getKarte();
        }

        public Karte getRandom()
        {
            if (laenge > 0)
            {
                Random r = new Random();
                int i = r.Next(0, laenge - 1);

                toFirst();

                for (int j = 0; j < i; j++)
                {
                    next();
                }

                Karte k = current.getKarte();

                remove();

                return k;
            }
            else
            {
                return null;
            }



        }

    }
}
