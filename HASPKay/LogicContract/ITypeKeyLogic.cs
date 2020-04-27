using Entities;
using System.Collections.Generic;

namespace LogicContract
{
    public interface ITypeKeyLogic
    {
        TypeKey Save(string name);
        TypeKey Update(int id, string name);
        bool Remove(int id);
        List<TypeKey> GetAll();
    }
}
