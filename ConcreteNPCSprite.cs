using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ConcreteNPCSprite : INPCSprite
    {
        private string name = "Chirstian";
        private string currEmotion = "Neutral";

        public string getName()
        {
            return name;
        }
        public string getEmotion()
        {
            return currEmotion;
        }
        public void setEmotion(string emotion)
        {
            currEmotion = emotion;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        //потім буде діставати файл
        public void showNPC()
        {
            Console.WriteLine(name + "`s emotion is" + currEmotion);
        }

        public ConcreteNPCSprite() { }
        public ConcreteNPCSprite(string name, string currEmotion)
        {
            this.name = name;
            this.currEmotion = currEmotion;
        }
    }
}
