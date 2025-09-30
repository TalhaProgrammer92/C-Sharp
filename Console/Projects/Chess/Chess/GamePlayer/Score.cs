using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GamePlayer
{
    class Score
    {
        // Attribute
        int score;

        // Constructor
        public Score()
        {
            score = 0;
        }

        // Get - Current Score
        public int Get()
        {
            return score;
        }

        // Method - Increase Score
        public void Increase(int points)
        {
            if (points > 0)
                score += points;
        }

        // Method - Reset Score
        public void Reset()
        {
            score = 0;
        }
    }
}
