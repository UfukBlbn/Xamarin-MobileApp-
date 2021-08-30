using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProjectx.AppPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopPage : ContentPage
    {
        bool radio1, radio2, radio3, radio4, rad1, rad2, rad3, rad4;


        private async void Button_Clicked_1(object sender, EventArgs e)

        {
            var choice = await DisplayAlert("Alert", "Do You Want to Add ? ", "NO","YES");

            if (rad1 == true)
                basx.Text = "Dessert Food Added in Basket & You Can Buy It From Payment Page :" + labela.Text;
            if (rad2 == true)
                basx.Text = "Dessert Food Added in Basket & You Can Buy It From Payment Page :" + labelb.Text;
            if (rad3 == true)
                basx.Text = "Dessert Food Added in Basket & You Can Buy It From Payment Page :" + labelc.Text;
            if (rad4 == true)
                basx.Text = "Dessert Food Added in Basket & You Can Buy It From Payment Page :" + labeld.Text;


        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            rad1 = true;
            
            if (rad1.Equals(true))
            {

                rad2 = false;
                rad3 = false;
                rad4 = false;
            }
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            rad2 = true;
            
            if (rad2.Equals(true))
            {

                rad1 = false;
                rad3 = false;
                rad4 = false;
            }
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            rad3 = true;
           
            if (rad3.Equals(true))
            {

                rad2 = false;
                rad1 = false;
                rad4 = false;
            }
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            rad4 = true;
           
            if (rad4.Equals(true))
            {

                rad2 = false;
                rad3 = false;
                rad1 = false;
            }

        }

        public ShopPage()
        {
            InitializeComponent();
            radio1 = false; radio2 = false; radio3 = false; radio4 = false;
            rad1 = false; rad2 = false; rad3 = false; rad4 = false;

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            radio3 = true;
            foto2.Source = "colm.jpg";
            if (radio3.Equals(true))
            {

                radio1 = false;
                radio2 = false;
                radio4 = false;
            }
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            radio4 = true;
            foto3.Source = "cap.jpg";
            if (radio4.Equals(true))
            {

                radio1 = false;
                radio2 = false;
                radio3 = false;
            }
        }

        public void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            radio1 = true;
            foto.Source = "coffe.png";
            if (radio2.Equals(true))
            {
               
                radio2 = false;
                radio3 = false;
                radio4 = false;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var choice = await DisplayAlert("Alert", "Do You Want Add ", "NO", "YES");
            if (radio1 == true)
                bas.Text = "Coffe Added in Basket & You Can Buy It From Payment Page :" + label.Text;
            if(radio2==true)
                bas.Text = "Coffe Added in Basket & You Can Buy It From Payment Page :" + label1.Text;
            if (radio3 == true)
                bas.Text = "Coffe Added in Basket & You Can Buy It From Payment Page :" + label2.Text;
            if (radio4 == true)
                bas.Text = "Coffe Added in Basket & You Can Buy It From Payment Page :" + label3.Text;

        }

        public void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            radio2 = true;
            foto1.Source = "americ.png";
            if (radio1.Equals(true))
            {
                
                radio1 = false;
                radio3 = false;
                radio4 = false;
            }

        }
    }
}