using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Composite
    {
        private List<IStoryComponent> children = new List<IStoryComponent>();

        public void Add(IStoryComponent component)
        {
            children.Add(component);
        }

        public void Remove(IStoryComponent component)
        {
            children.Remove(component);
        }

        public void Display()
        {
            
        }

        public void AddChoice(int choice)
        {
            foreach (var child in children)
            {
                child.AddChoice(choice);
            }
        }

        public IStoryComponent GetNextComponent(int choice)
        {
            return children[choice];
        }
    }
}
