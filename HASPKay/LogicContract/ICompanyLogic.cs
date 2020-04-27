using Entities;
using System.Collections.Generic;

namespace LogicContract
{
    public interface ICompanyLogic
    {
        Company Save(string name, string address, string phone, string contactPerson, HaspKey key);
        Company Update(int id, string name, string address, string phone, string contactPerson, HaspKey key);
        bool Remove(int id);
        List<Company> GetAll();
        Company GetByNumberKey(string numberKey);
        Company GetByFeature(Feature feature);
    }
}
