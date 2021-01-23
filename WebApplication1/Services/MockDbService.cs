using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService() 
        {
            _students = new List<Student>
            {
                new Student{IdStudent=1 ,fname="Taha" ,lname="Savas" ,indexnumber="s18409"},
                 new Student{IdStudent=2 ,fname="Johny " ,lname="Bravo" ,indexnumber="s01234"},
                  new Student{IdStudent=3 ,fname="Elon" ,lname="Musk" ,indexnumber="s07711"}
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
