using System.Collections.Generic;

namespace Entites
{
    public  interface IContractEntites<TEntites>
    {
        int Add(TEntites entity);
        bool Remove(int id);
        bool Update(TEntites entity);
        IEnumerable<TEntites> GetAll();
        TEntites GetById(int id);
    }
}
