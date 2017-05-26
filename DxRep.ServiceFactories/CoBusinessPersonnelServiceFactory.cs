using DxRep.Repositories;
using DxRep.Services;

namespace DxRep.ServiceFactories
{
    public class CoBusinessPersonnelServiceFactory
    {
        public static ICoBusinessPersonnelService Create()
        {
            var service = new CoBusinessPersonnelService(new CoBusinessPersonnelRepository());
            return service;
        }
    }
}
