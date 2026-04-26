using BinaerbaumNS;
using VerketteteListe;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Siehe Formelsammlung: 4 Datenstrukturen\n\nStart\n= == = == = == = == = == = == = == = == = == =\n");
        Test_Binaerbaum();
        //Console.WriteLine("Sachen Hier");
        Console.WriteLine("\n= == = == = == = == = == = == = == = == = == =\nEnde");
    }
    static void Test_Verkette_List()
    {
        var k1 = new Knoten<int>(0);
        var k2 = new Knoten<int>(2);
        var k3 = new Knoten<int>(4);
        var k4 = new Knoten<int>(6);

        k1.naechster = k2; k2.naechster = k3; k3.naechster = k4;

        var vListe = new VerketteteList<int>();
        Console.WriteLine(vListe.istLeer());
        vListe.erster = k1;
        Console.WriteLine(vListe.istLeer());
        vListe.ausgabe();
        vListe.anhaengen(8);
        vListe.ausgabe();
        vListe.ersetzen(5,187);
        vListe.ausgabe();


        Console.WriteLine(k1.gibInhalt());
    }
    static void Test_Stapel()
    {
        ;
    }
    static void Test_Warteschlange()
    {
        ;
    }
    static void Test_Binaerbaum()
    {
        var Baum = new Binaerbaum<int>();
        BBKnoten<int> k11 = new BBKnoten<int>(11);
        BBKnoten<int> k5 = new BBKnoten<int>(5);
        BBKnoten<int> k15 = new BBKnoten<int>(15);
        BBKnoten<int> k2 = new BBKnoten<int>(2);
        BBKnoten<int> k7 = new BBKnoten<int>(7);
        BBKnoten<int> k14 = new BBKnoten<int>(14);
        BBKnoten<int> k20 = new BBKnoten<int>(20);
        BBKnoten<int> k8 = new BBKnoten<int>(8);
        
        // Verbindungen
        k11.linker = k5;
        k11.rechter = k15;

        k5.linker = k2;
        k5.rechter = k7;

        k7.rechter = k8;

        k15.linker = k14;
        k15.rechter = k20;
        Baum.wurzel = k11;
        Baum.wurzel.inorder();
        Console.WriteLine("Batman:\n");
        Console.WriteLine(Baum.antahlKnoten());
    }
}