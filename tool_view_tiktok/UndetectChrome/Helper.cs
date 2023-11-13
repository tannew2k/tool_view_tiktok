using System.Drawing;

namespace tool_view_tiktok.UndetectChrome
{
    public class Helper
    {
        public static int getWidthScreen;
        public static int getHeightScreen;
        public static Point GetPointFromIndexPosition(int indexPos)
        {
            var location = new Point();
            var widthWindowChrome = Form1.windowWidth;
            var heightWindowChrome = Form1.windowHeight;

              if ((indexPos + 1) > Form1.column)
              {
                  Form1.row = indexPos / Form1.column;
                  Form1.column = indexPos % Form1.column;
                  location.X = Form1.column * widthWindowChrome;
                  location.Y = Form1.row * heightWindowChrome;
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