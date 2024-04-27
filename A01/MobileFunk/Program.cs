namespace MobileFunk
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tarif MyTarif = new Tarif();
           
            try
            { 
                WriteLine("Geben Sie Minutenmenge ein");
                MyTarif.MinutenMenge = Convert.ToDouble(ReadLine());

                WriteLine("Geben Sie Datenvolumen  ein: S,M,L");
                MyTarif.DatenVolumen = Convert.ToChar(ReadLine().ToUpper());
            } 
            catch (IOException ex)
            {
                WriteLine($"Ausnahme sagt {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                WriteLine($"Ausnahme sagt {ex.Message}");
                
            }
            
            catch (FormatException ex)
            {
                WriteLine($"Falsche Eingabe. Ausnahme sagt {ex.Message}");
            }
            catch(Exception ex)
            {
                WriteLine($"Ausnahme sagt {ex.Message}");
            }
            finally
            {
                WriteLine($"Ihre Mobilefunkkosten für {MyTarif.MinutenMenge} Minuten betragen {MyTarif.MobileKostenRechnen()} Euro");

                WriteLine($"Ihre Internetkosten für Paket {MyTarif.DatenVolumen} betragen {MyTarif.InternetKostenRechnen()} Euro");


                WriteLine($"Ihre totale Kosten betragen {MyTarif.TotalKostenRechnen()} Euro");
            }


            

        }
    }
}
