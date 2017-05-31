using System.Collections.Generic;
using DxRep.Infrastructure;
using DxRep.Repositories;

namespace DxRep.Services
{
    public abstract class GenericService<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;

        protected GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<T> FindAll()
        {
            return _repository.FindAll();
        }

        public virtual T FindById(int id)
        {
            return _repository.FindById(id);
        }

        public virtual IPagedList<T> FindPagedList(string orderBy, string where, int pageIndex = 1, int pageSize = 20)
        {
            return _repository.FindPagedList(orderBy, where, pageIndex, pageSize);
        }

        public virtual int Insert(T entity)
        {
            return _repository.Insert(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }

        public virtual bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public virtual bool Delete(string ids)
        {
            return _repository.Delete(ids);
        }
    }
}
