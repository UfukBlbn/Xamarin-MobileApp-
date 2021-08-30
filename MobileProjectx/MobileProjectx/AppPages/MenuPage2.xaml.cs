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
    public partial class MenuPage2 : ContentPage
    {
        public IList<Food> Foods { get; set; }
        public MenuPage2()
        {
            InitializeComponent();
            Foods = new List<Food>();
            Foods.Add(new Food
            {
                FName = "Cheesecake",
                FtypeofFood = "(Strawberry)",

                FURL = "https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                FMoney = "22.5 TL"
            });
            Foods.Add(new Food
            {
                FName = "Hot Chocolate ",
                FtypeofFood = "XL",

                FURL = "https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                FMoney = "17.5 TL"
            });
            Foods.Add(new Food
            {
                FName = "Apple Pie",
                FtypeofFood = " Large ",

                FURL = "https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                FMoney = "12.5 TL"
            });
            Foods.Add(new Food
            {
                FName = "Ice-Cream",
                FtypeofFood = "(Milk&Chocolate)",

                FURL = "https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                FMoney = "22.5 TL"
            });
            Foods.Add(new Food
            {
                FName = "Brownie",
                FtypeofFood = "(Hot)",

                FURL = "https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                FMoney = "32.5 TL"
            });
            Foods.Add(new Food
            {
                FName = "Pasta",
                FtypeofFood = "(Strawberry)",

                FURL = "https://i2.wp.com/www.sugarspunrun.com/wp-content/uploads/2019/01/Best-Cheesecake-Recipe-2-1-of-1-4.jpg",
                FMoney = "29.5 TL"
            });

            BindingContext = this;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var choice = await DisplayAlert("Coffe", "You Want this", "YES", "NO");
        }
    }
    public class Food
    {
        public string FURL { get; set; }
        public string FName { get; set; }
        public string FtypeofFood { get; set; }
        public string FMoney { get; set; }

    }
}