using Entites;
using System.Collections.Generic;

namespace DalContract
{
    public interface IHaspKeyDao : IContractEntites<HaspKey>
    {
        HaspKey GetByCompany(Company company);
        /// <summary>
        /// Поиск просроченных ключей.
        /// </summary>
        /// <returns>Список просроченных ключей.</returns>
        IEnumerable<HaspKey> GetByPastDue();
    }
}