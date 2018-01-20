using MvvmDialogs;
using MvvmDialogs.FrameworkDialogs.FolderBrowser;
using MvvmDialogs.FrameworkDialogs.OpenFile;
using MvvmDialogs.FrameworkDialogs.SaveFile;
using System;
using System.ComponentModel;
using System.Windows;

namespace OpenDBDiff.WPFUI.Services.Design
{
    public class DesignDialogService : IDialogService
    {
        public void Show(INotifyPropertyChanged ownerViewModel, INotifyPropertyChanged viewModel)
        {
            throw new NotImplementedException();
        }

        public void Show<T>(INotifyPropertyChanged ownerViewModel, INotifyPropertyChanged viewModel) where T : Window
        {
            throw new NotImplementedException();
        }

        public void ShowCustom<T>(INotifyPropertyChanged ownerViewModel, INotifyPropertyChanged viewModel) where T : IWindow
        {
            throw new NotImplementedException();
        }

        public bool? ShowCustomDialog<T>(INotifyPropertyChanged ownerViewModel, IModalDialogViewModel viewModel) where T : IWindow
        {
            throw new NotImplementedException();
        }

        public bool? ShowDialog(INotifyPropertyChanged ownerViewModel, IModalDialogViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public bool? ShowDialog<T>(INotifyPropertyChanged ownerViewModel, IModalDialogViewModel viewModel) where T : Window
        {
            throw new NotImplementedException();
        }

        public bool? ShowFolderBrowserDialog(INotifyPropertyChanged ownerViewModel, FolderBrowserDialogSettings settings)
        {
            throw new NotImplementedException();
        }

        public MessageBoxResult ShowMessageBox(INotifyPropertyChanged ownerViewModel, string messageBoxText, string caption = "", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None)
        {
            throw new NotImplementedException();
        }

        public bool? ShowOpenFileDialog(INotifyPropertyChanged ownerViewModel, OpenFileDialogSettings settings)
        {
            throw new NotImplementedException();
        }

        public bool? ShowSaveFileDialog(INotifyPropertyChanged ownerViewModel, SaveFileDialogSettings settings)
        {
            throw new NotImplementedException();
        }
    }
}
