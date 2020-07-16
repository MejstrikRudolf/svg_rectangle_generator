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

        public void GetProperties()
        {
            properties = (numeric_width.Value, numeric_height.Value, numeric_posx.Value, numeric_posy.Value, (numeric_red.Value, numeric_green.Value, numeric_blue.Value));
        }
        
        (decimal width, decimal height, decimal pos_x, decimal pos_y, (decimal red, decimal green, decimal blue) colors) properties;
        StreamWriter sw = new StreamWriter("rectangles.svg");

        private void button_add_Click(object sender, EventArgs e)
        {
            GetProperties();
            sw.WriteLine($"<rect x = \"{properties.pos_x}\" y = \"{properties.pos_y}\" width = \"{properties.width}\" height = \"{properties.height}\" style=\"fill: rgb{properties.colors}\" />");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sw.WriteLine("<svg width = \"1000\" height = \"1000\" version = \"1.1\" xmlns = \"http://www.w3.org/2000/svg\" >");
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            sw.Write("</svg>");
            sw.Flush();
            sw.Close();
        }
       

    }
}
