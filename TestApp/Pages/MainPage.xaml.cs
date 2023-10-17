
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;

namespace TestApp.Assets.Pages
{    
    public partial class MainPage : Page
    {
        public MainPage()
        {            
            InitializeComponent();
            BuildPage();
        }

        private void BuildPage()
        {
            DirectoryInfo mediaResources = new DirectoryInfo("Resources");
            FileInfo[] mediaFiles = mediaResources.GetFiles();
            
            GridLength splitRowHeight = new GridLength(0.75, GridUnitType.Star);
            GridLength rowHeight = new GridLength(1, GridUnitType.Star);

            int rowCounter = 0;
            for (int i = 0; i < mediaFiles.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    RowDefinition row = new RowDefinition
                    {
                        Height = rowHeight
                    };
                    RowDefinition splitRow = new RowDefinition
                    {
                        Height = splitRowHeight
                    };

                    MainGrid.RowDefinitions.Add(splitRow);
                    MainGrid.RowDefinitions.Add(row);

                    rowCounter += 2;
                }

                Button button = new Button
                {
                    Content = Path.GetFileNameWithoutExtension(mediaFiles[i].Name),
                    Command = ShowMediaCommand,
                    CommandParameter = mediaFiles[i].FullName
                };

                Grid.SetRow(button, rowCounter);
                Grid.SetColumn(button, (i % 3) * 2 + 1);
                MainGrid.Children.Add(button);
            }

            RowDefinition footerRow = new RowDefinition
            {
                Height = rowHeight
            };

            MainGrid.RowDefinitions.Add(footerRow);
        }

        private ICommand showMediaCommand;       
        public ICommand ShowMediaCommand => showMediaCommand ?? new RelayCommand(Path =>
        {
            NavigationService.Navigate(new MediaPage(Path.ToString()));                       
        });        
    }
}
