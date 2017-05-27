using System;
using System.Linq;
using DxRep.ServiceFactories;

namespace DxRep.Client
{
    public class Test
    {
        public void Run()
        {
            var coBusinessPersonnelService = CoBusinessPersonnelServiceFactory.Create();

            var bp = coBusinessPersonnelService.FindByClause(2,"Id DESC", "LoginName='lisi' OR LoginName='zhangsan'");

            Console.WriteLine("{0}",bp.Count());


            var coServcie = CoCooperationApplicationServiceFactory.Create();
            var co = coServcie.FindByClause(2, "GrabbedDate DESC", "EmailAddress='111@qq.com'");
            co.ToList().ForEach(x =>
            {
                Console.WriteLine("Name:{0},GrabbedDate:{1}", x.Name,x.GrabbedDate);
            });
            
        }
    }
}
