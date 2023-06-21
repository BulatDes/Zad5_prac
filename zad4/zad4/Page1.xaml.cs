using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 :ContentPage
    {
        public Page1 ()
        {
            InitializeComponent();
        }
        private async void InputButton_Clicked (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(pass.Text))
            {
                DisplayAlert("Внимание", "Заполните логин и пароль", "OK");
                return;
            }

            await Navigation.PushModalAsync(new MainPage(login.Text,pass.Text));
        }
    }
}