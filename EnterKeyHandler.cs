using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab5
{
    public class EnterKeyHandler : Handler
    {
        public override int HandleRequest(Key key)
        {
            if (key == Key.Enter)
            {
                return 0;
                // Handle Enter key
                // Proceed to the next part of the story
            }
            else return -2;
        }
    }
}
