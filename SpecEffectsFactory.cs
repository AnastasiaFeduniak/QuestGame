using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lab5
{
    public class SpecEffectsFactory
    {
        private Dictionary<string, SpecEffects> fireworks = new Dictionary<string, SpecEffects>();

        public SpecEffects GetFirework(string gifPath)
        {
            if (!fireworks.ContainsKey(gifPath))
            {
                fireworks[gifPath] = new SpecEffects(gifPath);
            }
            return fireworks[gifPath];
        }
    }
}
