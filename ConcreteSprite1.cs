using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ConcreteSprite1
    {
        public INPCSprite CreateSprite()
        {
            return new ConcreteNPCSprite();
        }
        public IPictureSprite CreatePicture()
        {
            return new ConcretePictureSprite();
        }
    }
}
