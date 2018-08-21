using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToolBox.MVVM;

namespace WebClientWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Window _window;

        public ICommand CloseWindowCommand { get; private set; }
        
        public MainViewModel()
        {
            /* Not a Best Practice... :( */
            _window = Application.Current.MainWindow;
            CloseWindowCommand = new RelayCommand(CloseWindow);
        }

        private void CloseWindow()
        {
            _window?.Close();
        }
    }
}
