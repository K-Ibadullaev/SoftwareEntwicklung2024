using System.Threading;


namespace MorseApp;


public class Program
{
    private static readonly int PulseShortDelay = 50;
    private static readonly int PulseLongDelay = 500;
    private static readonly int PulseAfterDelay = 200;
    private static readonly int SpaceDelay = 100;
    private static readonly int CharDelay = 300;

    static public void Flash(int Delay)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        Thread.Sleep(Delay);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        Thread.Sleep(PulseAfterDelay);
    }
    static public void MorseFlash(int Delay)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Thread.Sleep(Delay);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Thread.Sleep(PulseAfterDelay);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word/letter");
        string? UserInput = Console.ReadLine();
        string? MorseString="";
        foreach(char s in UserInput)
        {
            string? MorseChar = MorseTable.GetMorseCode(s);
            MorseString += Convert.ToString(MorseTable.GetMorseCode(s) );
            Flash(PulseShortDelay);
            if (Equals(s, " "))
            {
                Flash(SpaceDelay);
            }
            else
            {
                Flash(CharDelay);
            }
            /*
            if (Equals(MorseChar, "-"))
            {
                MorseFlash(PulseLongDelay);
            }
            else
            {
                MorseFlash(PulseShortDelay);
            }
            */

        }
        foreach (char s in MorseString)
        {
            
            
            if (Equals(s, "-"))
            {
                MorseFlash(PulseLongDelay);
            }
            else
            {
                MorseFlash(PulseShortDelay);
            }


        }



        Console.WriteLine(MorseString);
    }
}
