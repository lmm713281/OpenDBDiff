using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Diagnostics.CodeAnalysis;

namespace OpenDBDiff.WPFUI
{
    using Features.DatabaseSelectorUserControl;
    using Features.Main;

    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        static ViewModelLocator()
        {
            ContainerSetup.Setup(ViewModelBase.IsInDesignModeStatic);
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel MainViewModel
        {
            get
            {
                try { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
                catch (Exception ex) { log.Error(ex); throw; }
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public DatabaseSelectorViewModel DatabaseSelectorViewModel
        {
            get
            {
                try { return ServiceLocator.Current.GetInstance<DatabaseSelectorViewModel>(); }
                catch (Exception ex) { log.Error(ex); throw; }
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
