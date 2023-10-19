using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using TestApp.Utilities;
using TestApp.View.Pages;

namespace TestApp.ViewModel.Pages
{
    internal class MainPageViewModel: ViewModelBase
    {
        public ObservableCollection<FileInfo> Files { get;}

        public MainPageViewModel()
        {
            var dirInfo = new DirectoryInfo("Resources"); 
            Files = new ObservableCollection<FileInfo>();
            foreach (var file in dirInfo.GetFiles())
            {
                Files.Add(file);
            }
        }

        private ICommand showMediaCommand;
        public ICommand ShowMediaCommand => showMediaCommand ?? new RelayCommand(path =>
        {                                 
            App.TopFrame.Navigate(new MediaPage(path as string));            
        });

    }
}
