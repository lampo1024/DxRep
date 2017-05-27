using DxRep.Repositories;
using DxRep.Services;

namespace DxRep.ServiceFactories
{
    public class CoCooperationApplicationServiceFactory
    {
        public static ICoCooperationApplicationService Create()
        {
            var service = new CoCooperationApplicationService(new CoCooperationApplicationRepository());
            return service;
        }
    }
}
