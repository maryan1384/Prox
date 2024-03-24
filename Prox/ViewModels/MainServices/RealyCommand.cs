using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Prox.ViewModels.MainServices
{
    public class ViewModelCommandBase : ICommand
    {
        //Fields
        private Action<object> _action;
        private Predicate<object> _predicate;

        //Cunstructors
        public ViewModelCommandBase(Action<object> ExecuteAction)
        {
            _action = ExecuteAction;
            _predicate = null;
        }

        public ViewModelCommandBase(Action<object> ExecuteAction, Predicate<object> CanExecuteAction)
        {
            _action = ExecuteAction;
            _predicate = CanExecuteAction;
        }

        //Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        //Methods
        public bool CanExecute(object parameter)
        {
            return _predicate == null ? true : _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            try
            {
                _action(parameter);
            }
            catch
            {
                MessageBox.Show("Application Services Not Found \n\rPlease Restart Application", "Error", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.ServiceNotification);
                Application.Current.Shutdown();
            }
        }
    }
}
