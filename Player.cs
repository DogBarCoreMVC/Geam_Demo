using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geam_Demo
{
    class Player
    {
        public string Name { get; private set; }
        public int HeartScore { get; private set; }

        public Player(string name)
        {
            Name = name;
            HeartScore = 3;
        }
    }
}
