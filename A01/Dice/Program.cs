namespace Dice;

public class Program
{
    public static void Main(string[] args)
    {
        int Fee = 1;
        int Win = 0;
        int Loss = 0;
        int PtsSum ;
        int wincounter = 0;
        int N = 1000;
       
        for (int i = 0; i < N; i++)
        {
            PtsSum = 0;
            
            Random rnd = new Random();
            for (int j = 0; j < 3; j++) 
            {
                PtsSum += rnd.Next(1,7);

            }
            
            if (PtsSum <= 15)
                {
                Loss += Fee;
               
            }
            else
            {
               ++wincounter;
                switch (PtsSum)
                {
                    
                    case 16:
                        Win += 5;
                       
                        break;
                    case 17:
                        Win += 10 ;
                       
                        break;
                    case 18:
                        Win += 100 ;
                       
                        break;
                    default:
                        WriteLine("Call Security!");
                        break;
                    

                }
            }
            
           

            
        }
        int Balance = Win - Loss;
        WriteLine($"Gewonnene Spiele: {wincounter}");
        WriteLine($"Gewinn: {Win}");
        WriteLine($"Verlust: {Loss}");
        WriteLine($"Bilanz: {Balance}");


    }
}

