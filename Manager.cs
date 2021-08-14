using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geam_Demo
{
    class Manager//ตัวควบเกม
    {
        public int HeartScore { get; private set; }
        public string PlayerNameAction1 { get; set; }
        public string PlayerNameAction2 { get; set; }

        public Manager()
        {
            HeartScore = 3;
            HeartScore -= 1;
        }

        public void StartPlay(Player player)
        {
            if (PlayerNameAction1 == "h" && PlayerNameAction2 == "h")
            {
                Console.WriteLine("tie");
            }
            else if (PlayerNameAction1 == "h" && PlayerNameAction2 == "p")
            {
                Console.WriteLine("lose" + "\n" + "You can lose two more times " + "\n" + "remaining points " +  HeartScore--);
            }
            else if (PlayerNameAction1 == "h" && PlayerNameAction2 == "s")
            {
                Console.WriteLine("win");
            }
            else if (PlayerNameAction1 == "p" && PlayerNameAction2 == "p")
            {
                Console.WriteLine("tie");
            }
            else if (PlayerNameAction1 == "p" && PlayerNameAction2 == "h")
            {
                Console.WriteLine("wit");
            }
            else if (PlayerNameAction1 == "p" && PlayerNameAction2 == "s")
            {
                Console.WriteLine("lose" + "\n" + "You can lose two more times " + "\n" + "remaining points " + HeartScore--);
            }
            else if (PlayerNameAction1 == "s" && PlayerNameAction2 == "s")
            {
                Console.WriteLine("tie");
            }
            else if (PlayerNameAction1 == "s" & PlayerNameAction2 == "p")
            {
                Console.WriteLine("win");
            }
            else if (PlayerNameAction1 == "s" && PlayerNameAction2 == "h")
            {
                Console.WriteLine("lose" + "\n" + "You can lose two more times " + "\n" + "remaining points " + HeartScore--);
            }
            else
            {
                Console.WriteLine("Please select, (h)hammer or (s)scissors or (p)paper!!!");
            }
        }
    }
}