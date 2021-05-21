using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int choice = Convert.ToInt32(conversionChoiceInput.Text);
            double value = Convert.ToDouble(valueInput.Text);
            
            if (choice == 1)
            {
                InchesToCm(value);

                double convert = InchesToCm(value);
                outputLabel.Text = $"{value} inches is {convert.ToString(".##")}cm";
            }
            else if (choice == 2)
            {
                FeetToCm(value);

                double convert2 = FeetToCm(value);
                outputLabel.Text = $"{value} feet is {convert2.ToString(".##")}cm";
            }
            else if (choice == 3)
            {
                YardsToMetres(value);

                double convert3 = YardsToMetres(value);
                outputLabel.Text = $"{value} yards is {convert3.ToString(".##")}m";
            }
            else if (choice == 4)
            {
                MilesToKm(value);

                double convert4 = MilesToKm(value);
                outputLabel.Text = $"{value} miles is {convert4.ToString(".##")}km";
            }
            else
            {
                outputLabel.Text = "Input a number between 1 and 4";
            }
        }

        public double InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        public double FeetToCm(double feet)
        {
            double cm2 = feet * 30.48;
            return cm2;
        }

        public double YardsToMetres(double yards)
        {
            double m = yards * 0.91;
            return m;
        }

        public double MilesToKm(double miles)
        {
            double km = miles * 1.6;
            return km;
        }
    }
}
