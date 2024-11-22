using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAnimatedGif;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;

namespace Lab5
{
    public class SpecEffects
    {
        private readonly string gifPath;

        public SpecEffects(string gifPath)
        {
            this.gifPath = gifPath;
        }

        public Image Explode(int x, int y)
        {
            Image img = new Image();

            var image = new BitmapImage();

            image.BeginInit();
            image.UriSource = new Uri(gifPath);
            image.DecodePixelWidth = 20;
            image.DecodePixelHeight = 20;
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);

            return img;
        }
    }
}
