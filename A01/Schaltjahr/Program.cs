namespace Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Jahr ein");
            string? jahreingabe = null;
            do
            {
                Console.WriteLine("Geben Sie Jahr ein");
                jahreingabe = Console.ReadLine();
                int jahr = Convert.ToInt32(jahreingabe);

                if(jahr % 400 == 0)
                {
                    Console.WriteLine("Schaltjahr");
                }
                else
                {
                    if ((jahr % 100 == 0)
                        )
                    {
                        Console.WriteLine(" kein Schaltjahr");
                    }
                    else if (jahr % 4 == 0)
                    {
                        Console.WriteLine(" Schaltjahr");
                    }
                    else
                    {
                        Console.WriteLine("Kein Schaltjahr");
                    }

                }


            } while (jahreingabe != null);
            

        }
    }
}
