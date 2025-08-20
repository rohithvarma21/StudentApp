using StudentCoreDIApp.Models;
using System.Collections.Generic;
namespace StudentCoreDIApp.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
    }
}
