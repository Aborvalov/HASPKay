using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class BdTypeKeyDao : ITypeKeyDAO
    {
        EntitesContext db { get; }

        public BdTypeKeyDao(EntitesContext db)
        {
            this.db = db;
        }

        public int Add(TypeKey entity)
        {
            var typeKey = db.TypeKeys.Add(entity);
            db.SaveChanges();
            return typeKey.TypeKeyId;
        }

        public IEnumerable<TypeKey> GetAll()
        {
            throw new NotImplementedException();
        }

        public TypeKey GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(TypeKey entity)
        {
            throw new NotImplementedException();
        }
    }
}