﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchDogeSoWow
{
    class Program
    {
        public static void Main()
        {
            Game game = new Game();
            game.Init();
            game.Loop();
        }
    }
}
