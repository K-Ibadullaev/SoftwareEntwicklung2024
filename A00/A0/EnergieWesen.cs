using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A0;

public class EnergieWesen
{

    public string? Bezeichnung { get; set; }
   
    public char? Kategorie { get; set; }
    public double? Leuchtcraft { get; set; }
        public int? Registriernummer { get; set; }
    public EnergieWesen(){    }
    public EnergieWesen(string? bezeichnung, 
        char? kategorie,
        double? leuchtcraft, int? registriernummer) 
    {
        Bezeichnung = bezeichnung;
        Kategorie = kategorie;  
        Leuchtcraft = leuchtcraft;
        Registriernummer = registriernummer;

    }



}
