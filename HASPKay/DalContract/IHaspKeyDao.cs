using Entites;
using System.Collections.Generic;

namespace DalContract
{
    public interface IHaspKeyDao
    {
        bool Add(HaspKey kay);
        bool Remove(int id);
        bool Update(HaspKey kay);
        IEnumerable<HaspKey> GetAll();
        HaspKey GetById(int id);
        HaspKey GetByCompany(Company company);
        /// <summary>
        /// Поиск просроченных ключей.
        /// </summary>
        /// <returns>Список просроченных ключей.</returns>
        IEnumerable<HaspKey> GetByPastDue();
    }
}