using System;
using System.Collections.Generic;
using System.Text;

namespace VerketteteListe
{
    class Knoten<T>
    {
        public Knoten<T> naechster;
        public T inhalt;
        
        public Knoten(T pinhalt)
        {
            this.inhalt = pinhalt;
        }
        public void setzeNeachsten(Knoten<T> pKn)
        {
            this.naechster = pKn;
        }
        public Knoten<T> gibNaechsten()
        {
            return this.naechster;
        }
        public void setzeInhalt(T pInhalt)
        {
            this.inhalt = pInhalt;
        }
        public T gibInhalt()
        {
            return this.inhalt;
        }
    }
    class VerketteteList<T>
    {
        Knoten<T> erster;
        public VerketteteList()
        {
            ;
        }
        public bool istLeer()
        {
            return erster == null;
        }
        public void einfuegen(int pindex, T pinhalt)
        {
            int currIndex = 0;
            var newK = new Knoten<T>(pinhalt);
            var currKnoten = this.erster;
            while (currIndex < pindex-1)
            {
                currKnoten = currKnoten.gibNaechsten();
                currIndex++;
            }
        }
        public void einfuegenVorne(T pinhalt)
        {
            var newK = new Knoten<T>(pinhalt);
            if (istLeer())
            {
                this.erster = newK;
            }
            else
            {
                //newK.setzeNeachsten(this.erster); // unschöne, aber laut FS die erwünschte schreibweise
                newK.naechster = this.erster;
                this.erster = newK;
            }
        }
    }
}
