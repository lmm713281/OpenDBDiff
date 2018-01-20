using Microsoft.Practices.ServiceLocation;
using Sanlam.StructuredSolutions.Krommes.Domain;

namespace Sanlam.StructuredSolutions.Krommes.GUI
{
    public static class UnitOfWorkHelper
    {
        public static IUnitOfWork Get()
        {
            return ServiceLocator.Current.GetInstance<IUnitOfWork>();
        }
    }
}
