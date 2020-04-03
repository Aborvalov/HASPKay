using System.Collections.Generic;

namespace DalContract
{
    public  interface IContractEntites<TEntites>
    {
        bool Add(TEntites entity);
        bool Remove(TEntites id);
        bool Update(TEntites entity);
        IEnumerable<TEntites> GetAll();
        TEntites GetById(int id);
    }
}
