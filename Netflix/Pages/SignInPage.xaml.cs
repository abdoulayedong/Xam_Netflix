using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Netflix.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            emailLabel.FontSize = 20;
            passwordLabel.FontSize = 20;

            emailLabel.VerticalOptions = LayoutOptions.Center;
            passwordLabel.VerticalOptions = LayoutOptions.Center;

            email.Focused += Email_Focused;
            email.Unfocused += Email_Unfocused;
            password.Focused += Password_Focused;
            password.Unfocused += Password_Unfocused;

        }

        private async void Password_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                await Task.WhenAny
                (
                    passwordLabel.TranslateTo(0, 0, easing: Easing.Linear),
                    password.TranslateTo(0, 0, easing: Easing.Linear)
                );
                passwordLabel.TextColor = Color.LightGray;
                passwordFrame.Padding = 5;
                passwordLabel.FontSize = 20;
            }
        }

        private async void Password_Focused(object sender, FocusEventArgs e)
        {
            await Task.WhenAny<bool>
            (
                passwordLabel.TranslateTo(0, -17, easing: Easing.Linear),
                password.TranslateTo(0, 5, easing: Easing.Linear)
            );
            passwordLabel.TextColor = Color.White;
            passwordFrame.Padding = 7;
            passwordLabel.FontSize = 8;
        }

        private async void Email_Unfocused(object sender, FocusEventArgs e)
        {
            if(string.IsNullOrEmpty(email.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                await Task.WhenAny
                (
                    emailLabel.TranslateTo(0, 0, easing: Easing.Linear),
                    email.TranslateTo(0, 0, easing: Easing.Linear)
                );
                emailLabel.TextColor = Color.LightGray;
                emailFrame.Padding = 5;
                emailLabel.FontSize = 20;
            }
        }

        private async void Email_Focused(object sender, FocusEventArgs e)
        {
            await Task.WhenAny<bool>
            (
                emailLabel.TranslateTo(0, -17, easing: Easing.Linear),
                email.TranslateTo(0, 5, easing:Easing.Linear)
            );
            emailLabel.TextColor = Color.White;
            emailFrame.Padding = 7;
            emailLabel.FontSize = 8;
        }
    }
}