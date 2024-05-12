
namespace NullableSmartphone;

public class Smartphone
{
    private int? PIN { get; set; }
  
    private bool Gesperrt { get; set; }
    public Smartphone()
    {
        
        WriteLine($"Geben Sie das PIN ein");
        this.PIN = ToInt32(ReadLine());
        this.Gesperrt = true;
        
    }
    public Smartphone(int? PIN)
    {
        this.PIN = PIN;
        this.Gesperrt = true;
    }

    private bool Authentifizierung()
    {
        int auth_attempts = 0;
        bool CorrectPIN = false;

        while(auth_attempts<3)
        {
            
            int UserPIN = ToInt32(ReadLine());
            if (Equals(UserPIN, PIN))
            {
                auth_attempts = 0;
                CorrectPIN = true;
                this.Gesperrt = false;
                break;
            }
            else {
                
                
                auth_attempts++;
                WriteLine($"Falsches PIN. Sie haben noch {3 - auth_attempts} Versuche");
            }
        }
      
        return CorrectPIN;
    }

    public void IstGesperrt()
    {
        WriteLine($"Das Handy is gesperrt: {Gesperrt}");

    }

    public void NeuesPIN()
    {
        WriteLine("Geben Sie das aktuelle PIN ein ");
        bool auth = Authentifizierung();
        if (auth)
        {
            WriteLine("Geben Sie neues PIN ein");
            int? neuesPin = ToInt32(ReadLine());
            this.PIN = neuesPin;
            WriteLine("Das neue PIN ist festgelegt");
            this.Gesperrt = true;
        }
        else
        {
            WriteLine("Authentifizierung ist nicht erfolgreich. Das aktuelle PIN stimmt nicht überein. ");
            this.PIN = this.PIN;
            this.Gesperrt = true;
        }
        
    }

    public void  CallAuth()
    {
        WriteLine("Geben Sie das PIN ein ");
        bool CorrectPIN = Authentifizierung();
        if (CorrectPIN == true)
            {
                WriteLine("Welcome !");

            }
            else
            {
                WriteLine($"Das Handy is gesperrt: {Gesperrt}");
            }

    }



}
