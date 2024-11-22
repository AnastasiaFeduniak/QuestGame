using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class ReplicBuilder : IBuilder
    {
        public Script replics { get; set; }
        public InventoryGiver ItemGiver { get; set; }
        public MandatoryChoice ChoiceDependent { get; set; }

        public ReplicBuilder() { }
        public void BuildReplics(string[] name, string[] replic, int[] sprite, int background)
        {
            replics = new Script(name, replic, sprite, background);
        }
        public void BuildReplics(Script script)
        {
            replics = script;
        }
        public void BuildMandatoryChoices(MandatoryChoice choices)
        {
            ChoiceDependent = choices;
        }
        public void BuildInventoryGiver(InventoryGiver item)
        {
            ItemGiver = item;
        }
        public Replics Result()
        {
            return new Replics(this);
        }
    }
}
