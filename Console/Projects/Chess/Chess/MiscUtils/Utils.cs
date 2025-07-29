using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.MiscUtils
{
    class Utils
    {
        /*  <summary>
             Sets the console output encoding to UTF-8.
             This is useful for displaying Unicode characters correctly in the console.
            </summary> */
        public static void SetUTF8Encoding()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
    }
}
