using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformapp.Services
{
    class Connect
    {
        static string ServerName = "DESKTOP-O535D71\\SQLEXPRESS";
        static string Database = "Demo_Api";
        static string Username = "54314";
        static string Password = "123";
        public static string ConnectionString = $"Provider=SQLOLEDB;Data Source={ServerName};Initial Catalog={Database};User ID={Username};Password={Password}";

    }
}
