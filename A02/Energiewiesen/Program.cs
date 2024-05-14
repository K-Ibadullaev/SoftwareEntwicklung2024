namespace Energiewiesen;

public class Program
{
    static void Main(string[] args)
    {
        

        EnergieWesen energieWesen_null = new EnergieWesen();
        energieWesen_null.PrintProps();

        
        EnergieWesen energieWesen_four = new EnergieWesen( "blabla", 1234,(Kategorie) 1, 34.5);
        energieWesen_four.PrintProps();

    
        Console.WriteLine("Gib Bezeichnung ein ");
        energieWesen_null.Bezeichnung = Console.ReadLine();
        Console.WriteLine("Gib Nummer ein ");
        energieWesen_null.Registriernummer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Gib Kategorie ein ");
        Kategorie kat = (Kategorie) Enum.Parse(typeof(Kategorie), Console.ReadLine());
        energieWesen_null.kategorie = kat;
        Console.WriteLine("Gib Leistung ein ");
        energieWesen_null.Leistung = Convert.ToDouble(Console.ReadLine());
        energieWesen_null.PrintProps();

    }
}
