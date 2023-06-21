using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage :ContentPage
    {
        public LoginPage ()
        {
            InitializeComponent( );         
            var welcomeLabel = new Label
            {
                StyleId = "header",
                Text = "Welcome",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            var usernameEntry = new Entry
            {
                Placeholder = "Login",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StyleId = "mystylee"

            };

            var passwordEntry = new Entry
            {
                Placeholder = "password",
                IsPassword = true,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StyleId = "mystylee"
            };

            var rememberMeRadioButton = new RadioButton
            {
                Content = "Remember me",
                HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Color.White,
                
                
                
            };

            var signInButton = new Button
            {
                Text = "Sign in",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var signInLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    rememberMeRadioButton,
                    signInButton,
                    new Label{ Text = "I forgot!", HorizontalOptions = LayoutOptions.End }
                }
            };

            var errorMessageLabel = new Label
            {
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center
            };
            var moneyBut = new Button
            {
                Text = "money",
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };

            moneyBut.Clicked += (sender, e) =>
            {
                string username = usernameEntry.Text;
                Navigation.PushAsync(new Money(username));
            };

            signInButton.Clicked += (sender, e) =>
            {

                if ( string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text) )
                {
                    errorMessageLabel.Text = "enter login and password";
                }
                else
                {

                    string username = usernameEntry.Text;
                    string password = passwordEntry.Text;


                    Navigation.PushAsync(new MainPage(username));
                }
            };


            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(30),
                Children =
                {
                    welcomeLabel,
                    usernameEntry,
                    passwordEntry,
                    signInButton,
                    errorMessageLabel,
                    rememberMeRadioButton,
                    signInLayout,
                    moneyBut


                }
            };


            Content = stackLayout;



        }
    }
}