using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Player
{
    public class Name
    {
        // Attribute
        string name { get; }

        // Constructor
        public Name(string name)
        {
            this.name = name;
        }

        // Method - Check if two names are equal
        public static bool operator==(Name a, Name b)
        {
            return a.name.ToLower().Equals(b.name.ToLower());
        }
        public static bool operator!=(Name a, Name b)
        {
            return !(a == b);
        }

        // Representation method
        public override string ToString()
        {
            return name;
        }
    }
}
