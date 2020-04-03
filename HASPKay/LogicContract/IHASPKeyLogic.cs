using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicContract
{
    public interface IHASPKeyLogic
    {
        HaspKey Save(string number, TypeKey type, Feature feature, Company company, string other);
        List<HaspKey> GetAll();
        bool Remove(int id);
        HaspKey Update(int id, string number, TypeKey type, Feature feature, Company company, string other);
        HaspKey GetByCompany(Company company);
        List<HaspKey> GetByPastDue();
    }
}
