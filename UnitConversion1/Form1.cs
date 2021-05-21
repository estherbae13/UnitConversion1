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
            }
            else if (choice == 2)
            {
                FeetToCm(value);
            }
            else if (choice == 3)
            {
                YardsToMetres(value);
            }
            else if (choice == 4)
            {
                MilesToKm(value);
            }
            else
            {
                outputLabel.Text = "Input a number between 1 and 4";
            }
        }

        public void InchesToCm(double inches)
        {
            string choice = Convert.ToString(conversionChoiceInput.Text);
            double value = Convert.ToDouble(valueInput.Text);

            double cm = inches * 2.54;

            outputLabel.Text = $"{inches} inches is {cm.ToString(".##")}cm";
        }

        public void FeetToCm(double feet)
        {
            double cm2 = feet * 30.48;

            outputLabel.Text = $"{feet} feet is {cm2.ToString(".##")}cm";
        }

        public void YardsToMetres(double yards)
        {
            double m = yards * 0.91;

            outputLabel.Text = $"{yards} yards is {m.ToString(".##")}m";
        }

        public void MilesToKm(double miles)
        {
            double km = miles * 1.6;

            outputLabel.Text = $"{miles} miles is {km.ToString(".##")}km";
        }
    }
}
