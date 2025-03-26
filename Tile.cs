using System;

namespace TerminalRPG.World {

    public class Tile {

        Color color;
        char texture;
        CollisionType collision;
        bool spawner;

        public Tile() {

            color = Color.Green;
            texture = '#';
            spawner = false;
            collision = CollisionType.Empty;
        }

        public void Draw() {

            Console.Write(color.getANSIColor() + texture + Color.Reset.getANSIColor());
        }
    }
        
}
