using System.Windows;
using System.Windows.Input;

namespace TestApp.View.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                
        private ICommand closeAppCommand;
        public ICommand CloseAppCommand => closeAppCommand ?? new RelayCommand(obj =>
        {
            Close();
        }) ;

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            App.TopFrame = NavFrame;
        }
    }
}
