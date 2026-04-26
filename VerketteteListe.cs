using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using VerketteteListe;

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
        public Knoten<T> erster;
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
            //TODO
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
        public void anhaengen(T pinhalt)
        {
            if (istLeer())
            {
                einfuegenVorne(pinhalt);
                return;
            }

            var currKnoten = this.erster;
            while (currKnoten.naechster != null)
            {
                currKnoten = currKnoten.naechster;
            }
            currKnoten.naechster = new Knoten<T>(pinhalt);
        }
        public void ausgabe()
        {
            Console.WriteLine("===");
            var currKnoten = this.erster;
            while (currKnoten != null)
            {
                Console.WriteLine(currKnoten.gibInhalt());
                currKnoten = currKnoten.naechster;
            }
            Console.WriteLine("===");
        }
        public void ersetzen(int pindex, T wert)
        {
            
            var aktueller = this.erster;
            int currindex = 0;
            while(currindex < pindex)
            {
                if (aktueller == null || aktueller.naechster == null)
                {
                    Console.WriteLine("Fehler: ersetzen, hat nict geklappt");
                    return;
                }
                
                aktueller = aktueller.naechster;
                currindex++;
            }
            if (aktueller != null)
            {
                aktueller.inhalt = wert;
            }
        }
    }
}

namespace BinaerbaumNS
{
    class BBKnoten<T>
    {
        public T inhalt;
        public BBKnoten<T> linker;
        public BBKnoten<T> rechter;
        public BBKnoten(T pinhalt)
        {
            this.inhalt = pinhalt;
        }
        public bool istBlatt()
        {
            return (rechter == null) && (linker == null);
        }

        public void inorder()
        {
            if (linker != null) { linker.inorder(); }
            Console.WriteLine(inhalt);
            if (rechter != null) { rechter.inorder(); }

        }
        public bool isSorted(List<T> liste = null)
        {
            bool sortiert = true;
            //if (liste.Count <= 1) {  return sortiert; }
            //for (int i = 0; i < liste.Count-1; i++)
            //{
            //    if (!(liste[i] <= liste[i + 1]))
            //    {

            //    }
            //}
            return sortiert;
        }

    }
    class Binaerbaum<T>
    {
        public BBKnoten<T> wurzel;
        public Binaerbaum()
        {
            ;
        }
        public Binaerbaum(T wert)
        {
            wurzel = new BBKnoten<T>(wert);
        }
        public int antahlKnoten()
        {
            var zuZaehlendeKnoten = new Queue<BBKnoten<T>>();
            zuZaehlendeKnoten.Enqueue(wurzel);
            int count = 0;
            BBKnoten<T> cuh;

            while(zuZaehlendeKnoten.Count > 0)
            {
                count++;
                cuh = zuZaehlendeKnoten.Dequeue();

                if(cuh.linker != null)
                {
                    zuZaehlendeKnoten.Enqueue(cuh.linker);
                }
                if (cuh.rechter != null)
                {
                    zuZaehlendeKnoten.Enqueue(cuh.rechter);
                }
            }

            return count;
        }

    }
}