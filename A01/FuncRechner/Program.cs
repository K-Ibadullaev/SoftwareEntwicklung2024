namespace FuncRechner
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a");
           double a = Convert.ToDouble(ReadLine());

            WriteLine("Enter e");
            double e = Convert.ToDouble(ReadLine());

            WriteLine("Enter s");
            double s = Convert.ToDouble(ReadLine());

            double ListsLen = (int) (e - a)/s;

            List<double> xvals = new List<double>();
            xvals.Add(a);

            List<double?> fvals = new List<double?>();
            WriteLine(ListsLen);
            
            WriteLine("| {0,-5} | {1,-5} |", " X ", " F(X) ");
            for (int i = 0; i <= ListsLen; i++) 
            {
                xvals.Add(xvals[i] + s);

                if ( (xvals[i] == -2.0) | (xvals[i] == 1) )
                {
                    fvals.Add(null);
                    WriteLine("| {0,-5} | {1,-5} |", xvals[i], "NaN");
                }
                else
                {
                   
                    double iexp = (3 * xvals[i] - 6) / ((xvals[i] + 2) * Math.Pow(xvals[i] - 1, 2));
                    fvals.Add(iexp);
                    WriteLine("| {0,-5} | {1,-5} |", xvals[i],fvals[i]);
                    
                }
           

            };



        }
    }
}
