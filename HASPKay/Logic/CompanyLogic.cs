using DalContract;
using Entities;
using LogicContract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class CompanyLogic : ICompanyLogic
    {
        private ICompanyDAO companyDAO;
        public CompanyLogic(ICompanyDAO companyDAO)
        {
            this.companyDAO = companyDAO;
        }

        public List<Company> GetAll() => companyDAO.GetAll().ToList();

        public Company GetByFeature(Feature feature) => companyDAO.GetByFeature(feature);

        public Company GetByNumberKey(string numberKey) => companyDAO.GetByNumberKey(numberKey);

        public bool Remove(int id) => companyDAO.Remove(id);

        public Company Save(string name, string address, string phone, string contactPerson, HaspKey key)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Наименование компании не может быть null или пустым.", nameof(name));
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес компании не может быть null или пустым.", nameof(address));
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес компании не может быть null или пустым.", nameof(address));
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Телефон контактного лица не может быть null или пустым.", nameof(phone));
            if (string.IsNullOrWhiteSpace(contactPerson))
                throw new ArgumentException("Контактное лицо не может быть null или пустым.", nameof(contactPerson));

            /*
             * Для ключа не делаю проверку, т.к. поллогаю возможность создание компании без ключа.
             * (К примеру, чтобы создать все компании и в дальнейшем привязять к ним ключи.)             * 
             */


            Company company = new Company()
            {
                Name          = name.Trim(),
                Address       = address.Trim(),
                ContactPerson = contactPerson.Trim(),
                Phone         = phone.Trim(),
                HaspKey           = key,
            };

            int id = companyDAO.Add(company);
            if (id == -1)
                throw new InvalidOperationException("Не удалсь создать компанию.");

            company.CompanyId = id;
            return company;
        }

        public Company Update(int id, string name, string address, string phone, string contactPerson, HaspKey key)
        {
            Company company = companyDAO.GetById(id);

            if (company == null)
                throw new ArgumentException("Неверный id компании.", nameof(id));






            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Наименование компании не может быть null или пустым.", nameof(name));
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес компании не может быть null или пустым.", nameof(address));
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес компании не может быть null или пустым.", nameof(address));
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Телефон контактного лица не может быть null или пустым.", nameof(phone));
            if (string.IsNullOrWhiteSpace(contactPerson))
                throw new ArgumentException("Контактное лицо не может быть null или пустым.", nameof(contactPerson));





            company.Address = address.Trim();
            company.ContactPerson = contactPerson.Trim();
            company.HaspKey = key;
            company.Name = name.Trim();
            company.Phone = phone.Trim();

            if (companyDAO.Update(company))
                return company;

            throw new InvalidOperationException("Не удалсь обновить компанию.");
        }
    }
}
