using System;
using System.Numerics;
using System.Reflection;

namespace Ausdruecke
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, r = 4;
            double y = 4.0;  
            
            
            AritOps(a, b, c, r,y);
            // in 1D
            double x = 22.0;
            double x1 = 10.0;
            double x2 = 50;
            BoolOps(x, x1, x2);


            // in 2D
            x = 22.0;
            y = 12.0;

            x1 = 20.0;
            x2 = 40;

            double y1 = 7.0;
            double y2 = 20;
            BoolOps(x, x1, x2, y, y1, y2);

            // Vergleich
               x1 = 10.0;
               x2 = 10;
               y1 = 7.0;
               y2 = 7;
            KoordsVergleich( x1, x2,  y1, y2);

            // mind. Ein ist im Bereich
            x = 12.0;
            y = 112.0;

            x1 = 14.0;
            x2 = 30;
            y1 = 17.0;
            y2 = 27;
            mindEin(x, x1, x2, y, y1, y2);

            // BitShiftOps
            BitShiftOps( 0b0001_0001, 0b1000_1000, 0b1111);

        }

        public static void AritOps(int a, int b, int c, int r,double y)
        {


            WriteLine("------------------------");

            double d = (double)a / b;
            WriteLine($"d ist {d}");

            double f = (double)(a + b) / (c - y) - (double)a / b;
            WriteLine($"f ist {f}");


            Complex zi = Complex.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            Complex ff = (-b + zi) / (double)(2 * a);
            WriteLine($"Jetzt ist  f {ff}");

            double A = Math.PI * Math.Pow(r, 2);
            WriteLine($"A ist {A}");
        }

        public static bool BoolOps(double x, double x1, double x2) 
        {
            WriteLine("------------------------");
            bool imBereich;
            if ((x > x1) & (x < x2)) 
            {
                imBereich = true;
                WriteLine($"x liegt im Bereich"); 
            }
            else
            {
                imBereich = false;
                WriteLine("x liegt außerhalb des Bereichs");
            }
            return imBereich;


        }

        // Overload für 2D
        public static bool BoolOps(double x, double x1, double x2, double y, double y1, double y2)
        {
            WriteLine("------------------------");
            bool imBereich;
            if (((x > x1) & (x < x2) & (y > y1) & (y < y2)))
            {
               imBereich = true;
                WriteLine("x liegt im Bereich");
            }
            else
            {
                imBereich = false;
                WriteLine("x liegt außerhalb des Bereichs");
            }
            return imBereich;

        }

       
        // Vergleich der Koordinaten von 2 Punkten

        public static bool KoordsVergleich( double x1, double x2,  double y1, double y2)
        {
            WriteLine("------------------------");
            bool Gleich;
            if ((x1 == x2) & ( y1 == y2))
            {
                Gleich = true;
                WriteLine("(x1, y1) und (x2, y2) sind gleich");
            }
            else
            {
                Gleich = false;
                WriteLine("(x1, y1) und (x2, y2) sind unterschiedlich"); 
            }
            return Gleich;

        }
        
        //  Mind. Ein
        public static Tuple<bool, bool> mindEin(double x, double x1, double x2, double y, double y1, double y2)
        {
            bool XimBereich = ((x > x1) & (x < x2)) ? true:false;
            bool YimBereich = ((y > y1) & (y < y2)) ? true : false ;
            WriteLine("------------------------");
            if (XimBereich & YimBereich)
            {
                WriteLine("beide liegen im Bereich");
            }
            else if ((XimBereich==true) &( YimBereich == false))
            {
                WriteLine("Nur x liegt im Bereich");
            }
            else if ((YimBereich == true) & (XimBereich == false))
            {
                WriteLine("Nur y liegt im Bereich");
            }
            else
            {
                WriteLine("beide liegen außerhalb des Bereiches");
            }
            return Tuple.Create(XimBereich, YimBereich);

        }

        public static void BitShiftOps(byte x, byte y, byte z)
        {
            WriteLine("------------------------");
           
            WriteLine("x & y & z, {0}", Convert.ToString(x & y & z, toBase: 16));
            WriteLine("(x | y) & z, {0}", Convert.ToString((x | y) & z, toBase: 16));
            WriteLine("~(x ^ y), {0}", Convert.ToString(~(x ^ y), toBase: 16));
            WriteLine("~(x ^ y) & byte.MaxValue, {0}", Convert.ToString(~(x ^ y) & byte.MaxValue, toBase: 16) );
        }
    }
}
