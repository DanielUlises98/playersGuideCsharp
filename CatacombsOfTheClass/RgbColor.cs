using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatacombsOfTheClass
{
    public class RGBColorS
    {
        public byte RgbRed { get; set; }
        public byte RgbGreen { get; set; }
        public byte RgbBlue { get; set; }

        public static RGBColorS White => new RGBColorS(255, 255, 255);

        public static RGBColorS Black => new RGBColorS(0, 0, 0);

        public static RGBColorS Red => new RGBColorS(255, 0, 0);

        public static RGBColorS Orange => new RGBColorS(255, 165, 0);

        public static RGBColorS Yellow => new RGBColorS(255, 255, 0);

        public static RGBColorS Green => new RGBColorS(0, 128, 0);
        public static RGBColorS Blue => new RGBColorS(0, 0, 255);

        public static RGBColorS Purple => new RGBColorS(128, 0, 128);


        public RGBColorS(byte red, byte green, byte blue)
        {
            RgbRed = red;
            RgbGreen = green;
            RgbBlue = blue;
        }
    }
}
