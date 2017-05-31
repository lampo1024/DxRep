using System;
using System.Linq;
using DxRep.ServiceFactories;
using DxRep.Services;

namespace DxRep.Client
{
    public class SqlServerDemo
    {

        public void AssemblyLoad()
        {
            var service = ServiceFactory.CreateService<PersonService>();
        }

        public void Run()
        {
            var coBusinessPersonnelService = ServiceFactory.CreateCoBusinessPersonnelService();

            var bp = coBusinessPersonnelService.FindByClause(2, "Id DESC", "LoginName='lisi' OR LoginName='zhangsan'");

            Console.WriteLine("{0}", bp.Count());

            var coServcie = ServiceFactory.CreateCoCooperationApplicationService();
            var co = coServcie.FindByClause(2, "GrabbedDate DESC", "EmailAddress='111@qq.com'");
            co.ToList().ForEach(x =>
            {
                Console.WriteLine("Name:{0},GrabbedDate:{1}", x.Name, x.GrabbedDate);
            });
        }

    }
}
