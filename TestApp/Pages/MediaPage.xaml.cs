
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace TestApp.Assets.Pages
{
    public partial class MediaPage : Page
    {
        public MediaPage(string path)
        {
            InitializeComponent();
            Media.Source = new System.Uri(path);
        }


        private ICommand hideMediaCommand;
        public ICommand HideMediaCommand => hideMediaCommand ?? new RelayCommand( obj =>
        {
            NavigationService.GoBack();
        });        
    }
}
