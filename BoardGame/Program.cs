using System;

namespace BoardGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool continue_exec= true;
            while (continue_exec)
            {
                Console.WriteLine("Enter Input");
                string userinput = Console.ReadLine();
                Board_Game.Play_Board_Game bg = new Board_Game.Play_Board_Game();
                string output=bg.CreateBoard(userinput.ToUpper());
                Console.WriteLine("Press enter to continue n to exit");
                string uinput = Console.ReadLine();
                if (uinput == "n") continue_exec = false;
            }
            
        }
    }
}
