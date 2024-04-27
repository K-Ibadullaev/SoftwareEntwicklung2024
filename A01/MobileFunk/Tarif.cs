
namespace MobileFunk
{

    public class Tarif
    {
        public static double MonGebuer = 3.99;
        public static double KostenProMinute = 0.099;
        public static Dictionary<char, double> InternetPaket = new Dictionary<char, double>() { { 'S', 5 }, { 'M', 7 }, { 'L', 10 } };


        public double MinutenMenge
        {
            get;
            set;
        }


        public char  DatenVolumen
        {
            get;
            set;
        }

        public readonly double MinutenPaket = 100;


        public Tarif() { }


        public double MobileKostenRechnen()
        {
            double TotKost;
            if (MinutenMenge <= MinutenPaket)
            {
                TotKost = MonGebuer;

            }
            else
            {
                TotKost = MonGebuer + KostenProMinute * (MinutenMenge - MinutenPaket);
            }
            return TotKost;

        }


        public double InternetKostenRechnen()
        {

            
                if (InternetPaket.ContainsKey( DatenVolumen))
                {
                    return InternetPaket[DatenVolumen];
                }
                else
                {
                    WriteLine($"Falsche Option");
                    return 0;
                }
            
           

        }




        public double TotalKostenRechnen()
        {



            return MobileKostenRechnen() + InternetKostenRechnen();

        }
    }
}
