using Chess.MenuUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GamePlayer
{
    class Player
    {
        // Attributes
        public Name Name_ { get; }
        public Score Score_ { get; }

        // Constructor
        public Player(string name)
        {
            Name_ = new Name(name);
            Score_ = new Score();
        }

        // Method - Display Player Information
        public void Display()
        {
            Text heading = new Text("Name:\t", ConsoleColor.Yellow);
            Text data = new Text(Name_.Get(), ConsoleColor.Cyan);
            
            heading.Display();
            data.Display(true);
            
            heading.Data = "Score:\t";
            data.Data = Score_.Get().ToString();

            heading.Display();
            data.Display(true);
        }
    }
}
