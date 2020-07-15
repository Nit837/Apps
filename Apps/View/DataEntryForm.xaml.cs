using Apps.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Apps.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataEntryForm : ContentPage
    {
        UserDetail users;
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private async void btnsave_Clicked(object sender, EventArgs e)
        {
            Datamanager dataManager = new Datamanager();
            users = new UserDetail()
            {
                Username = name.Text,
                UserPhone = phone.Text,
                UserEmail = email.Text,
                Savetime = DateTime.Now.ToShortTimeString()
            };
            int result = await dataManager.SaveUserDetailAsync(users);
            if (result == 1)
            {
                name.Text = string.Empty;
                phone.Text = string.Empty;
                email.Text = string.Empty;
                await DisplayAlert("", "Record Saved", "OK");
            }
        }
        private async void CrossPage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}