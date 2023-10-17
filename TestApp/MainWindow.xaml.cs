using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace TestApp
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

    }
}
