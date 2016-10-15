using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace MuchDogeSoWow
{
    class Game
    {
        private readonly RenderWindow _window;
        private GameState _gameState;

        public Game()
        {
            _window = new RenderWindow(new VideoMode(800, 600), "Doge game?", Styles.Close | Styles.Titlebar);
        }

        /// <summary>
        /// Init method
        /// </summary>
        public void Init()
        {
            _window.Closed += OnClose;
            _window.MouseButtonPressed += OnMouseClick;
            _gameState = new GameState(this);
        }

        /// <summary>
        /// Main loop method
        /// </summary>
        public void Loop()
        {
            Clock timer = new Clock();

            while (_window.IsOpen)
            {

                var p = _window.CPointer;
                _window.DispatchEvents();

                var delta = timer.Restart().AsSeconds();
                _window.Clear();
                UpdateGame(delta);
                _window.Display();
            }
        }

        private void UpdateGame(float delta)
        {
            
        }
        static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        static void OnMouseClick(object sender, MouseButtonEventArgs e)
        {
            // Nothing here yet
        }
    }

    static class VectorExtensions
    {
        public static Vector2i Abs(this Vector2i vec)
        {
            var v = new Vector2i(vec.X, vec.Y) { X = Math.Abs(vec.X), Y = Math.Abs(vec.Y) };
            return v;
        }
    }
}
