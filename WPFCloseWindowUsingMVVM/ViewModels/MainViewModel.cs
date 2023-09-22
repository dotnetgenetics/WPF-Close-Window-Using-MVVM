using System.Windows;
using System.Windows.Input;

namespace WPFCloseWindowUsingMVVM.ViewModels
{
    public partial class MainWindowViewModel : clsViewModelBase
    {
        private ICommand pClosingWindowCommand;
        public ICommand ClosingWindowCommand
        {
            get
            {
                return pClosingWindowCommand ?? (pClosingWindowCommand = new DelegateCommand(fnCloseWindow));
            }
        }

        public void fnCloseWindow(object obj)
        {
            Window window = (Window)obj;
            window.Close();
        }
    }
}
