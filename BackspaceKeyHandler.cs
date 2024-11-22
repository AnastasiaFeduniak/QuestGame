using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab5
{
    public class BackspaceKeyHandler : Handler
    {
        public override int HandleRequest(Key key)
        { 
            if (key == Key.Back)
            {
                return -1;
            }
            return -2;
        }
    }
}
