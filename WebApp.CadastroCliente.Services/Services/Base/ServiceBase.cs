using System;
using System.Collections.Generic;
using System.Text;
using WebApp.CadastroCliente.Data.Repositorio.Interfaces.Base;
using WebApp.CadastroCliente.Services.Interfaces.Base;

namespace WebApp.CadastroCliente.Services.Services.Base
{
    public class ServiceBase<T>:IServiceBase<T>, IDisposable where T:class
    {

        private readonly IRepository<T> _repository;

        public ServiceBase(IRepository<T> Repository)
        {
            _repository = Repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
