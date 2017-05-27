using DxRep.Repositories;
using DxRep.Services;

namespace DxRep.ServiceFactories
{
    public class PersonServiceFactory
    {
        public static IPersonService Create()
        {
            var service = new PersonService(new PersonRepository());
            return service;
        }
    }
}
