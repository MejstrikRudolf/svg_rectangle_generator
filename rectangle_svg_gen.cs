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
            Rectangle rectangle = new Rectangle(numeric_width.Value, numeric_height.Value, numeric_posx.Value, numeric_posy.Value, (numeric_red.Value, numeric_green.Value, numeric_blue.Value));
            Draw.rectangles.Add(rectangle);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Draw.draw();           
        }
       

    }
}
