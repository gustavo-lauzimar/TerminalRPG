using System;

namespace TerminalRPG.World {
    
    public class World {

        private Tile[,] _tiles;

        public World() {

            _tiles = new Tile[12, 8];

            for (int y = 0; y < _tiles.GetLength(1); y++) {

                for (int x = 0; x < _tiles.GetLength(0); x++) _tiles[x, y] = new Tile();
            }
        }

        public void Update() {

            
        }

        public void DrawTiles() {

            for (int y = 0; y < _tiles.GetLength(1); y++) {

                for (int x = 0; x < _tiles.GetLength(0); x++) _tiles[x, y].Draw();

                Console.Write("\n\r");
            }
        }
    }
}
