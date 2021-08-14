using System;

namespace Geam_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //player 2 คนหัวใจ มีคนล่ะ 3 ดวง
            //gramManager ทำหน้าที่คุมเกม

            Manager manager = new Manager();

            string strOut = null;

            do
            {
                Console.Write("Please enter Name:");
                var inputPlayerName1 = Console.ReadLine();

                Console.Write("Please select, (h)hammer or (s)scissors or (p)paper:");

                var inputPlayerNameAction1 = Console.ReadLine();

                Console.Write("Please enter Name:");
                var inputPlayerName2 = Console.ReadLine();

                Console.Write("Please select, (h)hammer or (s)scissors or (p)paper:");
                var inputPlayerNameAction2 = Console.ReadLine();

                var player = new Player(inputPlayerName1, inputPlayerName2);

                manager.StartPlay(player);

                Console.Write("OutPrgram input yes:");
                strOut = Console.ReadLine();
                Console.WriteLine("\n");

            } while (strOut != "yes");
        }
    }
}
