using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        public List<User> Users;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
            LoadUsers();
        }

        private async void LoadUsers()
        {
            Users = await App.Database.GetUsersAsync();
            users.ItemsSource = Users;
        }
    }
}