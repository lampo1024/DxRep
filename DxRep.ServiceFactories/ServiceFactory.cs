using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DxRep.Repositories;
using DxRep.Services;

namespace DxRep.ServiceFactories
{
    public class ServiceFactory
    {
        public static TService CreateService<TService>() where TService : class
        {
            var service = InstanceFactory.GetServiceInstance<TService>();
            return service;
        }
    }
}
