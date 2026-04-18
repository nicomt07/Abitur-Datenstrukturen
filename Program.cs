using VerketteteListe;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Siehe Formelsammlung: 4 Datenstrukturen\n\nStart\n= == = == = == = == = == = == = == = == = == =");
        Test_Verkette_List();
        Console.WriteLine("Sachen Hier hallo");
        Console.WriteLine("\n\n= == = == = == = == = == = == = == = == = == =\nEnde");
    }
    static void Test_Verkette_List()
    {
        var k1 = new Knoten<int>(0);
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