using System.Linq;
using System.Web.Http;
using DxRep.Domain;
using DxRep.Web.Models;

namespace DxRep.Web.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(int id, int pageIndex, [FromUri]int pageSize)
        {
            var test = new SqlServerDemo();
            var list = test.Run(id, pageIndex, pageSize);
            var gridModel = new DataSource<CoCooperationApplication>(list)
            {
                Data = list.Select(x => x)
            };

            return Ok(gridModel);
        }

    }

    public class QueryCommand
    {
        public int Id { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
