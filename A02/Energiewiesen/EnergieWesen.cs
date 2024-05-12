using static Energiewiesen.EnergieWesen;

namespace Energiewiesen;
public enum Kategorie { THERMO = 1, ELEKTRO = 2, NONE = 0 };
public class EnergieWesen
{
    private string? Bezeichnung { get; set; }
    private int? Registriernummer { get; set; }
    private Kategorie kategorie { get; set; }
    private double? Leistung { get; set; }



    /*
     * 
    private string? Bezeichnung;
    private int? Registriernummer;
    private  Kategorie kategorie;
    private double? Leistung;
    */

    public  EnergieWesen() 
    {
           Bezeichnung = null;
           Registriernummer = null;
           kategorie = Kategorie.NONE;
           Leistung = null;
    }
    public EnergieWesen(string? bezeichnung, int? registriernummer, Kategorie kategorieVal, double? leistung)
    {
        Bezeichnung = bezeichnung;
        Registriernummer = registriernummer;
        kategorie = kategorieVal;
        Leistung = leistung;
    }

    /*
    public string? GetBezeichnung()
    {
        return Bezeichnung;
    }

    public int? GetRegistriernummer()
    {
        return  Registriernummer;
    }

    public double? GetLeistung()
    {
        return Leistung;
    }

 
    public Kategorie GetKategorie()
    {
        return kategorie;
    }

    public void SetKategorie(Kategorie value)
    {
        kategorie = value;
    }

    public void  SetBezeichnung(string? bezeichnung)
    {
        Bezeichnung = bezeichnung;
    }

    public void SetRegistriernummer(int? registriernummer)
    {
         Registriernummer = registriernummer;
    }

    public void SetLeistung(double? leistung)
    {
        Leistung = leistung;
    }
    */
    public void PrintProps()
    {
        WriteLine($"{Bezeichnung}");
        WriteLine($"{Registriernummer}");
        WriteLine($"{kategorie}");
        WriteLine($"{Leistung}");
    }





}
