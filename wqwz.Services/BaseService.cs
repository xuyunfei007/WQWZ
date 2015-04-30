using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace wqwz.Services
{
    public class BaseService<TModel>where TModel:class
    {
        public DbSet<TModel> DbSet { get { return Container.Set<TModel>(); } }
        public wqwz.Models.wqwzContainer Container { get { return Services.Container.GetContainerInstance(); } }

        public int SaveChanges()
        {
            return Container.SaveChanges();
        }
        
        public TModel FindGuid(Guid guid)
        {
            return DbSet.Find(guid);
        }
        public TModel Find(int id)
        {
            return DbSet.Find(id);
        }
        public TModel Remove(TModel entity)
        {
            var newEntity = DbSet.Remove(entity);
            SaveChanges();
            return newEntity;
        }

        public TModel Remove(Guid guid)
        {
            return Remove(FindGuid(guid));
        }
        public TModel Remove(int id)
        {
            return Remove(Find(id));
        }

        public TModel Add(TModel entity)
        {
            var newEntity = DbSet.Add(entity);
            SaveChanges();
            return newEntity;
        }

        public int Update(TModel entity)
        {
            int id = (int)entity.GetType().GetProperty("Id").GetValue(entity, null);
            var oldEntity = Find(id); 
            Container.Entry<TModel>(oldEntity).CurrentValues.SetValues(entity);
            return SaveChanges();
        } 
    }
}
