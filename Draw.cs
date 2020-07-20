using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace recrangle_svg_gen
{
    public class Draw
    {

        StreamWriter sw = new StreamWriter("rectangle.svg");
        public List<Rectangle> rectangles = new List<Rectangle>();

        public void draw()
        {
            sw.WriteLine("<svg width = \"1000\" height = \"1000\" version = \"1.1\" xmlns = \"http://www.w3.org/2000/svg\" >");
            this.rectangle();
            sw.WriteLine("</svg>");
            sw.Flush();
            sw.Close();
            
        }

        void rectangle()
        {
            
            foreach (Rectangle rec in rectangles)
            {
                sw.WriteLine($"<rect x = \"{rec.GetPosX()}\" y = \"{rec.GetPosY()}\" width = \"{rec.GetWidth()}\" height = \"{rec.GetHeight()}\" style=\"fill: rgb{rec.GetColors()}\" />");
            }

        }
    }
}



