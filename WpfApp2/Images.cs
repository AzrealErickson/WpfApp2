using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp2
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("ironbar.jpg");
        public readonly static ImageSource Body = LoadImage("body2.png");
        public readonly static ImageSource Head = LoadImage("cupcakelover.png");
        public readonly static ImageSource Food = LoadImage("cupcake.png");
        public readonly static ImageSource DeadBody = LoadImage("happychris2.jpg");
        public readonly static ImageSource DeadHead = LoadImage("deadedp.jpg");
        public readonly static ImageSource Police = LoadImage("Police.jpg");
        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
