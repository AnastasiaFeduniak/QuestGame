using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Script
    {
        public string[] names { get; set; }
        public int[] sprite { get; set; }
        public string[] replics { get; set; }
        public int background = 0;
        public Script() { }
        public Script(string[] names, string[] replics, int[] sprite, int background)
        {
            this.names = names;
            this.replics = replics;
            this.sprite = sprite;
            this.background = background;
        }

        public int Length()
        {
            return replics.Length;
        }
    }
}
