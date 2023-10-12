using System;
using System.Windows;

namespace TestApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Tourism_btn_Click(object sender, RoutedEventArgs e)
        {
            ShowMedia("Data/sphinx.jpg");
        }

        private void ManufactureInEgypt_btn_Click(object sender, RoutedEventArgs e)
        {
            ShowMedia("Data/city.jpg");
        }

        private void Agriculture_btn_Click(object sender, RoutedEventArgs e)
        {
            ShowMedia("Data/camel.jpeg");
        }

        private void EgyptAir_btn_Click(object sender, RoutedEventArgs e)
        {
            ShowMedia("Data/car.mp4");
        }

        private void LiveInEgypt_btn_Click(object sender, RoutedEventArgs e)
        {
            ShowMedia("Data/hamud.mp4");
        }

        private void SuezCanal_btn_Click(object sender, RoutedEventArgs e)
        {
            ShowMedia("Data/suez_channel.jpg");            
        }

        //Обработка события закрытия медиа элемента
        private void HideMedia_btn_Click(object sender, RoutedEventArgs e)
        {
            MediaGrid.Visibility = Visibility.Hidden;
            Media.Stop();
        }

        //Функция открытия медиа элемента
        private void ShowMedia(string path)
        {
            MediaGrid.Visibility = Visibility.Visible;
            Media.Source = new Uri(path, UriKind.Relative);
            Media.Play();
        }
    }
}
