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

    public partial class MenuPage : ContentPage
    {
        public IList<Coffe> Coffes { get; set; }

       

        public MenuPage()
        {
            InitializeComponent();

            
            



            Coffes = new List<Coffe>();
            Coffes.Add(new Coffe
            {
                Name = "Latte",
                typeofCoffe = "(Extra Milk)",

                URL = "https://www.diyetkolik.com/site_media/media/nutrition_images/latte-yagsiz-sut-ile.jpg",
                Money = "12.5 TL"
            });
            Coffes.Add(new Coffe
            {
                Name = "Americano",
                typeofCoffe = "(Double 2x)",

                URL = "https://www.diyetkolik.com/site_media/media/nutrition_images/latte-yagsiz-sut-ile.jpg",
                Money = "10.5 TL"
            });
            Coffes.Add(new Coffe
            {
                Name = "White Mocha Chocolate",
                typeofCoffe = "(Double Shot)",

                URL = "https://www.diyetkolik.com/site_media/media/nutrition_images/latte-yagsiz-sut-ile.jpg",
                Money = "15.5 TL"
            });
            Coffes.Add(new Coffe
            {
                Name = "Latte Grande",
                typeofCoffe = "(Extra Milk)",

                URL = "https://www.diyetkolik.com/site_media/media/nutrition_images/latte-yagsiz-sut-ile.jpg",
                Money = "18.5 TL"
            });
            Coffes.Add(new Coffe
            {
                Name = "Cool Lime",
                typeofCoffe = "(Extra Lemon)",


                URL = "https://www.diyetkolik.com/site_media/media/nutrition_images/latte-yagsiz-sut-ile.jpg",
                Money = "17.5 TL"
            });
            Coffes.Add(new Coffe
            {
                Name = "Capuucino",
                typeofCoffe = "(Extra Chocolate)",

                URL = "https://www.diyetkolik.com/site_media/media/nutrition_images/latte-yagsiz-sut-ile.jpg",
                Money = "11.5 TL"
            });
            BindingContext = this;
        }

        public class Coffe
        {
            public string URL { get; set; }
            public string Name { get; set; }
            public string typeofCoffe { get; set; }
            public string Money { get; set; }

        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            var choice = await DisplayAlert("Coffe", "You Want this", "YES", "NO");
         
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}