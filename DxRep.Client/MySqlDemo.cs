using System;
using System.Linq;
using DxRep.ServiceFactories;

namespace DxRep.Client
{
    public class MySqlDemo
    {
        public void Run()
        {
            
            var pServcie = ServiceFactory.CreatePersonService();
            var co = pServcie.FindByClause(20).ToList();
            co.ForEach(x =>
            {
                Console.WriteLine("FirstName:{0}, LastName:{1},DateCreated:{2},ModifiedOn:{3},x.Active:{4},x.Age:{5}", x.FirstName, x.LastName,x.DateCreated,x.ModifiedOn,x.Active,x.Age);
            });
        }
    }
}
