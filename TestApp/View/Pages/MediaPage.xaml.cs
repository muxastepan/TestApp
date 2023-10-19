using System;
using System.Windows;
using System.Windows.Controls;

namespace TestApp.View.Pages
{
    public partial class MediaPage : Page
    {
        public MediaPage(string path)
        {            
            InitializeComponent();
            Path = new Uri(path);
        }

        public static readonly DependencyProperty PathProperty = DependencyProperty.Register(
            nameof(Path), typeof(Uri), typeof(MediaPage), new PropertyMetadata(default(Uri)));

        public Uri Path
        {
            get { return (Uri)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }
       
    }
}
