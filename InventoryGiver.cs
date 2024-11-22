using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class InventoryGiver
    {
        public int ItemId = -1;
        public int ReplicIndex { get; set; }

        public InventoryGiver() { }
        public InventoryGiver(int ItemId, int ReplicIndex)
        {
            this.ItemId = ItemId;
            this.ItemId = ReplicIndex;
        }
    }
}
