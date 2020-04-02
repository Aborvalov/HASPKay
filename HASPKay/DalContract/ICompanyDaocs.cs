using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace DalContract
{
    interface ICompanyDaocs
    {
        bool Add(Company kay);
        bool Remove(int id);
        bool Update(Company kay);
        IEnumerable<Company> GetAll();
        Company GetById(int id);
        Company GetByNumberKey(int numberKay);
        Company GetByFeature(Feature feature);
    }
}
