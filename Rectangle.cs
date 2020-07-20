using System;
using System.Collections.Generic;
using System.Text;

namespace recrangle_svg_gen
{
    public class Rectangle
    {

        public decimal width;

        decimal height;

        decimal pos_x;

        decimal pos_y;

        (decimal red, decimal green, decimal blue) colors;



        public Rectangle(decimal rectangle_width, decimal rectangle_height, decimal rectangle_pos_x, decimal rectangle_pos_y, (decimal rectangle_red, decimal rectangle_green, decimal rectangle_blue) rectangle_colors)
        {
            this.width = rectangle_width;
            this.height = rectangle_height;
            this.pos_x = rectangle_pos_x;
            this.pos_y = rectangle_pos_y;
            this.colors = rectangle_colors;
        }

        public decimal GetWidth() 
        {
            return this.width;
        }

        public decimal GetHeight()
        {
            return this.height;
        }

        public decimal GetPosX()
        {
            return this.pos_x;
        }

        public decimal GetPosY()
        {
            return this.pos_y;
        }

        public (decimal,decimal,decimal) GetColors()
        {
            return this.colors;
        }
    }
}
