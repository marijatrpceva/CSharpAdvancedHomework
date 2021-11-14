using SEDC.CSharpAdv.VideoRental.Data.BaseMoels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.DataBase
{
    public abstract class GenericRepository<T> 
        where T : BaseEntity
    {
        protected List<T> Db { get; set; }
        private int LastId { get; set; }
        public GenericRepository(List<T> db, int lastId)
        {
            Db = db;
            LastId = lastId;
        }

        public List<T> GetAll()
        {
            return Db;
        }

        //CRUD
        public T GetById(int id)
        {
            return Db.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = ++LastId;
            Db.Add(entity);
            return entity.Id;
        }
        public void Update(T entity)
        {
            var dbEntity = Db.FirstOrDefault(x => x.Id == entity.Id);
            if(dbEntity != null)
            {
                dbEntity = entity;
            }
            //TODO: Throw error if entity does not exist
        } 

        public bool Remove(T entity)
        {
            var prevLength = Db.Count;
            Db.Remove(entity);
            return prevLength != Db.Count; 
        }

        //filtering functions
        public List<T> Filter(Func<T,bool> filter)
        {
            return Db.Where(filter).ToList();
        }
        
    }
}
 