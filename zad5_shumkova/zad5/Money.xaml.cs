using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Money :ContentPage
    {
        private Entry usdLabel;
        private Label eurLabel;
        private Label date;


        public Money (string username)
        {
            InitializeComponent( );
            double usd = 70.000;
            usdLabel = new Entry
            {
                Text = $"{usd}",
                FontAttributes = FontAttributes.Bold,
                StyleId = "mystylee",
                Margin = new Thickness(30, 20, 20, 30)
            };
            double ada = double.Parse(usdLabel.Text);
            eurLabel = new Label
            {
                Text = $"EUR  {ada * 1.075}",
                FontAttributes = FontAttributes.Bold,
                TextDecorations = TextDecorations.Underline,
                Margin = new Thickness(30, 20, 20, 30)

            };

            var usernameLabel = new Label
            {
                Text = $"Welcome , {username}!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };



            date = new Label
            {
                Text = DateTime.Today.ToString( ),
                HorizontalTextAlignment = TextAlignment.End,
                FontAttributes = FontAttributes.Bold,
                TextDecorations = TextDecorations.Underline,
                Margin = new Thickness(30, 0, 10, 0)
            };

            Content = new StackLayout
            {
                Children =
                {
                    usernameLabel,
                    new Label { Text = "Центробанк РФ: ",Margin =new Thickness (30,0,50,0)},
                    new Label { Text = "Текущая дата: ",HorizontalTextAlignment = TextAlignment.End,Margin = new Thickness(0,0,10,0)},
                    date,
                    usdLabel,
                    eurLabel
                    
                }
            };
        }
    }
}