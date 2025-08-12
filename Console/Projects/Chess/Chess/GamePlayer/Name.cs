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
        public string Get() { return name; }

        // Check if name is valid
        public static bool IsValid(string name)
        {
            return !(name.Length < 3 || string.IsNullOrEmpty(name));
        }

        // Check if two names are same
        public static bool operator ==(Name name1, Name name2)
        {
            // If both strings have different length
            if (name1.Get().Length !=  name2.Get().Length) return false;

            // Compare each character of both string (not case sensitive)
            for (int i = 0; i < name1.Get().Length; i++)
            {
                if (char.ToLower(name1.Get()[i]) != char.ToLower(name2.Get()[i]))
                    return false;
            }

            return true;
        }

        public static bool operator !=(Name name1, Name name2)
        {
            return !(name1 == name2);
        }
    }
}
