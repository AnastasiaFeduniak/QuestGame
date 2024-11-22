using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal interface IBuilder
    {
        public void BuildReplics(string[] name, string[] replic, int[] sprite, int background);
        public void BuildMandatoryChoices(MandatoryChoice choices);
        public void BuildInventoryGiver(InventoryGiver item);
        public Replics Result();
    }
}
