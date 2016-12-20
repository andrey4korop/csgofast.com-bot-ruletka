using System.Drawing;

namespace Бот_для_казино
{
    public class ColorOfPixel
    {
        public Bitmap img;
        public Graphics gr;

        public ColorOfPixel()
        {
            img = new Bitmap(1, 1);
        }
        public Color getColor(int x, int y)
        {
            /* byte r, g, b;
             IntPtr hDC = GetDC(wndHandle);
             uint pixel = GetPixel(hDC, x, y);
             ReleaseDC(IntPtr.Zero, hDC);

             r = (byte)(pixel & 0x000000FF);
             g = (byte)((pixel & 0x0000FF00) >> 8);
             b = (byte)((pixel & 0x00FF0000) >> 16);
             Color color = Color.FromArgb(1, r, g, b);
             return color;
         }

         #region DLLImport
         [DllImport("user32.dll")]
         public static extern IntPtr GetDC(IntPtr hwnd);

         [DllImport("user32.dll")]
         public static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

         [DllImport("gdi32.dll")]
         public static extern uint GetPixel(IntPtr hDC, int x, int y);
         #endregion
         */


            //private Color getColor(int x, int y)

            
            using (gr = Graphics.FromImage(img))
                gr.CopyFromScreen(new Point(x, y), Point.Empty, new Size(1, 1));
            return img.GetPixel(0, 0);

        }

    }
}
