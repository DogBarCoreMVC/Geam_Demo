using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geam_Demo
{
    class Player
    {
        public string PlayerName1 { get; private set; }
        public string PlayerName2 { get; private set; }
        

        public Player(string py1, string py2)//ให้กำหนดผ่าน parameter
        {
            PlayerName1 = py1;
            PlayerName2 = py2;
            
        }
    }
}
