using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.Database
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }
        public int Id { get; set; }

        public Database()
        {
            Items = new List<T>();
            Id = 1;
        }

        public void DeleteUser(int id)
        {
            T dbItem = Items.FirstOrDefault(x => x.Id == id);
            if (dbItem == null)
            {
                throw new Exception($"Item with id {id} was not found.");
            }

            Items.Remove(dbItem);
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public T GetById(int id)
        {
            T dbItem = Items.FirstOrDefault(x => x.Id == id);
            return dbItem;
        }

        public int Insert(T entity)
        {
            entity.Id = Id++;
            Items.Add(entity);
            return entity.Id;
        }

        public void Update(T entity)
        {
            T dbItem = Items.FirstOrDefault(x => x.Id == entity.Id);
            if (dbItem == null)
            {
                throw new Exception($"Item with id {entity.Id} was not found.");
            }

            int index = Items.IndexOf(dbItem);
            Items[index] = entity;
        }
    }
}
