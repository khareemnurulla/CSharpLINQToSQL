using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLINQ.Controller
{
    class CourseController
    {
        dbCSharpLinqToSqlDataContext Database = new Connection().db;

        public System.Data.Linq.Table<Course> List() {
            return (Database.Courses);
        }
    }
}
