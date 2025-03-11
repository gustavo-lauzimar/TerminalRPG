using System;
using System.Collections;

namespace TerminalRPG {
    
    enum Color {
        Black,
        Red,
        Green,
        Yellow,
        Blue,
        Purple,
        Cyan,
        White,
    }
    
    public class Program {
        
        static void Main(string[] args) {

            Game game = new Game();
            game.Run();
        }
    }

    public class Game {
        
        private World.World _world;
        
        public Game() {
            
            _world = new World.World();
        }
        
        public void Run() {
        
            _world.DrawTiles();
        }
    }
    
    namespace World {
        
        enum CollisionType {
            Empty,
            Full,
        }
        
        public class World {
            
            private Tile[,] _tiles;
            
            public World() {
                
                _tiles = new Tile[2, 2];
                
                for (int y = 0; y < _tiles.Length; y++) {
                    
                    for (int x = 0; x < 2; x++) _tiles[x, y] = new Tile();
                }
            }
            
            public void DrawTiles() {
                
                for (int y = 0; y < 2; y++) {
                    
                    for (int x = 0; x < 2; x++) _tiles[x, y].Draw();
                    
                    Console.Write("\n\r");
                }
            }
        }
        
        public class Tile {
            Color color;
            char texture;
            CollisionType collision;
            bool spawner;
            
            public Tile() {
                
                color = Color.Black;
                texture = 'a';
                spawner = false;
                collision = CollisionType.Empty;
            }
            
            public void Draw() {
                
                Console.Write("\x1b[32m" + texture + "\x1b[0m");
            }
        }
        
        namespace Entities {
            
        }
    }
}
