using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Choice
    {
        private string[] choices;
        private int inventories = -1;

        public Choice(string[] choices, int inventories)
        {
            this.choices = choices;
            this.inventories = inventories;
        }
        public int getInventories()
        {
            return inventories;
        }
        public void setChoices(string[] choices)
        {
            this.choices = choices;
        }
        public List<string> getChoices()
        {
            return this.choices.ToList();
        }
        public void setInventories(int inventories)
        {
            this.inventories = inventories;
        }
    }
}
