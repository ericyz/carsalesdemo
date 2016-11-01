using System.Collections;
using System.Collections.Generic;
using CarSalesDemo.Model;
using CarSalesDemo.Model.Interface;

namespace CarSalesDemo.Repository.Interface
{
    public interface IRepository<T> where T: IEntity
    {
        IEnumerable<T> ReadAll();
        T Read(int id);
        void Update(int id, T entity);
        void Insert(T entity);
        void Delete(int id);
    }
}