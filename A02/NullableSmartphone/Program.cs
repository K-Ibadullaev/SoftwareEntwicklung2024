using NullableSmartphone;

public class Program
{
    public static void Main(string[] args)
    {
        Smartphone MySmartphone = new();
        MySmartphone.IstGesperrt();
        MySmartphone.CallAuth();
        MySmartphone.IstGesperrt();
        MySmartphone.NeuesPIN();
        MySmartphone.IstGesperrt();
        MySmartphone.CallAuth();
        MySmartphone.IstGesperrt();

    }
}

