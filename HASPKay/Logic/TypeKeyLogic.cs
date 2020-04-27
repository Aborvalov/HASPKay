using DalContract;
using Entities;
using LogicContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TypeKeyLogic : ITypeKeyLogic
    {
        private ITypeKeyDAO typeKeyDAO;
        public TypeKeyLogic(ITypeKeyDAO typeKeyDAO)
        {
            this.typeKeyDAO = typeKeyDAO;
        }

        public List<TypeKey> GetAll() => typeKeyDAO.GetAll().ToList();

        public bool Remove(int id) => typeKeyDAO.Remove(id);

        public TypeKey Save(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Наименование не может быть null или пустым.", nameof(name));

            TypeKey typeKey = new TypeKey { Name = name.Trim(), };

            int id = typeKeyDAO.Add(typeKey);

            typeKey.TypeKeyId = id;
            return typeKey;
        }

        public TypeKey Update(int id, string name)
        {
            TypeKey typeKey = typeKeyDAO.GetById(id);
            if(typeKey == null)
                throw new ArgumentException("Неверный id.", nameof(id));

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Наименование не может быть null или пустым.", nameof(name));

            typeKey.Name = name.Trim();

            if (typeKeyDAO.Update(typeKey))
                return typeKey;

            throw new InvalidOperationException("Не удалсь обновить тип ключа.");
        }
    }
}
