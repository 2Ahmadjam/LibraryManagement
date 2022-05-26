using LibraryManagement.API.Common.EF;
using KitapYonetim.Common.Context;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.API.Services
{

    public class StudentsService : IStudentsService
        {

            private readonly KYDbContext _context;

            public StudentsService(KYDbContext context)
            {
                _context = context;
            }

            public async Task<Student> CreateStudent(Student student)
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();

                return student;
            }

            public async Task DeleteStudent(int id)
            {
                var student = await _context.Students.FindAsync(id);
                if (student == null)
                {
                    throw new NullReferenceException();
                }
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();

            }

            public async Task<Student> GetStudentById(int id)
            {
                var student = await _context.Students.FindAsync(id);

                if (student == null)
                {
                    return null;
                }

                return student;
            }

            public async Task<IList<Student>> GetStudents()
            {
                return await _context.Students.ToListAsync();
            }

        public Task<IList<Student>> GetStudent()
        {
            throw new NotImplementedException();
        }


        public async Task UpdateStudent(Student student)
            {
                _context.Entry(student).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        throw new NullReferenceException();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

 

        private bool StudentExists(int id)
            {
                return _context.Students.Any(e => e.Id == id);
            }
        }
}


