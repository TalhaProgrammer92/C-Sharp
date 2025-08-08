using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.MenuUtils;

namespace Chess.MenuUtils
{
    class PawnPromotionMenu : Menu
    {
        // Constructor
        public PawnPromotionMenu() : base(
            new Header("Pawn Promotion Menu", 2, 2, 
                new Decorator('+', ConsoleColor.Magenta), 
                ConsoleColor.Blue),

            new List<Text>
            {
                    new Text("Queen", ConsoleColor.Yellow),
                    new Text("Bishop", ConsoleColor.Yellow),
                    new Text("Rook", ConsoleColor.Yellow),
                    new Text("Knight", ConsoleColor.Yellow),
            }
        ) {}
    }
}
