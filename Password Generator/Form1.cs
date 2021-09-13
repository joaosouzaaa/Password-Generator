using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            writeonimage();
        }
        private void writeonimage()
        {
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            // It will create a map of bits in the sizes specifieds, in this case its height and width from the picturebox.
            var font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            // Defines the type, syze e how the font will be used.
            var graphics = Graphics.FromImage(image);
            // Compress the draw into a text.
            graphics.DrawString(Generator.Passwords(), font, Brushes.Black, new Point(0, 0));
            // Draw the text in your picture box.
            this.pictureBox1.Image = image;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeonimage();
            // Whem the button is pressed the random password will be generated.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
