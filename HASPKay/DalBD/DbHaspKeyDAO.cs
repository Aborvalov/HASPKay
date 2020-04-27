using DalContract;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DalDB
{
    public class DbHaspKeyDAO : IHaspKeyDao
    {
        EntitesContext db { get; }
        public DbHaspKeyDAO(EntitesContext db)
        {
            this.db = db;
        }

        public int Add(HaspKey entity)
        {
            var haspKey = db.HaspKeys.Add(entity);
            db.SaveChanges();
            return haspKey.HaspKeyId;
        }

        public IEnumerable<HaspKey> GetAll() => db.HaspKeys.ToList();

        public IEnumerable<HaspKey> GetByCompany(Company company) => db.HaspKeys.Where(hk => hk.Companies == company).ToList();

        public HaspKey GetById(int id) => db.HaspKeys.SingleOrDefault(hs => hs.HaspKeyId == id);

        public IEnumerable<HaspKey> GetByPastDue()
        {
            var haspKey = GetAll();
            List<HaspKey> PastDue = new List<HaspKey>();

            foreach (var hk in haspKey)
            {
                Feature[] array_f = hk.Features.ToArray();
                if (array_f.Length > 0)
                {
                    Feature f = array_f[array_f.Length - 1];
                    if (f.Firmware.AddDays(f.Validity) < DateTime.Now)
                        PastDue.Add(hk);
                }
            }

            return PastDue;
        }

        public bool Remove(int id)
        {
            var haspKey = GetById(id);
            if (haspKey == null)
                return false;

            try
            {
                db.HaspKeys.Remove(haspKey);
                db.SaveChanges();
            }
            catch { return false; }
            return true;
        }

        public bool Update(HaspKey entity)
        {
            var haspKey = GetById(entity.HaspKeyId);
            if (haspKey == null)
                return false;

            haspKey.AddInfo = entity.AddInfo;
            haspKey.Companies = entity.Companies;
            haspKey.Features = entity.Features;
            haspKey.Number = entity.Number;
            haspKey.TypeKey = entity.TypeKey;

            db.SaveChanges();
            return true;
        }
    }
}
