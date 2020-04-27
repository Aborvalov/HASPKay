using DalDB;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbHaspKeyDAO test;
            int number;
            bool flag;
            Company tt;

            Feature f = new Feature
            {
                Firmware = DateTime.Now,
                Name = "Feature ",
                Number = 5555555,
                Validity = -123,
                FeatureId = 1,
            };
            Company com = new Company
            {
                Name = "Test",
                Address = "{jkmeyjdf",
                ContactPerson = "qwe qwe qwe",
                Phone = "123-123-123",
                CompanyId = 1,
            };
            var Key = new HaspKey
            {
                AddInfo = "sdf",
                HaspKeyId = 1,
                Number = "123-321",
                TypeKey = new TypeKey { Name = "qqqqqq" },
                
            };
            Key.Features.Add(f);
            Key.Companies.Add(com);


            
            using(var db = new EntitesContext())
            {
                test = new DbHaspKeyDAO(db);
                 number = test.Add(Key);
                var t1 = test.GetById(1);
                var t2 = test.GetByCompany(com);

            }

        }
    }
}
