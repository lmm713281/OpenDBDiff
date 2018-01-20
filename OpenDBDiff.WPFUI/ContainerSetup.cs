using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using MvvmDialogs;
using System;
using System.Linq;

namespace OpenDBDiff.WPFUI
{
    using Features.DatabaseSelectorUserControl;
    using Features.Main;
    using Services.Design;

    public static class ContainerSetup
    {
        public static void Setup(bool designMode)
        {
            if (ServiceLocator.IsLocationProviderSet)
            {
                if (designMode)
                    return;
                else
                    throw new ArgumentException("Location provider already set");
            }

            var container = new UnityContainer();
            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));

            if (designMode)
            {
                container.RegisterType<IDialogService, DesignDialogService>();
            }
            else
            {
                container.RegisterType<IDialogService, DialogService>(new InjectionFactory(c => new DialogService()));
            }

            container.RegisterType<MainViewModel>();
            container.RegisterType<DatabaseSelectorViewModel>();
        }
    }
}
