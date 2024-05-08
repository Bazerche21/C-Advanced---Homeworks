using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.Database
{
    public interface IDatabase<T> where T : BaseEntity
    {
        int Insert(T entity); 
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        void DeleteById(int id);
    }
}
