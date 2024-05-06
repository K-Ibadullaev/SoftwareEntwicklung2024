namespace Aschenbroedel;

public class Program
{
    public static void Main(string[] args)
    {
        List<double> WallnutList = new List<double>();
        List<double> HazelnutList = new List<double>();
        double WallnutD = 0;
        double HazelnutD = 0;
        double HazelnutV = 0;
        double WallnutV = 0;

        Random rnd = new Random();
        int N = rnd.Next(42,100);
        double[] NutsDiams = new double[N]; 

        for (int i = 0;i< NutsDiams.Length; i++)
        {
            NutsDiams[i] = rnd.Next(1, 4) - 0.25 + rnd.NextDouble();
            //WriteLine(NutsDiams[i]);
        }


     


        for(int i = 0; i < NutsDiams.Length; i++)
        {
            if (NutsDiams[i] < 2.0)
            {
                HazelnutList.Add(NutsDiams[i]);
                
            }
            else
            {
               WallnutList.Add(NutsDiams[i]);
              
              
            }
           

        }


        WallnutD = WallnutList.Average();
        HazelnutD = HazelnutList.Average();

        HazelnutV = Math.PI * Math.Pow(HazelnutD,3) / 6;
        WallnutV = Math.PI * Math.Pow(WallnutD, 3) / 6;

        WriteLine($"Durchschnittlicher Durchmesser eines Hazelnusses: {HazelnutD}");
        WriteLine($"Durchschnittliche Volumen eines Hazelnusses: {HazelnutV}");

        WriteLine($"Durchschnittlicher Durchmesser eines Wallnusses: {WallnutD}");
        WriteLine($"Durchschnittliche Volumen eines Wallnusses: {WallnutV}");

    }
}