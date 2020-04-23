using System.Collections.Generic;

namespace Entites
{
    public interface IHaspKeyDao : IContractEntites<HaspKey>
    {
        IEnumerable<HaspKey> GetByCompany(Company company);
        /// <summary>
        /// Поиск просроченных ключей.
        /// </summary>
        /// <returns>Список просроченных ключей.</returns>
        IEnumerable<HaspKey> GetByPastDue();
    }
}