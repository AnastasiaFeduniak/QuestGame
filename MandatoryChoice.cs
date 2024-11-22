using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class MandatoryChoice
    {
        public int[] index { get; set; }
        public int[] value { get; set; }

        public MandatoryChoice() { }
        public MandatoryChoice(int[] index, int[] value)
        {
            this.index = index;
            this.value = value;
        }
        public int Length()
        {
            return index.Length;
        }
    }
}
