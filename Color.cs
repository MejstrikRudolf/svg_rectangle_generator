using System;
using System.Collections.Generic;
using System.Text;

namespace recrangle_svg_gen
{
    public class Color
    {
        public short Red { get; set; }
        public short Green { get; set; }
        public short Blue { get; set; }

        public String getRGB()
        {
            return $"({Red}, {Green}, {Blue})";
        }
    }
}
