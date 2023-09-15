using System.Drawing;

namespace tool_view_tiktok.UndetectChrome
{
    public class Helper
    {
        public static int getWidthScreen;
        public static int getHeightScreen;
        public static Point GetPointFromIndexPosition(int indexPos)
        {
            Point location = new Point();
            var widthWindowChrome = Form1.windowWidth;
            var heightWindowChrome = Form1.windowHeight;

            if ((indexPos + 1) > Form1.Column)
            {
                var row = indexPos / Form1.Column;
                var column = indexPos % Form1.Column;
                location.X = column * widthWindowChrome;
                location.Y = row * heightWindowChrome;
            }
            else
            {
                location.X = indexPos * widthWindowChrome;
                location.Y = 0;
            }
            return location;
        }
    }
}