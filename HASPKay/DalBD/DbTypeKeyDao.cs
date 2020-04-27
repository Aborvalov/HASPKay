using DalContract;
using Entites;
using System.Collections.Generic;
using System.Linq;

namespace DalDB
{
    public class DbTypeKeyDAO : ITypeKeyDAO
    {
        EntitesContext db { get; }

        public DbTypeKeyDAO(EntitesContext db)
        {
            this.db = db;
        }

        public int Add(TypeKey entity)
        {
            var typeKey = db.TypeKeys.Add(entity);
            db.SaveChanges();
            return typeKey.TypeKeyId;
        }

        public IEnumerable<TypeKey> GetAll() => db.TypeKeys.ToList();

        public TypeKey GetById(int id) => db.TypeKeys.SingleOrDefault(key => key.TypeKeyId == id);


        public bool Remove(int id)
        {
            var key = GetById(id);
            if (key == null)
                return false;
            try
            {
                db.TypeKeys.Remove(key);
                db.SaveChanges();
            }
            catch { return false; }
            return true;
        }

        public bool Update(TypeKey entity)
        {
            var key = GetById(entity.TypeKeyId);
            if (key == null)
                return false;

            key.Name = entity.Name;           
            db.SaveChanges();
           
            return true;
        }
    }
}