using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.CadastroCliente.Data.Repositorio.Interfaces.Base
{
    public interface IRepository<T>:IDisposable where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
