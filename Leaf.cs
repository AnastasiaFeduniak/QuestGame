using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Leaf : IStoryComponent
    {
        public List<Replics> text = new List<Replics>();
        public Leaf(List<Replics> f) {
        this.text = f;
        }
        public void Display()
        {

        }
        public void AddChoice(int choice)
        {

        }
        public IStoryComponent GetNextComponent(int choice)
        {
            return null;
        }
    }
}
