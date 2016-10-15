using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchDogeSoWow
{
    class GameState
    {
        private Game _game;
        public bool IsPlaying = true;

        public GameState(Game game)
        {
            _game = game;
        }
    }
}
