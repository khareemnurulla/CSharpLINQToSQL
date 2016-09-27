using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CSharpLINQ.Controller
{
    class StudentController
    {
        dbCSharpLinqToSqlDataContext Database = new Connection().db;

        public System.Data.Linq.Table<Student> List() {
            //System.Data.Linq.Table<Student> table;
            //table = Database.Students;
            //var s = from t in table
            //        select t;
            //return (table);

            return(Database.Students);
        }

        public void Add(string StudentID, string Name, int Age, string Email, int CourseID) {
            Student student = new Student();  
            student.StudentID = StudentID;
            student.Name = Name;
            student.Age = Age;
            student.Email = Email;
            student.CourseID = CourseID;
            Database.Students.InsertOnSubmit(student);
            Database.SubmitChanges();
        }

        public void Update() {

        }

        public void Delete(string StudentID) {
            Student DeleteStudent = Database.Students
                .FirstOrDefault(s => s.StudentID == StudentID);
            Database.Students.DeleteOnSubmit(DeleteStudent);
            Database.SubmitChanges();
        }
    }
}
