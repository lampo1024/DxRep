using System;
using DxRep.ServiceFactories;

namespace DxRep.Client
{
    public class Test
    {
        public void Run()
        {
            var service = CoBusinessPersonnelServiceFactory.Create();

            var bp = service.FindAll();

            //Console.WriteLine("{0}",bp.LoginName);
        }
    }
}
