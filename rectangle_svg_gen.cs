using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace recrangle_svg_gen
{
    public partial class Rectangle_generator : Form
    {
        public Rectangle_generator()
        {
            InitializeComponent();
        }

        Draw Draw = new Draw();


        private void button_add_Click(object sender, EventArgs e)
        {
            var rectangle = new Rectangle()
            {
                Color = new Color
                {
                    Red = (short)numeric_red.Value,
                    Green = (short)numeric_green.Value,
                    Blue = (short)numeric_blue.Value
                },
                PosX = (int) numeric_posx.Value,
                PosY = (int) numeric_posy.Value,
                Width = (int) numeric_width.Value,
                Height = (int) numeric_height.Value
            };
            Draw.rectangles.Add(rectangle);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Draw.draw();           
        }
       

    }
}
