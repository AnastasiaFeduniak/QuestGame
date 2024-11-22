using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal interface ISprites
    {
        INPCSprite CreateSprite();
        IPictureSprite CreatePictureSprite();
    }
}
