using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MiscUtils
{
    class Offset
    {
        // Attribute
        int? offet;

        // Constructor
        public Offset(int? offset = null)
        {
            this.offet = offset;
        }

        // Get offset
        public int GetValue()
        {
            if (offet.HasValue)
                return offet.Value;
            else
                return 0;
        }
    }
}
