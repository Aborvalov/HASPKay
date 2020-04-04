using DalContract;
using Entites;
using LogicContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class HaspKeyLogic : IHASPKeyLogic
    {
        private IHaspKeyDao haspKeyDao;

        public HaspKeyLogic(IHaspKeyDao haspKeyDao)
        {
            this.haspKeyDao = haspKeyDao;
        }

        public List<HaspKey> GetAll() => haspKeyDao.GetAll().ToList();

        public List<HaspKey> GetByCompany(Company company) => haspKeyDao.GetByCompany(company).ToList();

        public List<HaspKey> GetByPastDue() => haspKeyDao.GetByPastDue().ToList();

        public bool Remove(int id) => haspKeyDao.Remove(id);

        public HaspKey Save(string number, TypeKey type, Feature feature, Company company, string other)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Номер не может быть null или пустым.", nameof(number));
            if (feature == null)
                throw new NullReferenceException("Features не может быть null.");
            if (company == null)
                throw new NullReferenceException("Компания не может быть null.");
            if(Enum.IsDefined(typeof(TypeKey), type))
                throw new ArgumentException("Неправильный тип ключа.", nameof(type));

            List<Company> companies = new List<Company>{company};
            List<Feature> features  = new List<Feature>{feature};

            HaspKey key = new HaspKey()
            {
                Number       = number.Trim(),
                Company      = companies,
                TypeKey      = type,
                FeaturesKeys = features,
                AddInfo      = other.Trim(),
            };

            int id = haspKeyDao.Add(key);
            if (id == -1)
                throw new InvalidOperationException("Не удалсь создать HASP-ключ.");
            
            key.HaspKeyId = id;
            return key;
        }

        public HaspKey Update(int id, string number, TypeKey type, Feature feature, Company company, string other)
        {
            HaspKey key = haspKeyDao.GetById(id);

            if (key == null)
                throw new ArgumentException("Неверный id HASP-ключ.", nameof(id));           
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Номер не может быть null или пустым.", nameof(number));
            if (feature == null)
                throw new NullReferenceException("Features не может быть null.");
            if (company == null)
                throw new NullReferenceException("Компания не может быть null.");
            if (Enum.IsDefined(typeof(TypeKey), type))
                throw new ArgumentException("Неправильный тип ключа.", nameof(type));


            
            /*
            List<Company> companies = new List<Company> { company };
            List<Feature> features = new List<Feature> { feature };

            HaspKey key = new HaspKey()
            {
                Number = number.Trim(),
                Company = companies,
                TypeKey = type,
                FeaturesKeys = features,
                AddInfo = other.Trim(),
            };

            if (haspKeyDao.Add(key))
                return key;
            */
            throw new InvalidOperationException("Не удалсь создать HASPKey.");
        }
    }
}
