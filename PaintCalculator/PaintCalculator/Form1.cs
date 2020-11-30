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
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //Validating null fields
            if (txtHeight.TextLength == 0 || txtWidth.TextLength == 0 || txtLength.TextLength == 0)
            {
                MessageBox.Show("Please ensure that all fields have a value inputted", "Error");
                return;
            }
            //Validating alphabetical characters to ensure that only numeric information can be entered
            else if (!float.TryParse(txtLength.Text, out var Length) || !float.TryParse(txtWidth.Text, out var Width) || !float.TryParse(txtHeight.Text, out var Height))
            {
                MessageBox.Show("Please only enter numbers into the text boxes", "Error");
                return;
            }
            else
            {
                //Defining variables and preliminary calculations
                var LengthS = Length * Length;
                var WidthS = Width * Width;
                var Area = LengthS * WidthS;
                var Volume = Length * Width * Height;
                var Paint = Area * Height;
                //Sending calculations to labels
                lblArea.Text = Area.ToString() + "CM^2";
                lblVolume.Text = Volume.ToString() + "M^3";
                lblPaint.Text = Paint.ToString() + " L";
            }            
        }
    }
}
