using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;


namespace MobileProjectx.AppPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        public SQLiteConnection Conn;
        public card ct;
        public PaymentPage()
        {
            InitializeComponent();
            Conn = DependencyService.Get<sqlliteınterfacex>().GetConnection();
            Conn.CreateTable<card>();
        }

        private async  void Button_Clicked(object sender, EventArgs e)
        {
            var choice = await DisplayAlert("You are saving your ınfos ", "Do You Want to PAY", "YES", "NO");
            ct = new card();
            ct.CardNo = adresseID.Text;
            ct.OwnerName = txtAddressName.Text;
            Conn.Insert(ct);


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
                var data = (from stu in Conn.Table<card>() select stu);
                card_List_View.ItemsSource = data;

        }

       
    }
}