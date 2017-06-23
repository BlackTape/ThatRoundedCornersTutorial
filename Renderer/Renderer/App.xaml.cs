using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Renderer
{
    public partial class App : Application
    {
        public App()
        {
           // InitializeComponent();
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Padding = new Thickness(10, 10, 10, 0),
                    Spacing = 20,
                    Children =
                    {
                        new Label
                        {
                            XAlign= TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!",
                            TextColor = Color.Black,
                            FontSize = 20,
                        },
                        new Button()
                        {
                            Text = " Click this Normal Button!",
                            BorderWidth = 2,
                            BorderColor = Color.Black,
                            BackgroundColor = Color.White,
                            TextColor = Color.Black,
                        },
                        new RoundCornersButton()
                        {
                            Text = " Click this Rounded Corners Button!",
                            BorderWidth = 2,
                            BorderColor = Color.Black,
                            BackgroundColor = Color.White,
                            TextColor = Color.Black,
                        }
                    }
                },
                BackgroundColor = Color.White
            };

            //MainPage = new Renderer.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
