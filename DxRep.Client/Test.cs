using System;
using System.Linq;
using DxRep.ServiceFactories;

namespace DxRep.Client
{
    public class Test
    {
        public void Run()
        {
            
            var pServcie = PersonServiceFactory.Create();
            var co = pServcie.FindByClause(20);
            co.ToList().ForEach(x =>
            {
                Console.WriteLine("FirstName:{0}, LastName:{1},DateCreated:{2},ModifiedOn:{3}", x.FirstName, x.LastName,x.DateCreated,x.ModifiedOn);
            });
            
           
            /*

           var coBusinessPersonnelService = CoBusinessPersonnelServiceFactory.Create();

           var bp = coBusinessPersonnelService.FindByClause(2,"Id DESC", "LoginName='lisi' OR LoginName='zhangsan'");

           Console.WriteLine("{0}",bp.Count());
            /*

          var coServcie = CoCooperationApplicationServiceFactory.Create();
          var co = coServcie.FindByClause(2, "GrabbedDate DESC", "EmailAddress='111@qq.com'");
          co.ToList().ForEach(x =>
          {
              Console.WriteLine("Name:{0},GrabbedDate:{1}", x.Name,x.GrabbedDate);
          });
          */
        }
    }
}
