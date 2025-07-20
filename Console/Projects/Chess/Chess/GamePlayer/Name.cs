using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.GamePlayer
{
    class Name
    {
        // Attributes
        string name;

        // Constructor
        public Name(string name)
        { this.name = name; }

        // Getter
        public string get() { return name; }

        // Check if name is valid
        public static bool isValid(string name)
        {
            return !(name.Length < 3 || string.IsNullOrEmpty(name));
        }

        // Check if two names are same
        public static bool areEqual(string name1, string name2)
        {
            // If both strings have different length
            if (name1.Length !=  name2.Length) return false;

            // Compare each character of both string (not case sensitive)
            for (int i = 0; i < name1.Length; i++)
            {
                if (char.ToLower(name1[i]) != char.ToLower(name2[i]))
                    return false;
            }

            return true;
        }
    }
}
