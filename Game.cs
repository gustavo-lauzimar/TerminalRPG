using System;

namespace TerminalRPG {

    public class Game {

        private World.World _world;
        private bool _continue = true;

        private long _updateTime = 0;
        private const long _COOLDOWN = 50; // 1000 / 20

        public Game() {

            _world = new World.World();
        }

        public void Run() {

            while (_continue) {

                _updateTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

                Console.Clear();
                _world.Update();
                _world.DrawTiles();
                
                _updateTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - _updateTime;
                
                Console.WriteLine(_updateTime);
                Console.WriteLine(_COOLDOWN - _updateTime);

                System.Threading.Thread.Sleep((int)_COOLDOWN - (int)_updateTime);
            }
        }
    }
}
