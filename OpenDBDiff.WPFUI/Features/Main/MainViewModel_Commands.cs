using GalaSoft.MvvmLight.CommandWpf;
using Gat.Controls;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace OpenDBDiff.WPFUI.Features.Main
{
    public partial class MainViewModel
    {
        private RelayCommand aboutMenuItemClickCommand;

        public RelayCommand AboutMenuItemClickCommand
        {
            get
            {
                return aboutMenuItemClickCommand ?? (aboutMenuItemClickCommand = new RelayCommand(() =>
                {
                    AboutControlView about = new AboutControlView();
                    AboutControlViewModel acvm = (AboutControlViewModel)about.FindResource("ViewModel");

                    var ea = Assembly.GetExecutingAssembly();
                    acvm.ApplicationLogo = new BitmapImage(new Uri("/Style/images/application.ico", UriKind.Relative));
                    acvm.Publisher = ea.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company ?? "";
                    acvm.PublisherLogo = new BitmapImage(new Uri("/Style/images/logo.png", UriKind.Relative));
                    acvm.AdditionalNotes = @"
                        Icon credits:
                        Main application icon made by Roundicons from www.flaticon.com
                        Silk Icons http://www.famfamfam.com/lab/icons/silk
                        Free FatCow-Farm Fresh Icons http://www.fatcow.com/free-icons";

                    about.Background = new System.Windows.Media.BrushConverter().ConvertFromString("White") as System.Windows.Media.SolidColorBrush;

                    acvm.Window.Content = about;
                    acvm.Window.Show();
                }));
            }
        }
    }
}
