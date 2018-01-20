using GalaSoft.MvvmLight;
using MvvmDialogs;
using System;

namespace OpenDBDiff.WPFUI.Features.Main
{
    public partial class MainViewModel : ViewModelBase
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);

        private readonly IDialogService dialogService;
        private string title;

        public MainViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
        }

        public string Title
        {
            get
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    title = String.Format("OpenDBDiff v{0}", version.ToString());
                }
                return title;
            }
        }
    }
}
