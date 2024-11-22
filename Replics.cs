using Lab5;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Replics
    {
        private Script replics { get; set; }
        private bool nextChoice = false;
        private InventoryGiver Item { get; set; }
        private MandatoryChoice choices { get; set; }
        public void Reset()
        {
            replics = new Script();
            Item = new InventoryGiver();
            choices = new MandatoryChoice();
        }

        public void setReplics(Script script)
        {
            this.replics = script;
        }

        public string getName(int a)
        {
            return replics.names[a];
        }
        public string getReplic(int a)
        {
            return replics.replics[a];
        }

        public int getSprite(int a)
        {
            return replics.sprite[a];
        }

        public void setNextChoice(bool choice)
        {
            this.nextChoice = choice;
        }

        public bool getNextChoice()
        {
            return this.nextChoice;
        }
        public Script getReplics()
        {
            return replics;
        }
        public void setItem(InventoryGiver item)
        {
            this.Item = item;
        }
        public InventoryGiver getItem()
        {
            return Item;
        }
        public void setChoices(MandatoryChoice choices)
        {
            this.choices = choices;
        }
        public MandatoryChoice getChoices()
        {
            return choices;
        }

        public Replics()
        {
            replics = new Script();
            Item = new InventoryGiver();
            choices = new MandatoryChoice();
        }
        public Replics(Script replics, bool nextChoice, InventoryGiver item, MandatoryChoice choices)
        {
            this.replics = replics;
            this.nextChoice = nextChoice;
            Item = item;
            this.choices = choices;
        }

        public Replics(ReplicBuilder builder)
        {
            this.replics = builder.replics;
            this.Item = builder.ItemGiver;
            this.choices = builder.ChoiceDependent;
        }
        public int Length()
        {
            return replics.Length();
        }
    }
}
