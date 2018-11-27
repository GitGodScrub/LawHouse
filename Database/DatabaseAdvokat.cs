using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DatabaseAdvokat
    {
        private static DatabaseAdvokat _database = null;
        private DatabaseAdvokat() { }
        public static DatabaseAdvokat Instance()
        {
            if (_database == null)
            {
                _database = new DatabaseAdvokat();

            }
            return _database;
        }
    }
}
