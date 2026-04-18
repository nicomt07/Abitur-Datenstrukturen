using VerketteteListe;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Siehe Formelsammlung: 4 Datenstrukturen\n\nStart\n= == = == = == = == = == = == = == = == = == =\n");
        Test_Verkette_List();
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
        ;
    }
}