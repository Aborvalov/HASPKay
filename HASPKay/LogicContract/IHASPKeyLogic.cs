using Entites;
using System.Collections.Generic;

namespace LogicContract
{
    public interface IHASPKeyLogic
    {
        HaspKey Save(string number, TypeKey type, Feature feature, Company company, string other);
        List<HaspKey> GetAll();
        bool Remove(int id);
        HaspKey Update(int id, string number, TypeKey type, Feature feature, Company company, string other);
        List<HaspKey> GetByCompany(Company company);
        List<HaspKey> GetByPastDue();
    }
}