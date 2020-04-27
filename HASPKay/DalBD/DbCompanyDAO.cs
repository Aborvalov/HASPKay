using DalContract;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DalDB
{
    public class DbCompanyDAO : ICompanyDAO
    {
        EntitesContext db { get; }

        public DbCompanyDAO(EntitesContext db)
        {
            this.db = db;
        }

        public int Add(Company entity)
        {
            var compane = db.Companys.Add(entity);
            db.SaveChanges();
            return compane.CompanyId;
        }

        public IEnumerable<Company> GetAll() => db.Companys.ToList();
        public Company GetByFeature(Feature feature) => db.Companys.SingleOrDefault(c => c.HaspKey.Features.Where(f => f.FeatureId == f.FeatureId).Any());

        public Company GetById(int id) => db.Companys.SingleOrDefault(c => c.CompanyId == id);

        public Company GetByNumberKey(string numberKay) => db.Companys.SingleOrDefault(c => c.HaspKey.Number == numberKay);

        public bool Remove(int id)
        {
            var company = GetById(id);
            if (company == null)
                return false;

            try
            {
                db.Companys.Remove(company);
                db.SaveChanges();
            }
            catch { return false; }
            return true;
        }

        public bool Update(Company entity)
        {
            var company = GetById(entity.CompanyId);
            if (company == null)
                return false;

            company.Address = entity.Address;
            company.ContactPerson = entity.ContactPerson;
            company.HaspKey = entity.HaspKey;
            company.Name = entity.Name;
            company.Phone = entity.Phone;

            db.SaveChanges();
            return true;
        }
    }
}
