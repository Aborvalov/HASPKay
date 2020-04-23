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
            BdTypeKeyDao test;
            int tt;
            TypeKey key = new TypeKey { Name = "ertertert" };
            using(var db = new EntitesContext())
            {
                test = new BdTypeKeyDao(db);
                tt = test.Add(key);
            }

        }
    }
}
