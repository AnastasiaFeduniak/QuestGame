using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab5
{
    public class NumberKeyHandler : Handler
    {
        public override int HandleRequest(Key key)
        {
            if ((key >= Key.NumPad1 && key <= Key.NumPad9) || (key >= Key.D1 && key <= Key.D9))
            {
                if (key >= Key.D1 && key <= Key.D9)
                {
                    return int.Parse((key - Key.D1).ToString().Substring(1));
                }
                return int.Parse((key - Key.NumPad1).ToString().Substring(6));
            } return -2;
        }
    }
}
