using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void LoginBtn(object sender, EventArgs e)
        {
            DisplayAlert("LOGIN", "Login Successful", "OK");
            Navigation.PushAsync(new NavPage(usernameentry.Text));
        }
    }
}