using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MvvmDialogs;
using System;
using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace OpenDBDiff.WPFUI.Features.DatabaseSelectorUserControl
{
    using Commands;
    using Extensions;
    using GalaSoft.MvvmLight.Threading;
    using Utils;

    public class DatabaseSelectorViewModel : ViewModelBase, IDisposable
    {
        private readonly IDialogService dialogService;

        public DatabaseSelectorViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            if (this.IsInDesignMode || true)
            {
                this.ServerName = "localhost\\sqlexpress";
                //this.Username = "igitur";
                //this.Password = "asdf".ConvertToSecureString();
                this.IsWindowsAuthentication = true;
            }

            // Async event handlers
            this.TestConnectionCommand.PropertyChanged += AsyncCommand_PropertyChanged;
        }

        public string Database { get; set; }
        public bool IsWindowsAuthentication { get; set; }
        public SecureString Password { get; set; }
        public string ServerName { get; set; }
        public string Username { get; set; }

        #region Commands

        private RelayCommand<RoutedEventArgs> passwordChangedCommand;
        private AsyncCommand<bool> testConnectionCommand;

        public bool IsTestConnectionCommandEnabled
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ServerName)) return false;
                if (!IsWindowsAuthentication && (string.IsNullOrWhiteSpace(Username) || Password.Length == 0)) return false;
                if (TestConnectionCommand.IsExecuting) return false;

                return true;
            }
        }

        public RelayCommand<RoutedEventArgs> PasswordChangedCommand
        {
            get
            {
                return passwordChangedCommand ?? (passwordChangedCommand = new RelayCommand<RoutedEventArgs>(e =>
                {
                    var passwordBox = e.Source as PasswordBox;
                    this.Password = passwordBox.Password.ConvertToSecureString();
                }, e => e.Source is PasswordBox));
            }
        }

        public AsyncCommand<bool> TestConnectionCommand
        {
            get
            {
                return testConnectionCommand ?? (testConnectionCommand = AsyncCommand.Create(async token =>
                {
                    var success = await SqlConnectionChecker.CanConnect(this.ServerName, "master", token);
                    if (!token.IsCancellationRequested)
                    {
                        if (success)
                            DispatcherHelper.CheckBeginInvokeOnUI(() => { dialogService.ShowMessageBox(this, "The connection was tested successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information); });

                        else
                            DispatcherHelper.CheckBeginInvokeOnUI(() => { dialogService.ShowMessageBox(this, "The connection to the server failed.", "Error", MessageBoxButton.OK, MessageBoxImage.Error); });
                    }

                    return success;
                }, () => IsTestConnectionCommandEnabled));
            }
        }

        private void AsyncCommand_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var command = sender as AsyncCommand<bool>;
            if (command == null) return;

            if (e.PropertyName == nameof(command.IsExecuting) && command.IsExecuting)
            {
                command.Execution.PropertyChanged -= Execution_PropertyChanged;
                command.Execution.PropertyChanged += Execution_PropertyChanged;
            }

            if (e.PropertyName == nameof(command.IsExecuting) && !command.IsExecuting)
            {
                command.Execution.PropertyChanged -= Execution_PropertyChanged;
            }
        }

        private void Execution_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Exception")
            {
                var task = sender as NotifyTaskCompletion<bool>;
                dialogService.ShowMessageBox(this, task.Exception.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion Commands

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Password.Dispose();
                }

                disposedValue = true;
            }
        }

        #endregion IDisposable Support
    }
}
