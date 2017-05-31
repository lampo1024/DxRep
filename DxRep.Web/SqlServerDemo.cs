using DxRep.Domain;
using DxRep.Infrastructure;
using DxRep.ServiceFactories;
using DxRep.Services;

namespace DxRep.Web
{
    public class SqlServerDemo
    {
        public IPagedList<CoCooperationApplication> Run(int id,int pageIndex,int pageSize)
        {
            var service = ServiceFactory.CreateService<CoCooperationApplicationService>();
            //var co = service.FindByClause(10, "Id DESC", "Id>" + id);
            var co = service.FindPagedList("Id DESC", "Id>" + id,pageIndex,pageSize);
            return co;
        }

    }
}
