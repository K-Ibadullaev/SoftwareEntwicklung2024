using System;

namespace FuncRechner
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a");
            decimal a = Convert.ToDecimal(ReadLine());

            WriteLine("Enter e");
            decimal e = Convert.ToDecimal(ReadLine());

            WriteLine("Enter s");
            decimal s = Convert.ToDecimal(ReadLine());

            int ListsLen = (int) Math.Round( (e - a)/s, 0, MidpointRounding.AwayFromZero);

            List<decimal> xvals = new List<decimal>() { a,};
            //xvals.Add(a);

            List<decimal?> fvals = new List<decimal?>();
            //WriteLine(ListsLen);
            
            WriteLine("| {0,10} | {1,10} |", " X ", "F(X) ");
            WriteLine("---------------------------");
            for (int i = 0; i <= ListsLen; i++) 
            {

                /*
                                if ( (xvals[i] != -2M) || (xvals[i] != 1M) )
                                {
                                    decimal iexp = (3 * xvals[i] - 6) / ((xvals[i] + 2) * (xvals[i] - 1) * (xvals[i] - 1));
                                    fvals.Add(iexp);
                                    WriteLine("| {0,10:F3} | {1,10:F3} |", xvals[i], fvals[i]);

                    
                                }
                                else
                                {
                                    fvals.Add(null);
                                    WriteLine("| {0,10:F3} | {1,10:F3} |", xvals[i], fvals[i]);

                }
                                xvals.Add(xvals[i] + s);

                */

               
                try
                {
                    decimal iexp = (3 * xvals[i] - 6) / ((xvals[i] + 2) * (xvals[i] - 1) * (xvals[i] - 1));
                    fvals.Add(iexp);
                    WriteLine("| {0,10:F3} | {1,10:F3} |", xvals[i], fvals[i]);
                }
                catch (Exception ex) 
                {
                    fvals.Add(null);
                    WriteLine("| {0,10:F3} | {1,10:F3} |", xvals[i], "NaN");

                }
                finally { xvals.Add(xvals[i] + s); }
               

            };



        }
    }
}
