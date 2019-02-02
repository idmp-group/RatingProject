using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DatabaseRepo<TEntity> where TEntity : class
    {
        EF entity = new EF();
        DbSet<TEntity> myDbSet;
        public DatabaseRepo()
        {
            entity.Configuration.ProxyCreationEnabled = false;
            myDbSet = entity.Set<TEntity>();
        }
        public virtual List<TEntity> Read(Expression<Func<TEntity, bool>> where = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, string includes = "", int count = 0)
        {
            IQueryable<TEntity> query = myDbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderby != null)
            {
                query = orderby(query);
            }
            if (count != 0)
            {
                query = query.Take(count);
            }
            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

        public void Create(TEntity newRecord)
        {



            using (var db = new EF())
            {
                db.Set<TEntity>().Add(newRecord);
                db.SaveChanges();
            }

            myDbSet.Add(newRecord);
        }
        public List<TEntity> Read()
        {

            return myDbSet.ToList();
        }
        public TEntity Read(int recordID)
        {
            //return entity.Users.Where(item => item.Id == recordID).Single();
            //return entity.Users.Single(item => item.Id == recordID);
            return myDbSet.Find(recordID);
        }
        public void Update(TEntity newRecord)
        {
            myDbSet.Attach(newRecord);
            entity.Entry(newRecord).State = EntityState.Modified;

        }
        public void Delete(int id)
        {
            TEntity result = Read(id);
            myDbSet.Remove(result);

        }
        public bool Save()
        {
            try { entity.SaveChanges(); return true; }
            catch { return false; }
        }
        //My functions

        //Reading one record with included Entities
        public virtual TEntity Read(Expression<Func<TEntity, bool>> First, string includes)
        {
            IQueryable<TEntity> query = myDbSet;
            foreach (string include in includes.Split(','))
            {
                query = query.Include(include);
            }
            return query.First(First);
        }
        public List<TEntity> ReadLastRecords(int count = 4, string includes = "")
        {
            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    return myDbSet.Include(includes).Take(count).ToList();
                }
            }
            return myDbSet.Take(count).ToList();
        }
        //Find a Record with where(Email or other properties)
        public TEntity ReadOne(Expression<Func<TEntity, bool>> where)
        {
            return myDbSet.Where(where).First();
        }
        //is there a Record with where(other properties)
        public bool FindRecord(Expression<Func<TEntity, bool>> where)
        {
            return myDbSet.Any(where);
        }

        //RemoveAll
        //public void Delete()
        //{
        //    myDbSet.RemoveRange(myDbSet.ToList());
        //}
    }
}
