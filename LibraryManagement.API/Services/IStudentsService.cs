using KitapYonetim.Common.EF;
using LibraryManagement.API.Common.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.API.Services
{
    public interface IStudentsService
    {
        Task<IList<Student>> GetStudents();

        Task<Student> GetStudentById(int id);

        Task<Student> CreateStudent(Student student);

        Task UpdateStudent(Student student);

        Task DeleteStudent(int id);
    }
}