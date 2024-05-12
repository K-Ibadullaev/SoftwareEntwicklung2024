
namespace StructsAufgabe;



    public struct MyStruct
    {
    private double Height;
    private double Width;





    public MyStruct(double height, double width) 
    {
        if (Equals(height.GetType(), Height.GetType()) | Equals(width.GetType(), Width.GetType()))
        {
            if (height > 0 & width > 0)
            {
                Height = height;
                Width = width;
            }
            else
            {
                WriteLine("Parameter sind negativ. Geben Sie nur die positive Werte ein");
                throw new ArgumentException();

            }


        }
        else
        {
            WriteLine("Parameter sind nicht von Typ double. Geben Sie nur die positive Werte vom Typ double ein");
            throw new NotSupportedException();
        }


        
    
    }
    public double GetHeight()
    {
        return  this.Height;
    }
    public double GetWidth()
    {
        return this.Width;
    }

    public void SetHeight(double height)
    {
        if (Equals(height.GetType(), Height.GetType()))
        {
            if (height > 0)
            {
                Height = height;
               
            }
            else
            {
                WriteLine("Parameter sind negativ. Geben Sie nur die positive Werte ein");
                throw new ArgumentException();

            }


        }
        else
        {
            WriteLine("Parameter sind nicht von Typ double. Geben Sie nur die positive Werte vom Typ double ein");
            throw new NotSupportedException();
        }
    }
    public void SetWidth(double width)
    {
        if ( Equals(width.GetType(), Width.GetType()) )
        {
            if ( width > 0)
            {
                
                Width = width;
            }
            else
            {
                WriteLine("Parameter sind negativ. Geben Sie nur die positive Werte ein");
                throw new ArgumentException();

            }


        }
        else
        {
            WriteLine("Parameter sind nicht von Typ double. Geben Sie nur die positive Werte vom Typ double ein");
            throw new NotSupportedException();
        }
    }


    public void ShowHeight()
    {
        WriteLine($"Height ist {this.Height}");
    }
    public void ShowWidth()
    {
        WriteLine($"Width ist {this.Width}");
    }
    

}
