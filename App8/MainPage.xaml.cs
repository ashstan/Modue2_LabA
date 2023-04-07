using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            alabel.Text = "Super fun!";
        }

        //private void function(object sender, EventArgs e, int weight, int height)
        //{
        //    //function behavior 
            
        //    int bmi = weight * height;
            
        //}

        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            double height = double.Parse(Height.Text);
            double weight = double.Parse(Weight.Text);
            double bmi = weight / (height * height) * 703;
            alabel.Text = "Your BMI is {bmi}" + bmi;
        }
    }
}
