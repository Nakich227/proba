using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = double.Parse(AA.Text);
            double b = double.Parse(BB.Text);
            double c = double.Parse(CC.Text);
            double D = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            string s = "";

            if (D == 0)
            {
                double x = -b / (2 * a);
                s = $"Уранение имеет 1 корень x = {x}";
            }
            else if (D > 0)
            {
                double x1, x2;
                x1 = (-b - D) / (2 * a);
                x2 = (-b + D) / (2 * a);
                s = $"Уравнение имеет два корня x1={x1}, x2={x2}";
            }
            else
            {
                s = "Уравнение не имеет решений.";
            }


            DisplayAlert("Ответ", $"{s}", "Ок");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}