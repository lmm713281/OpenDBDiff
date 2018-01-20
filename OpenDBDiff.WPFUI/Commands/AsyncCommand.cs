using GalaSoft.MvvmLight.Helpers;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OpenDBDiff.WPFUI.Commands
{
    public static class AsyncCommand
    {
        public const string CancelText = "Stop";
        public const string ExecutingText = "Run";

        public static AsyncCommand<object> Create(Func<Task> command)
        {
            return new AsyncCommand<object>(async _ => { await command(); return null; }, null);
        }

        public static AsyncCommand<TResult> Create<TResult>(Func<Task<TResult>> command)
        {
            return new AsyncCommand<TResult>(_ => command(), null);
        }

        public static AsyncCommand<object> Create(Func<CancellationToken, Task> command)
        {
            return new AsyncCommand<object>(async token => { await command(token); return null; }, null);
        }

        public static AsyncCommand<TResult> Create<TResult>(Func<CancellationToken, Task<TResult>> command, Func<bool> canExecute)
        {
            return new AsyncCommand<TResult>(command, canExecute);
        }
    }

    public class AsyncCommand<TResult> : AsyncCommandBase
    {
        private readonly CancelAsyncCommand _cancelCommand;
        private readonly WeakFunc<bool> _canExecute;
        private readonly WeakFunc<CancellationToken, Task<TResult>> _command;

        public AsyncCommand(Func<CancellationToken, Task<TResult>> command, Func<bool> canExecute)
        {
            _command = new WeakFunc<CancellationToken, Task<TResult>>(command);
            _cancelCommand = new CancelAsyncCommand();

            if (canExecute != null)
            {
                _canExecute = new WeakFunc<bool>(canExecute);
            }
        }

        public ICommand CancelCommand
        {
            get { return _cancelCommand; }
        }

        public NotifyTaskCompletion<TResult> Execution { get; private set; }

        public override bool IsExecuting
        {
            get { return !(Execution == null || Execution.IsCompleted); }
        }

        public override bool CanExecute(object parameter)
        {
            var firstTest = _canExecute == null
                || (_canExecute.IsStatic || _canExecute.IsAlive)
                    && _canExecute.Execute();

            return firstTest && !this.IsExecuting;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            _cancelCommand.NotifyCommandStarting();
            _cancelCommand.Token.ThrowIfCancellationRequested();
            Execution = new NotifyTaskCompletion<TResult>(_command.Execute(_cancelCommand.Token));
            RaiseCanExecuteChanged();
            RaisePropertyChanged(() => IsExecuting);
            await Execution.TaskCompletion;
            _cancelCommand.NotifyCommandFinished();
            RaiseCanExecuteChanged();
            RaisePropertyChanged(() => IsExecuting);
            RaisePropertyChanged(() => Execution);
        }

        private sealed class CancelAsyncCommand : ICommand
        {
            private bool _commandExecuting;
            private CancellationTokenSource _cts = new CancellationTokenSource();

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public CancellationToken Token { get { return _cts.Token; } }

            bool ICommand.CanExecute(object parameter)
            {
                return _commandExecuting && !_cts.IsCancellationRequested;
            }

            void ICommand.Execute(object parameter)
            {
                _cts.Cancel();
                RaiseCanExecuteChanged();
            }

            public void NotifyCommandFinished()
            {
                _commandExecuting = false;
                RaiseCanExecuteChanged();
            }

            public void NotifyCommandStarting()
            {
                _commandExecuting = true;
                if (!_cts.IsCancellationRequested)
                    return;
                _cts = new CancellationTokenSource();
                RaiseCanExecuteChanged();
            }

            private void RaiseCanExecuteChanged()
            {
                CommandManager.InvalidateRequerySuggested();
            }
        }
    }
}
