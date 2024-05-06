

namespace WisCup;
public class Program
{
    
    public static void Main(string[] args)
    {
        string[] TeamNames = new string[] {
                            "Terra Nova", "Star Strategists",
                        "Galactic Engineers", "Xenobiology Alliance",
                        "Quantum Explorers", "Celestial Cartographers", "Astro-Ecologists",
                        "Energy Harvesters", "Time-Space Theorists", "Exo-linguists United" 
        };

        PrintRankings(TeamNames);
        PrintTeamName(TeamNames);

    }
    public static void PrintRankings(string?[] arr)
    {
        WriteLine($"|{"Platzierung"} | {"Name",-30}| ");
            foreach (string? item in arr)
            {
                WriteLine($"|{Array.IndexOf(arr, item)+1,-12}| {item,-30}| ");

            }
            
           
        
        



    }

    public static void PrintTeamName(string[] arr)
    {
        try
        {
            string? teamRank = null;
            do
            {

                WriteLine();
                WriteLine("Gib den Platz ein");
                teamRank = ReadLine();
                int teamPos = Convert.ToInt32(teamRank) - 1;
                WriteLine($"|{"Platzierung"} | {"Name",-30}| ");
                WriteLine($"|{teamPos+1,-12}| {arr[teamPos],-30}| ");
            } while (teamRank is not null);

        }
        catch (IndexOutOfRangeException ex)
        {
            WriteLine($"{ex.Message}");
            WriteLine($"The exception is of type {ex.GetType()}");
        }
        catch (FormatException ex)
        {
            WriteLine($"{ex.Message}");
            WriteLine($"The exception is of type {ex.GetType()}");
        }
        finally { WriteLine("Chao!"); }
    }
}