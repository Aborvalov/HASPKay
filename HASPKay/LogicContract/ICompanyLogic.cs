using Entites;
using System.Collections.Generic;

namespace LogicContract
{
    interface ICompanyLogic
    {
        Company Save(string name, string address, string phone, string contactPerson);
        Company Update(int id, string name, string address, string phone, string contactPerson);
        bool Remove(int id);
        List<Company> GetAll();
        Company GetByNumberKey(int numberKey);
        Company GetByFeature(Feature feature);
    }
}
