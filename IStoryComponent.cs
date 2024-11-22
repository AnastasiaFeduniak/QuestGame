using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    interface IStoryComponent
    {
        void Display();
        void AddChoice(int choice);
        IStoryComponent GetNextComponent(int choice);

    }
}
