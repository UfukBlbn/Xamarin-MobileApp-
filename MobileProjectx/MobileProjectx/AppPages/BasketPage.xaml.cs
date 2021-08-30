using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using MobileProjectx.AppPages;

namespace MobileProjectx.AppPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPage : ContentPage
    {

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            //Get All Persons  
            var personList = await App.SQLiteDb.GetItemsAsync();
            if (personList != null)
            {
                lstPersons.ItemsSource = personList;
            }
        }

        public BasketPage()
        {
            InitializeComponent();
           
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonId.Text))
            {
                //Get Person  
                var xperson = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtPersonId.Text));
                if (xperson != null)
                {
                    //Delete Person  
                    await App.SQLiteDb.DeleteItemAsync(xperson);
                    txtPersonId.Text = string.Empty;
                    await DisplayAlert("Success", "Address Deleted", "OK");

                    //Get All Persons  
                    var personList = await App.SQLiteDb.GetItemsAsync();
                    if (personList != null)
                    {
                        lstPersons.ItemsSource = personList;
                    }
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter AddressID", "OK");
            }

        }

        private async void btnUpdate_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonId.Text))
            {
                person xperson = new person()
                {
                    PersonID = Convert.ToInt32(txtPersonId.Text),
                    Name = txtName.Text
                };

                //Update Person  
                await App.SQLiteDb.SaveItemAsync(xperson);

                txtPersonId.Text = string.Empty;
                txtName.Text = string.Empty;
                await DisplayAlert("Success", "Address Updated Successfully", "OK");
                //Get All Persons  
                var personList = await App.SQLiteDb.GetItemsAsync();
                if (personList != null)
                {
                    lstPersons.ItemsSource = personList;
                }

            }
            else
            {
                await DisplayAlert("Required", "Please Enter AddressID", "OK");
            }

        }

        private async void btnRead_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPersonId.Text))
            {
                //Get Person  
                var xperson = await App.SQLiteDb.GetItemAsync(Convert.ToInt32(txtPersonId.Text));
                if (xperson != null)
                {
                    txtName.Text = xperson.Name;
                    await DisplayAlert("Success", "Address : " + xperson.Name, "OK");
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter AddressID", "OK");
            }
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                person xperson = new person()
                {
                    Name = txtName.Text
                };

                //Add New Person  
                await App.SQLiteDb.SaveItemAsync(xperson);
                txtName.Text = string.Empty;
                await DisplayAlert("Success", "Address added Successfully", "OK");
                //Get All Persons  
                var personList = await App.SQLiteDb.GetItemsAsync();
                if (personList != null)
                {
                    lstPersons.ItemsSource = personList;
                }
            }
            else
            {
                await DisplayAlert("Required", "Please Enter Address!", "OK");
            }

        }
    }
}