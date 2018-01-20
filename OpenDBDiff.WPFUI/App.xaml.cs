using GalaSoft.MvvmLight.Threading;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace OpenDBDiff.WPFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static ViewModelLocator locator;
        private static log4net.ILog log;

        static App()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

            DispatcherHelper.Initialize();

            // https://quickconverter.codeplex.com/documentation
            // Setup Quick Converter.
            // Add the System namespace so we can use primitive types (i.e. int, etc.).
            QuickConverter.EquationTokenizer.AddNamespace(typeof(object));
            // Add the System.Windows namespace so we can use Visibility.Collapsed, etc.
            QuickConverter.EquationTokenizer.AddNamespace(typeof(System.Windows.Visibility));
        }

        public static ViewModelLocator Locator
        {
            get
            {
                return locator ?? (locator = new ViewModelLocator());
            }
        }

#if DEBUG
        // Uncaught data binding errors can be a major p.i.t.a.
        // So rather explicitly break the debugger on any one of them
        protected override void OnStartup(StartupEventArgs e)
        {
            PresentationTraceSources.Refresh();
            PresentationTraceSources.DataBindingSource.Listeners.Add(new ConsoleTraceListener());
            PresentationTraceSources.DataBindingSource.Listeners.Add(new DebugTraceListener());
            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Warning | SourceLevels.Error;
            base.OnStartup(e);
        }
#endif


        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            log.Fatal(e.Exception.ToString());

            //Show error dialog in background thread, else the program just kills it.
            Thread newWindowThread = new Thread(new ThreadStart(() =>
            {
                MessageBox.Show(string.Format("Global exception unhandled:\r\n{0}", e.Exception), "Uncaught exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }));

            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start();

            e.Handled = true;
        }
    }
}
