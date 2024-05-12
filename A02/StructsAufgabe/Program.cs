using System.Drawing;

namespace StructsAufgabe
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(3.0,4.0);
            myStruct.ShowWidth();
            myStruct.ShowHeight();

           // myStruct.GetWidth();
           // myStruct.GetHeight();
            
            WriteLine("Geben Sie Height ein");
            double height = ToDouble(ReadLine());
            myStruct.SetHeight(height);


            WriteLine("Geben Sie Width ein");
            double width = ToDouble(ReadLine());
            myStruct.SetWidth(width);

            myStruct.ShowWidth();
            myStruct.ShowHeight();

        }
    }
}
