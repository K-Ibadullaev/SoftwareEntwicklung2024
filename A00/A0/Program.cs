using System.Globalization;
using System.Reflection;

namespace A0
{
    public class Program
    {
        static void Main(string[] args)
        {
            EnergieWesen energieWesen = new EnergieWesen();

            WriteLine("Geben Sie Bezeichnung ein ");
            energieWesen.Bezeichnung = ReadLine();
            try
            {
                WriteLine("Geben Sie Leuchtcraft ein ");
                energieWesen.Leuchtcraft = Convert.ToDouble(ReadLine(), CultureInfo.InvariantCulture
                    //.Replace('.', ',')
                    );
                WriteLine("Geben Sie Kategorie ein. A, B oder C ");
                energieWesen.Kategorie = Convert.ToChar(ReadLine());
                WriteLine("Geben Sie Registriernummer ein ");
                energieWesen.Registriernummer = Convert.ToInt32(ReadLine());


            }
            catch(FormatException ex)
            {
                WriteLine($"{ex} says {ex.Message}");
               
            }
            catch (OverflowException ex)
            {
                WriteLine($"{ex} says {ex.Message}");

            }
            finally
            {
                WriteLine("-----------------");
                foreach (var prop in energieWesen.GetType().GetProperties())
                {                                                                                   
                    WriteLine("Klasseneigenschaft {0} hat den Wert von {1}", 
                        prop.Name, (prop.GetValue(energieWesen) is null) ? "NONE" : prop.GetValue(energieWesen));
                }
            }






        }
    }
}
