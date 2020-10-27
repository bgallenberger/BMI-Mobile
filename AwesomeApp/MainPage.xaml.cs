using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (double.TryParse(weight.Text, out _) && double.TryParse(height.Text, out _))
            {
                double w = double.Parse(weight.Text);
                double h = double.Parse(height.Text);
                double bmi = Math.Round((w / (h * h)) * 703, 1);

                string range = "";

                if(bmi < 16.0)
                {
                    range = "Severely Underweight";
                } else if (bmi >= 16.0 && bmi < 18.5)
                {
                    range = "Underweight";
                }
                else if(18.5 >= 16.0 && bmi < 25)
                {
                    range = "Normal";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    range = "Overweight";
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    range = "Moderately Obese";
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    range = "Severely Obese";
                }
                else if (bmi > 40.0)
                {
                    range = "Morbidly Obese";
                }

                output.Text = $"Your BMI is {bmi}\nYou are {range}!";
            }
            else
            {
                output.Text = $"Please enter valid numbers";
            }
        }
    }
}
