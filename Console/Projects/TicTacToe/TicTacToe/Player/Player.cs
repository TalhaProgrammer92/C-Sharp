using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Player
{
    public class Player
    {
        // Attributes
        public Name? Name { get; set; }
        public Score? Score { get; set; }

        // Constructor
        public Player()
        {
            Name = null;
            Score = null;
        }
        public Player(Name name, Score score)
        {
            Name = name;
            Score = score;
        }

        // Representation method
        public override string ToString()
        {
            return $"Name:\t{Name!.ToString()}\nScore:\t{Score!.ToString()}";
        }
    }
}
