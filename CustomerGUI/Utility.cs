using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CustomerGUI
{
    public class Utility
    {
    LibraryYellowBall.FinalProjectWPFEntitiesApril18 ctx;
        byte[] currentImage;
        public static BitmapImage ByteToImage(byte[] dataImage)
        {

            if (dataImage == null || dataImage.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(dataImage))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
        public static void AutoResizeColumns(ListView listView)
        {
            GridView gv = listView.View as GridView;
            if (gv != null)
            {
                foreach (var c in gv.Columns)
                {
                    if (double.IsNaN(c.Width))
                    {
                        c.Width = c.ActualWidth;
                    }
                    c.Width = double.NaN;
                }
            }
        }
    }
}
