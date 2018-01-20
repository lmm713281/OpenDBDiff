using GalaSoft.MvvmLight;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OpenDBDiff.WPFUI.Commands
{
    public abstract class AsyncCommandBase : ObservableObject, IAsyncCommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public abstract bool IsExecuting { get; }

        public abstract bool CanExecute(object parameter);

        public async void Execute(object parameter)
        {
            await ExecuteAsync(parameter);
        }

        public abstract Task ExecuteAsync(object parameter);

        protected void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
