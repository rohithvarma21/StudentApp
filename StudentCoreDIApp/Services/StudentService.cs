using StudentCoreDIApp.Models;
using System.Collections.Generic;

namespace StudentCoreDIApp.Services

{
    public class StudentService : IStudentService
    {
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
        {
            new Student{ Id=1, Name="John", Age=20 },
            new Student{ Id=2, Name="RAM", Age=20 },
            new Student{ Id=3, Name="Sara", Age=22 }
        };
        }


    }
}
