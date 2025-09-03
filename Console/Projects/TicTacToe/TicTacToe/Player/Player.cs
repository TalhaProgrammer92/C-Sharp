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
        public string Symbol { get; }

        // Constructor
        public Player()
        {
            Name = null;
            Score = null;
            Symbol = string.Empty;
        }
        public Player(Name name, Score score, string symbol)
        {
            Name = name;
            Score = score;
            Symbol = symbol;
        }

        // Representation method
        public override string ToString()
        {
            return $"Name:\t{Name!.ToString()}\nScore:\t{Score!.ToString()}";
        }
    }
}
