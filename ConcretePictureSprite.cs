using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ConcretePictureSprite : IPictureSprite
    {
        private string FileName;

        public ConcretePictureSprite() { }
        public ConcretePictureSprite(string fileName)
        {
            this.FileName = fileName;
        }

        public string getFileName()
        {
            return FileName;
        }
        public void setFileName(string fileName)
        {
            this.FileName = fileName;
        }
        public void showPicture()
        {
            Console.WriteLine("This is that picture: " + FileName);
        }
    }
}
