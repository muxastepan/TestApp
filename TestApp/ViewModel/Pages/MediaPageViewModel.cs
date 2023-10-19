using System.Windows.Input;

namespace TestApp.ViewModel.Pages
{
    internal class MediaPageViewModel
    {
        private ICommand hideMediaCommand;
        public ICommand HideMediaCommand => hideMediaCommand ?? new RelayCommand(obj =>
        {
            App.TopFrame.NavigationService.GoBack();
        });
    }
}
