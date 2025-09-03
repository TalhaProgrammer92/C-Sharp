using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Player
{
    public class Score
    {
        // Attributes
        int score;

        // Constructor
        public Score()
        {
            score = 0;
        }
        public Score(int score)
        {
            this.score = score;
        }

        // Getter
        public int Get()
        {
            return score;
        }

        // Method - Increment
        public void Increase(int increment = 1)
        {
            this.score += increment;
        }

        // Method - Reset
        public void Reset()
        {
            this.score = 0;
        }

        // Representation method
        public override string ToString()
        {
            return score.ToString();
        }
    }
}
