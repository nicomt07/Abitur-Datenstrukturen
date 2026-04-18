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
}
