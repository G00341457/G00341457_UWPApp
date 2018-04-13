using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace G00341457_UWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            var position = await UWPWeather.LocationManager.GetPosition();



            RootObject myWeather = await OpenWeatherMapProxy.GetWeather(position.Coordinate.Latitude, position.Coordinate.Longitude);
            string icon = String.Format("http://openweathermap.org/img/w/{0}.png", myWeather.weather[0].icon);
            ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            ResultTextBlock.Text = myWeather.name + " - " + ((int)myWeather.main.temp).ToString() + " - " + myWeather.weather[0].description;

        }

        private void RatButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rat));
        }

        private void Dog_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dog));
        }

        private void Ox_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rat));
        }

        private void tiger_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tiger));
        }

        private void Rabbit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rabbit));
        }

        private void Dragon_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Dragon));
        }

        private void Snake_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Snake));
        }

        private void horse_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(horse));
        }

        private void Goat_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Goat));
        }

        private void Rooster_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rooster));
        }

        private void Pig_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pig));
        }

        private void Monkey_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Monkey));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Calender));
        }
    }
}
