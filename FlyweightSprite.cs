using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class FlyweightSprite
    {
        //   private Dictionary<string, int> sprites = new Dictionary<string, int>();
        private List<string> sprites = new List<string>();
        public string getSprite(string sp, int n)
        {
            string p = null;
            if (sprites.Contains(sp + "_" + n + ".png"))
            {
                p = sp + "_" + n + ".png";
            }
            else
            {
                sprites.Add(sp + "_" + n + ".png");
                p = sp + "_" + n + ".png";
            }
            return p;
        }
    }
}
