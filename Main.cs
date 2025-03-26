using System;
using System.Collections;

namespace TerminalRPG {
    
    public enum Color {
        Reset,
        Black,
        Red,
        Green,
        Yellow,
        Blue,
        Purple,
        Cyan,
        White,
    }
    
    public static class ColorClass {
        
        public static String getANSIColor(this Color color) {
            
            switch (color) {
                default:
                case Color.Reset:     return "\x1b[0m";
                case Color.Black:     return "\x1b[30m";
                case Color.Red:       return "\x1b[31m";
                case Color.Green:     return "\x1b[32m";
                case Color.Yellow:    return "\x1b[33m";
                case Color.Blue:      return "\x1b[34m";
                case Color.Purple:    return "\x1b[35m";
                case Color.Cyan:      return "\x1b[36m";
                case Color.White:     return "\x1b[37m";
            }
        }
    }
    
    public class Program {
        
        static void Main(string[] args) {

            Game game = new Game();
            game.Run();
        }
    }
}
