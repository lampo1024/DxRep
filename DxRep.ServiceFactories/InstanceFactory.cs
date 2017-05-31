using System;
using System.Collections.Generic;
using System.Linq;

namespace DxRep.ServiceFactories
{
    public class InstanceFactory
    {
        private static readonly Dictionary<string, Type> DictType = new Dictionary<string, Type>();

        private static readonly Dictionary<string, object> DictInstances = new Dictionary<string, object>();

        static InstanceFactory()
        {
            var asms = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("Repositories")).ToList();
            var cls = asms
                .SelectMany(t => t.GetTypes())
                .Where(t => { return t.Namespace != null && !t.IsAbstract && !t.IsGenericType && (t.IsClass && t.Namespace.EndsWith("Repositories")); }).ToList();

            cls.ForEach(x =>
            {
                if (!DictType.ContainsKey(x.Name))
                {
                    DictType[x.Name] = x;
                }
            });
        }

        public static void Init()
        {
            
        }


        public static TService GetServiceInstance<TService>()
        {
            return CreateServiceInstance<TService>();
        }

        private static TService CreateServiceInstance<TService>()
        {
            var serviceType = typeof(TService);
            var serviceDictKey = serviceType.Name;
            
            if (DictInstances.ContainsKey(serviceDictKey))
            {
                return (TService)DictInstances[serviceDictKey];
            }

            var repoType = DictType[serviceDictKey.Replace("Service", "Repository")];
            var repo = CreateRepositoryInstance(repoType);

            var service = (TService)Activator.CreateInstance(typeof(TService), repo);
            DictInstances[serviceDictKey] = service;
            return service;
        }

        private static object CreateRepositoryInstance(Type type)
        {
            var key = type.Name;
            if (DictInstances.ContainsKey(key))
            {
                return DictInstances[key];
            }
            var repo = Activator.CreateInstance(type);
            DictInstances[key] = repo;
            return repo;
        }
    }
}
