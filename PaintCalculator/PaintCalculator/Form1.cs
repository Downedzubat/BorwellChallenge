using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var Length = float.Parse(txtLength.Text);
            var LengthS = Length * Length;

            var Width = float.Parse(txtWidth.Text);
            var WidthS = Width * Width;

            var Height = float.Parse(txtHeight.Text);

            Length.ToString();
            Width.ToString();
            LengthS.ToString();
            WidthS.ToString();
            Height.ToString();

            var Area = LengthS * WidthS;
            var Volume = Length * Width * Height;
            var Paint = Area * Height;

            lblArea.Text = Area.ToString();
            lblVolume.Text = Volume.ToString();
            lblPaint.Text = Paint.ToString();

            
            
        }
    }
}
