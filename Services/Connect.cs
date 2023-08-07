using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformapp.Services
{
    class Connect
    {
        static string ServerName = "DESKTOP-CJ2TEH3";
        static string Database = "demoapi";
        static string Username = "sa";
        static string Password = "123";
        public static string ConnectionString = $"Provider=SQLOLEDB;Data Source={ServerName};Initial Catalog={Database};User ID={Username};Password={Password}";

    }
}
