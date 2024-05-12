namespace Energiewiesen;

public class Program
{
    static void Main(string[] args)
    {
        

        EnergieWesen energieWesen_null = new EnergieWesen();
        energieWesen_null.PrintProps();

        
        EnergieWesen energieWesen_four = new EnergieWesen( "blabla", 1234,(Kategorie) 1, 34.5);
        energieWesen_four.PrintProps();

    }
}
