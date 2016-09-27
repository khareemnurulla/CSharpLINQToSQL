using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CSharpLINQ
{
    public class Connection
    {
        public dbCSharpLinqToSqlDataContext db;
        public Connection() {
            db = new dbCSharpLinqToSqlDataContext(ConnectionString());
        }

        string ConnectionString() {
            return (Properties.Settings.Default.dbCSharpLinqConnectionString.ToString());
        }
    }
}
